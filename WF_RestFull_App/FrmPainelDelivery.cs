using Application.Constant;
using Application.Model;
using Application.Services.Domain.Standard;
using Application.Services.Interface.Standard;
using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Windows.Forms;

namespace WF_RestFull_App
{
    public partial class FrmPainelDelivery : Form
    {
        public FrmPainelDelivery()
        {
            InitializeComponent();
        }

        private Token _token;

        private List<EventAcknowledgment> FEventAcknowledgmentList = new List<EventAcknowledgment>();

        private List<EventoPolling> eventoPolling = new List<EventoPolling>();

        private List<Evento> evento = new List<Evento>();

        private List<Order> FPendingOrderList = new List<Order>();

        private void FrmPainelDelivery_Load(object sender, EventArgs e)
        {
            tcPainelDelivery.SelectedTab = tpPedidos;
            _token = GetAccessOauthToken(new Service());

            dgvPedidosAgendados.DataSource = evento;
        }

        public Token GetAccessOauthToken(IService service)
        {
            _token = service.GetAccessOauthToken(new UserAPI()).Result;
            return _token;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IService service = new Service();

            if ((_token.IsTokenValid) || (GetAccessOauthToken(service).IsTokenValid))
            {
                var eventPollingList = service.GetEventPolling(_token);

                richTextBox1.AppendText($"'eventPollingList'");
                richTextBox1.AppendText($"Conteudo JSON: {eventPollingList.Json}");
                richTextBox1.AppendText($"Mensagem: {eventPollingList.Message}");             
                richTextBox1.AppendText($"Status:{eventPollingList.Success}");
                richTextBox1.AppendText(" ");

                if (eventPollingList.Result != null)
                {
                    eventoPolling.Add(new EventoPolling()
                    {
                        EventoPollingId = eventoPolling.Count + 1,
                        QuantidadeEventos = eventPollingList.Result.Count,
                        ConteudoJSON = eventPollingList.Json
                    });
                                    
                    foreach (var item in eventPollingList.Result)
                    {
                        evento.Add(new Evento()
                        {
                            EventoId = evento.Count + 1,
                            EventoPollingId = eventoPolling.Count + 1,
                            CorrelacaoId = item.CorrelationId,
                            PedidoId = item.Id,
                            CriadoEm = item.CreatedAt,
                            Confirmado = false,
                            EventoCodigo = item.Code,
                            ConteudoJSON = JsonSerializer.Serialize(item)
                        });

                        if ((item.Code == PollingEventStatusCode.PLACED) || (item.Code == PollingEventStatusCode.INTEGRATED))
                        {                            
                            var EventPendingOrder = service.GetPendingOrder(_token, item.CorrelationId);
                            if (EventPendingOrder.Success == true)
                            {   

                                if (EventPendingOrder != null)
                                {
                                    FPendingOrderList.Add(EventPendingOrder.Result);
                                }
                            }
                        }

                        FEventAcknowledgmentList.Add(new EventAcknowledgment() { id = item.Id });
                    }

                    dgvPedidosAgendados.DataSource = null;
                    dgvPedidosAgendados.DataSource = evento;
                    dgvPedidosAgendados.Refresh();
                }                
            }



            //DoCommunicationTasks;

            //        if not FTurnOnMusic and(not QryOrders1.IsEmpty) then
            //        begin
            //{ Contínua: a reprodução é repetida num efeito de loop. Este tipo de reprodução precisa ser assíncrona}
            //        if FileExists(FNotificationSoundPath) then
            //          FTurnOnMusic := PlaySound(PWideChar(FNotificationSoundPath), 1, SND_ASYNC or SND_LOOP)
            //else
            //        FTurnOnMusic:= PlaySound('SYSTEMASTERIX', 1, SND_ASYNC or SND_LOOP);
            //        //MessageBeep(MB_ICONASTERISK);
            //        end;

            //        { Interrompe uma reprodução contínua}
            //        if FTurnOnMusic and QryOrders1.IsEmpty then
            //FTurnOnMusic:= not PlaySound(nil, 1, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (FEventAcknowledgmentList.Count > 0)
            {
                IService service = new Service();
                var eventAcknowledgmentPolling = service.SendEventAcknowledgmentPolling(_token, FEventAcknowledgmentList);
                richTextBox1.AppendText($"'eventAcknowledgmentPolling'");
                richTextBox1.AppendText($"{eventAcknowledgmentPolling.Json}");
                richTextBox1.AppendText($"{eventAcknowledgmentPolling.Message}");
                richTextBox1.AppendText($"{eventAcknowledgmentPolling.Success}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FPendingOrderList.Count > 0)
            {
                foreach (var item in FPendingOrderList)
                {
                    IService service = new Service();
                    var sendOrdersStatus = service.SendOrdersStatus(_token,
                        new OrderStatus()
                        {
                            Reference = item.Reference,
                            EventOrderCode = PollingEventStatusCode.CONFIRMED
                        });

                    richTextBox1.AppendText($"'sendOrdersStatus'");
                    richTextBox1.AppendText($"{sendOrdersStatus.Json}");
                    richTextBox1.AppendText($"{sendOrdersStatus.Message}");
                    richTextBox1.AppendText($"{sendOrdersStatus.Success}");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FEventAcknowledgmentList.Clear();
            richTextBox1.Clear();
        }
    }
}
