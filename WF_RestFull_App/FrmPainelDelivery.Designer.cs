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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tcPainelDelivery.SuspendLayout();
            this.tpPedidos.SuspendLayout();
            this.gbPendentesAgendados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosAgendados)).BeginInit();
            this.tpConfiguracoes.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tcPainelDelivery.Size = new System.Drawing.Size(844, 382);
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
            this.tpPedidos.Size = new System.Drawing.Size(836, 354);
            this.tpPedidos.TabIndex = 0;
            this.tpPedidos.Text = "Pedidos";
            this.tpPedidos.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(460, 15);
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
            this.gbPedidosConfirmados.Size = new System.Drawing.Size(446, 135);
            this.gbPedidosConfirmados.TabIndex = 1;
            this.gbPedidosConfirmados.TabStop = false;
            this.gbPedidosConfirmados.Text = "[ Pedidos confirmados ]";
            // 
            // gbPendentesAgendados
            // 
            this.gbPendentesAgendados.Controls.Add(this.dgvPedidosAgendados);
            this.gbPendentesAgendados.Location = new System.Drawing.Point(8, 3);
            this.gbPendentesAgendados.Name = "gbPendentesAgendados";
            this.gbPendentesAgendados.Size = new System.Drawing.Size(446, 129);
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
            this.dgvPedidosAgendados.Size = new System.Drawing.Size(440, 107);
            this.dgvPedidosAgendados.TabIndex = 0;
            this.dgvPedidosAgendados.Text = "dataGridView1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(3, 329);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(830, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tpConfiguracoes
            // 
            this.tpConfiguracoes.Controls.Add(this.richTextBox1);
            this.tpConfiguracoes.Controls.Add(this.panel1);
            this.tpConfiguracoes.Location = new System.Drawing.Point(4, 24);
            this.tpConfiguracoes.Name = "tpConfiguracoes";
            this.tpConfiguracoes.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfiguracoes.Size = new System.Drawing.Size(836, 354);
            this.tpConfiguracoes.TabIndex = 1;
            this.tpConfiguracoes.Text = "Configurações";
            this.tpConfiguracoes.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Location = new System.Drawing.Point(3, 145);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(830, 206);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(8, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 98);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(735, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Limpar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Polling";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Status";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Acknowledgment";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmPainelDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 382);
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
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPainelDelivery;
        private System.Windows.Forms.TabPage tpPedidos;
        private System.Windows.Forms.TabPage tpConfiguracoes;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbPedidosConfirmados;
        private System.Windows.Forms.GroupBox gbPendentesAgendados;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.DataGridView dgvPedidosAgendados;
    }
}

