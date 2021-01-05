using Application.Constant;
using Application.Model;
using Application.Services.Domain.Standard;
using Application.Services.Interface.Standard;
using System;
using System.Collections.Generic;
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

        private List<Order> FPendingOrderList = new List<Order>();

        private void FrmPainelDelivery_Load(object sender, EventArgs e)
        {
            tcPainelDelivery.SelectedTab = tpPedidos;
            _token = GetAccessOauthToken(new Service());            
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

                richTextBox2.AppendText($"'eventPollingList'");
                richTextBox2.AppendText($"{eventPollingList.Json}");
                richTextBox2.AppendText($"{eventPollingList.Message}");
                richTextBox2.AppendText($"{eventPollingList.Success}");
                
                if (eventPollingList.Result != null)
                {
                    foreach (var item in eventPollingList.Result)
                    {
                        if ((item.Code == PoolingEventStatusCode.PLACED) || (item.Code == PoolingEventStatusCode.INTEGRATED))
                        {
                            var EventPendingOrder = service.GetPendingOrder(_token, item.CorrelationId);
                            if (EventPendingOrder.Success == true)
                            {
                                richTextBox2.AppendText($"'EventPendingOrder'");
                                richTextBox2.AppendText($"{EventPendingOrder.Json}");
                                richTextBox2.AppendText($"{EventPendingOrder.Message}");
                                richTextBox2.AppendText($"{EventPendingOrder.Success}");

                                if (EventPendingOrder != null)
                                {
                                    FPendingOrderList.Add(EventPendingOrder.Result);
                                }
                            }
                        }

                        FEventAcknowledgmentList.Add(new EventAcknowledgment() { id = item.Id });
                    }
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
                richTextBox2.AppendText($"'eventAcknowledgmentPolling'");
                richTextBox2.AppendText($"{eventAcknowledgmentPolling.Json}");
                richTextBox2.AppendText($"{eventAcknowledgmentPolling.Message}");
                richTextBox2.AppendText($"{eventAcknowledgmentPolling.Success}");
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
                            EventOrderCode = PoolingEventStatusCode.CONFIRMED
                        });

                    richTextBox2.AppendText($"'sendOrdersStatus'");
                    richTextBox2.AppendText($"{sendOrdersStatus.Json}");
                    richTextBox2.AppendText($"{sendOrdersStatus.Message}");
                    richTextBox2.AppendText($"{sendOrdersStatus.Success}");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FEventAcknowledgmentList.Clear();
            richTextBox2.Clear();
        }
    }
}
