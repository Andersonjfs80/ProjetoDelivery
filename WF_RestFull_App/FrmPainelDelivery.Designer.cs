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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.tcPainelDelivery = new System.Windows.Forms.TabControl();
            this.tpPedidos = new System.Windows.Forms.TabPage();
            this.gbGrade = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPolling = new System.Windows.Forms.Button();
            this.btnAcknowledgment = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tpConfiguracoes = new System.Windows.Forms.TabPage();
            this.tcPainelDelivery.SuspendLayout();
            this.tpPedidos.SuspendLayout();
            this.gbGrade.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
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
            this.tcPainelDelivery.Size = new System.Drawing.Size(511, 359);
            this.tcPainelDelivery.TabIndex = 0;
            // 
            // tpPedidos
            // 
            this.tpPedidos.Controls.Add(this.gbGrade);
            this.tpPedidos.Controls.Add(this.pnlBotoes);
            this.tpPedidos.Controls.Add(this.richTextBox2);
            this.tpPedidos.Controls.Add(this.statusStrip1);
            this.tpPedidos.Location = new System.Drawing.Point(4, 24);
            this.tpPedidos.Name = "tpPedidos";
            this.tpPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tpPedidos.Size = new System.Drawing.Size(503, 331);
            this.tpPedidos.TabIndex = 0;
            this.tpPedidos.Text = "Pedidos";
            this.tpPedidos.UseVisualStyleBackColor = true;
            // 
            // gbGrade
            // 
            this.gbGrade.Controls.Add(this.listView1);
            this.gbGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGrade.Location = new System.Drawing.Point(3, 105);
            this.gbGrade.Name = "gbGrade";
            this.gbGrade.Size = new System.Drawing.Size(497, 149);
            this.gbGrade.TabIndex = 6;
            this.gbGrade.TabStop = false;
            this.gbGrade.Text = "Delivery";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup2";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(491, 127);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnLimpar);
            this.pnlBotoes.Controls.Add(this.btnPolling);
            this.pnlBotoes.Controls.Add(this.btnAcknowledgment);
            this.pnlBotoes.Controls.Add(this.btnStatus);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(3, 3);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(497, 102);
            this.pnlBotoes.TabIndex = 5;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(407, 9);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPolling
            // 
            this.btnPolling.Location = new System.Drawing.Point(14, 9);
            this.btnPolling.Name = "btnPolling";
            this.btnPolling.Size = new System.Drawing.Size(75, 23);
            this.btnPolling.TabIndex = 2;
            this.btnPolling.Text = "Polling";
            this.btnPolling.UseVisualStyleBackColor = true;
            this.btnPolling.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAcknowledgment
            // 
            this.btnAcknowledgment.Location = new System.Drawing.Point(14, 38);
            this.btnAcknowledgment.Name = "btnAcknowledgment";
            this.btnAcknowledgment.Size = new System.Drawing.Size(75, 23);
            this.btnAcknowledgment.TabIndex = 2;
            this.btnAcknowledgment.Text = "Acknowledgment";
            this.btnAcknowledgment.UseVisualStyleBackColor = true;
            this.btnAcknowledgment.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(14, 67);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(75, 23);
            this.btnStatus.TabIndex = 3;
            this.btnStatus.Text = "Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox2.Location = new System.Drawing.Point(3, 254);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(497, 52);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(3, 306);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(497, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tpConfiguracoes
            // 
            this.tpConfiguracoes.Location = new System.Drawing.Point(4, 24);
            this.tpConfiguracoes.Name = "tpConfiguracoes";
            this.tpConfiguracoes.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfiguracoes.Size = new System.Drawing.Size(503, 331);
            this.tpConfiguracoes.TabIndex = 1;
            this.tpConfiguracoes.Text = "Configurações";
            this.tpConfiguracoes.UseVisualStyleBackColor = true;
            // 
            // FrmPainelDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 359);
            this.Controls.Add(this.tcPainelDelivery);
            this.Name = "FrmPainelDelivery";
            this.Text = "Delivery";
            this.Load += new System.EventHandler(this.FrmPainelDelivery_Load);
            this.tcPainelDelivery.ResumeLayout(false);
            this.tpPedidos.ResumeLayout(false);
            this.tpPedidos.PerformLayout();
            this.gbGrade.ResumeLayout(false);
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPainelDelivery;
        private System.Windows.Forms.TabPage tpPedidos;
        private System.Windows.Forms.TabPage tpConfiguracoes;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button btnPolling;
        private System.Windows.Forms.Button btnAcknowledgment;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.GroupBox gbGrade;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

