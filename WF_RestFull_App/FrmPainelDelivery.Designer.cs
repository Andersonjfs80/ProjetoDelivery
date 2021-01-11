namespace WF_RestFull_App
{
    partial class FrmPainelDelivery
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcPainelDelivery = new System.Windows.Forms.TabControl();
            this.tpPedidos = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.gbPedidosConfirmados = new System.Windows.Forms.GroupBox();
            this.gbPendentesAgendados = new System.Windows.Forms.GroupBox();
            this.dgvPedidosAgendados = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tpConfiguracoes = new System.Windows.Forms.TabPage();
            this.gbDadosConexaoAPI = new System.Windows.Forms.GroupBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tbClienteSecret = new System.Windows.Forms.TextBox();
            this.lblClienteSecret = new System.Windows.Forms.Label();
            this.tbClienteId = new System.Windows.Forms.TextBox();
            this.lblClienteId = new System.Windows.Forms.Label();
            this.gbTeste = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tcPainelDelivery.SuspendLayout();
            this.tpPedidos.SuspendLayout();
            this.gbPendentesAgendados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosAgendados)).BeginInit();
            this.tpConfiguracoes.SuspendLayout();
            this.gbDadosConexaoAPI.SuspendLayout();
            this.gbTeste.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPainelDelivery
            // 
            this.tcPainelDelivery.Controls.Add(this.tpPedidos);
            this.tcPainelDelivery.Controls.Add(this.tpConfiguracoes);
            this.tcPainelDelivery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPainelDelivery.Location = new System.Drawing.Point(0, 0);
            this.tcPainelDelivery.Name = "tcPainelDelivery";
            this.tcPainelDelivery.SelectedIndex = 1;
            this.tcPainelDelivery.Size = new System.Drawing.Size(666, 545);
            this.tcPainelDelivery.TabIndex = 0;
            // 
            // tpPedidos
            // 
            this.tpPedidos.Controls.Add(this.richTextBox2);
            this.tpPedidos.Controls.Add(this.gbPedidosConfirmados);
            this.tpPedidos.Controls.Add(this.gbPendentesAgendados);
            this.tpPedidos.Controls.Add(this.statusStrip1);
            this.tpPedidos.Location = new System.Drawing.Point(4, 24);
            this.tpPedidos.Name = "tpPedidos";
            this.tpPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tpPedidos.Size = new System.Drawing.Size(658, 517);
            this.tpPedidos.TabIndex = 0;
            this.tpPedidos.Text = "Pedidos";
            this.tpPedidos.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(8, 289);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.richTextBox2.Size = new System.Drawing.Size(352, 117);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // gbPedidosConfirmados
            // 
            this.gbPedidosConfirmados.Location = new System.Drawing.Point(8, 138);
            this.gbPedidosConfirmados.Name = "gbPedidosConfirmados";
            this.gbPedidosConfirmados.Size = new System.Drawing.Size(642, 135);
            this.gbPedidosConfirmados.TabIndex = 1;
            this.gbPedidosConfirmados.TabStop = false;
            this.gbPedidosConfirmados.Text = "[ Pedidos confirmados ]";
            // 
            // gbPendentesAgendados
            // 
            this.gbPendentesAgendados.Controls.Add(this.dgvPedidosAgendados);
            this.gbPendentesAgendados.Location = new System.Drawing.Point(8, 3);
            this.gbPendentesAgendados.Name = "gbPendentesAgendados";
            this.gbPendentesAgendados.Size = new System.Drawing.Size(642, 129);
            this.gbPendentesAgendados.TabIndex = 1;
            this.gbPendentesAgendados.TabStop = false;
            this.gbPendentesAgendados.Text = "[ Pendentes / Agendados ]";
            // 
            // dgvPedidosAgendados
            // 
            this.dgvPedidosAgendados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosAgendados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPedidosAgendados.Location = new System.Drawing.Point(3, 19);
            this.dgvPedidosAgendados.Name = "dgvPedidosAgendados";
            this.dgvPedidosAgendados.Size = new System.Drawing.Size(636, 107);
            this.dgvPedidosAgendados.TabIndex = 0;
            this.dgvPedidosAgendados.Text = "dataGridView1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(3, 492);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1346, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tpConfiguracoes
            // 
            this.tpConfiguracoes.Controls.Add(this.gbDadosConexaoAPI);
            this.tpConfiguracoes.Controls.Add(this.gbTeste);
            this.tpConfiguracoes.Controls.Add(this.richTextBox1);
            this.tpConfiguracoes.Location = new System.Drawing.Point(4, 24);
            this.tpConfiguracoes.Name = "tpConfiguracoes";
            this.tpConfiguracoes.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfiguracoes.Size = new System.Drawing.Size(658, 517);
            this.tpConfiguracoes.TabIndex = 1;
            this.tpConfiguracoes.Text = "Configurações";
            this.tpConfiguracoes.UseVisualStyleBackColor = true;
            // 
            // gbDadosConexaoAPI
            // 
            this.gbDadosConexaoAPI.Controls.Add(this.tbSenha);
            this.gbDadosConexaoAPI.Controls.Add(this.lblSenha);
            this.gbDadosConexaoAPI.Controls.Add(this.tbUsuario);
            this.gbDadosConexaoAPI.Controls.Add(this.lblUsuario);
            this.gbDadosConexaoAPI.Controls.Add(this.tbClienteSecret);
            this.gbDadosConexaoAPI.Controls.Add(this.lblClienteSecret);
            this.gbDadosConexaoAPI.Controls.Add(this.tbClienteId);
            this.gbDadosConexaoAPI.Controls.Add(this.lblClienteId);
            this.gbDadosConexaoAPI.Location = new System.Drawing.Point(8, 12);
            this.gbDadosConexaoAPI.Name = "gbDadosConexaoAPI";
            this.gbDadosConexaoAPI.Size = new System.Drawing.Size(244, 214);
            this.gbDadosConexaoAPI.TabIndex = 3;
            this.gbDadosConexaoAPI.TabStop = false;
            this.gbDadosConexaoAPI.Text = "[ Dados de conexão - API ]";
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(11, 179);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(215, 23);
            this.tbSenha.TabIndex = 7;
            this.tbSenha.Text = "POS-302578002";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSenha.Location = new System.Drawing.Point(14, 161);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(44, 15);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "Senha:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(11, 135);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(215, 23);
            this.tbUsuario.TabIndex = 5;
            this.tbUsuario.Text = "POS-302578002";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(14, 117);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(52, 15);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuário:";
            // 
            // tbClienteSecret
            // 
            this.tbClienteSecret.Location = new System.Drawing.Point(11, 91);
            this.tbClienteSecret.Name = "tbClienteSecret";
            this.tbClienteSecret.Size = new System.Drawing.Size(215, 23);
            this.tbClienteSecret.TabIndex = 3;
            this.tbClienteSecret.Text = "p0Pw*#MFnk";
            // 
            // lblClienteSecret
            // 
            this.lblClienteSecret.AutoSize = true;
            this.lblClienteSecret.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClienteSecret.Location = new System.Drawing.Point(14, 73);
            this.lblClienteSecret.Name = "lblClienteSecret";
            this.lblClienteSecret.Size = new System.Drawing.Size(87, 15);
            this.lblClienteSecret.TabIndex = 2;
            this.lblClienteSecret.Text = "Cliente secret:";
            // 
            // tbClienteId
            // 
            this.tbClienteId.Location = new System.Drawing.Point(11, 47);
            this.tbClienteId.Name = "tbClienteId";
            this.tbClienteId.Size = new System.Drawing.Size(215, 23);
            this.tbClienteId.TabIndex = 1;
            this.tbClienteId.Text = "controlp";
            // 
            // lblClienteId
            // 
            this.lblClienteId.AutoSize = true;
            this.lblClienteId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClienteId.Location = new System.Drawing.Point(14, 29);
            this.lblClienteId.Name = "lblClienteId";
            this.lblClienteId.Size = new System.Drawing.Size(63, 15);
            this.lblClienteId.TabIndex = 0;
            this.lblClienteId.Text = "Cliente Id:";
            // 
            // gbTeste
            // 
            this.gbTeste.Controls.Add(this.button3);
            this.gbTeste.Controls.Add(this.button1);
            this.gbTeste.Controls.Add(this.button2);
            this.gbTeste.Controls.Add(this.button4);
            this.gbTeste.Location = new System.Drawing.Point(258, 12);
            this.gbTeste.Name = "gbTeste";
            this.gbTeste.Size = new System.Drawing.Size(392, 214);
            this.gbTeste.TabIndex = 2;
            this.gbTeste.TabStop = false;
            this.gbTeste.Text = "[ Testar API delivery ]";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Polling";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Status";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Acknowledgment";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(211, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Limpar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Location = new System.Drawing.Point(3, 232);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(652, 282);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // FrmPainelDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 545);
            this.Controls.Add(this.tcPainelDelivery);
            this.Name = "FrmPainelDelivery";
            this.Text = "Delivery";
            this.Load += new System.EventHandler(this.FrmPainelDelivery_Load);
            this.tcPainelDelivery.ResumeLayout(false);
            this.tpPedidos.ResumeLayout(false);
            this.tpPedidos.PerformLayout();
            this.gbPendentesAgendados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosAgendados)).EndInit();
            this.tpConfiguracoes.ResumeLayout(false);
            this.gbDadosConexaoAPI.ResumeLayout(false);
            this.gbDadosConexaoAPI.PerformLayout();
            this.gbTeste.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPainelDelivery;
        private System.Windows.Forms.TabPage tpPedidos;
        private System.Windows.Forms.TabPage tpConfiguracoes;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox gbPedidosConfirmados;
        private System.Windows.Forms.GroupBox gbPendentesAgendados;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.DataGridView dgvPedidosAgendados;
        private System.Windows.Forms.GroupBox gbTeste;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox gbDadosConexaoAPI;
        private System.Windows.Forms.TextBox tbClienteId;
        private System.Windows.Forms.Label lblClienteId;
        private System.Windows.Forms.TextBox tbClienteSecret;
        private System.Windows.Forms.Label lblClienteSecret;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lblUsuario;
    }
}

