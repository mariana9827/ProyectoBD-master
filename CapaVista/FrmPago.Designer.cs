namespace CapaVista
{
    partial class FrmPago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPago));
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbCredito = new System.Windows.Forms.RadioButton();
            this.rbContado = new System.Windows.Forms.RadioButton();
            this.lbfact = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lbmonto = new System.Windows.Forms.Label();
            this.lbFpago = new System.Windows.Forms.Label();
            this.lbsaldo = new System.Windows.Forms.Label();
            this.dtPago = new System.Windows.Forms.DateTimePicker();
            this.cboFactura = new System.Windows.Forms.ComboBox();
            this.dtLimite = new System.Windows.Forms.DateTimePicker();
            this.lbFlim = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(170, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 26);
            this.label6.TabIndex = 107;
            this.label6.Text = "Pago";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaVista.Properties.Resources.carduse_card_payment_51221;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 106;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbCredito);
            this.groupBox3.Controls.Add(this.rbContado);
            this.groupBox3.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(68, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 40);
            this.groupBox3.TabIndex = 108;
            this.groupBox3.TabStop = false;
            // 
            // rbCredito
            // 
            this.rbCredito.AutoSize = true;
            this.rbCredito.Location = new System.Drawing.Point(118, 15);
            this.rbCredito.Name = "rbCredito";
            this.rbCredito.Size = new System.Drawing.Size(65, 19);
            this.rbCredito.TabIndex = 1;
            this.rbCredito.TabStop = true;
            this.rbCredito.Text = "Crédito";
            this.rbCredito.UseVisualStyleBackColor = true;
            this.rbCredito.CheckedChanged += new System.EventHandler(this.rbCredito_CheckedChanged);
            this.rbCredito.Click += new System.EventHandler(this.rbCredito_CheckedChanged);
            // 
            // rbContado
            // 
            this.rbContado.AutoSize = true;
            this.rbContado.Location = new System.Drawing.Point(23, 15);
            this.rbContado.Name = "rbContado";
            this.rbContado.Size = new System.Drawing.Size(72, 19);
            this.rbContado.TabIndex = 0;
            this.rbContado.TabStop = true;
            this.rbContado.Text = "Contado";
            this.rbContado.UseVisualStyleBackColor = true;
            this.rbContado.CheckedChanged += new System.EventHandler(this.rbContado_CheckedChanged);
            this.rbContado.Click += new System.EventHandler(this.rbContado_CheckedChanged);
            // 
            // lbfact
            // 
            this.lbfact.AutoSize = true;
            this.lbfact.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfact.Location = new System.Drawing.Point(44, 199);
            this.lbfact.Name = "lbfact";
            this.lbfact.Size = new System.Drawing.Size(81, 19);
            this.lbfact.TabIndex = 118;
            this.lbfact.Text = "ID Factura:";
            this.lbfact.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(131, 472);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 39);
            this.btnAdd.TabIndex = 114;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(186, 302);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(139, 20);
            this.txtSaldo.TabIndex = 113;
            this.txtSaldo.Visible = false;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(186, 244);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(139, 20);
            this.txtMonto.TabIndex = 112;
            this.txtMonto.Visible = false;
            // 
            // lbmonto
            // 
            this.lbmonto.AutoSize = true;
            this.lbmonto.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmonto.Location = new System.Drawing.Point(44, 243);
            this.lbmonto.Name = "lbmonto";
            this.lbmonto.Size = new System.Drawing.Size(58, 19);
            this.lbmonto.TabIndex = 111;
            this.lbmonto.Text = "Monto:";
            this.lbmonto.Visible = false;
            // 
            // lbFpago
            // 
            this.lbFpago.AutoSize = true;
            this.lbFpago.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFpago.Location = new System.Drawing.Point(44, 354);
            this.lbFpago.Name = "lbFpago";
            this.lbFpago.Size = new System.Drawing.Size(91, 19);
            this.lbFpago.TabIndex = 110;
            this.lbFpago.Text = "Fecha Pago:";
            this.lbFpago.Visible = false;
            // 
            // lbsaldo
            // 
            this.lbsaldo.AutoSize = true;
            this.lbsaldo.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsaldo.Location = new System.Drawing.Point(44, 303);
            this.lbsaldo.Name = "lbsaldo";
            this.lbsaldo.Size = new System.Drawing.Size(105, 19);
            this.lbsaldo.TabIndex = 109;
            this.lbsaldo.Text = "Saldo a Pagar:";
            this.lbsaldo.Visible = false;
            // 
            // dtPago
            // 
            this.dtPago.CustomFormat = "dd/MM/yyy";
            this.dtPago.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPago.Location = new System.Drawing.Point(186, 354);
            this.dtPago.Name = "dtPago";
            this.dtPago.Size = new System.Drawing.Size(139, 20);
            this.dtPago.TabIndex = 120;
            this.dtPago.Value = new System.DateTime(2017, 4, 3, 0, 0, 0, 0);
            this.dtPago.Visible = false;
            // 
            // cboFactura
            // 
            this.cboFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFactura.FormattingEnabled = true;
            this.cboFactura.Location = new System.Drawing.Point(186, 197);
            this.cboFactura.Name = "cboFactura";
            this.cboFactura.Size = new System.Drawing.Size(139, 21);
            this.cboFactura.TabIndex = 121;
            this.cboFactura.Visible = false;
            this.cboFactura.Click += new System.EventHandler(this.cboFactura_SelectedIndexChanged_1);
            // 
            // dtLimite
            // 
            this.dtLimite.CustomFormat = "dd/MM/yyy";
            this.dtLimite.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLimite.Location = new System.Drawing.Point(186, 412);
            this.dtLimite.Name = "dtLimite";
            this.dtLimite.Size = new System.Drawing.Size(139, 20);
            this.dtLimite.TabIndex = 123;
            this.dtLimite.Value = new System.DateTime(2017, 4, 3, 0, 0, 0, 0);
            this.dtLimite.Visible = false;
            // 
            // lbFlim
            // 
            this.lbFlim.AutoSize = true;
            this.lbFlim.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFlim.Location = new System.Drawing.Point(44, 412);
            this.lbFlim.Name = "lbFlim";
            this.lbFlim.Size = new System.Drawing.Size(99, 19);
            this.lbFlim.TabIndex = 122;
            this.lbFlim.Text = "Fecha Límite:";
            this.lbFlim.Visible = false;
            // 
            // FrmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 537);
            this.Controls.Add(this.dtLimite);
            this.Controls.Add(this.lbFlim);
            this.Controls.Add(this.cboFactura);
            this.Controls.Add(this.dtPago);
            this.Controls.Add(this.lbfact);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lbmonto);
            this.Controls.Add(this.lbFpago);
            this.Controls.Add(this.lbsaldo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPago";
            this.Text = "Pago";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbCredito;
        private System.Windows.Forms.RadioButton rbContado;
        private System.Windows.Forms.Label lbfact;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lbmonto;
        private System.Windows.Forms.Label lbFpago;
        private System.Windows.Forms.Label lbsaldo;
        private System.Windows.Forms.DateTimePicker dtPago;
        private System.Windows.Forms.ComboBox cboFactura;
        private System.Windows.Forms.DateTimePicker dtLimite;
        private System.Windows.Forms.Label lbFlim;
    }
}