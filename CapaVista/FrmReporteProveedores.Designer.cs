namespace CapaVista
{
    partial class FrmReporteProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteProveedores));
            this.gbPerson = new System.Windows.Forms.GroupBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbJuridico = new System.Windows.Forms.RadioButton();
            this.rbExtranjero = new System.Windows.Forms.RadioButton();
            this.rbNacionales = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPerson
            // 
            this.gbPerson.Controls.Add(this.rbTodos);
            this.gbPerson.Controls.Add(this.rbJuridico);
            this.gbPerson.Controls.Add(this.rbExtranjero);
            this.gbPerson.Controls.Add(this.rbNacionales);
            this.gbPerson.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPerson.Location = new System.Drawing.Point(99, 122);
            this.gbPerson.Name = "gbPerson";
            this.gbPerson.Size = new System.Drawing.Size(373, 40);
            this.gbPerson.TabIndex = 65;
            this.gbPerson.TabStop = false;
            this.gbPerson.Enter += new System.EventHandler(this.gbPerson_Enter);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(6, 17);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(57, 19);
            this.rbTodos.TabIndex = 3;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            this.rbTodos.Click += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // rbJuridico
            // 
            this.rbJuridico.AutoSize = true;
            this.rbJuridico.Location = new System.Drawing.Point(295, 15);
            this.rbJuridico.Name = "rbJuridico";
            this.rbJuridico.Size = new System.Drawing.Size(72, 19);
            this.rbJuridico.TabIndex = 2;
            this.rbJuridico.TabStop = true;
            this.rbJuridico.Text = "Jurídicos";
            this.rbJuridico.UseVisualStyleBackColor = true;
            this.rbJuridico.CheckedChanged += new System.EventHandler(this.rbJuridico_CheckedChanged);
            this.rbJuridico.Click += new System.EventHandler(this.rbJuridico_CheckedChanged);
            // 
            // rbExtranjero
            // 
            this.rbExtranjero.AutoSize = true;
            this.rbExtranjero.Location = new System.Drawing.Point(183, 15);
            this.rbExtranjero.Name = "rbExtranjero";
            this.rbExtranjero.Size = new System.Drawing.Size(85, 19);
            this.rbExtranjero.TabIndex = 1;
            this.rbExtranjero.TabStop = true;
            this.rbExtranjero.Text = "Extranjeros";
            this.rbExtranjero.UseVisualStyleBackColor = true;
            this.rbExtranjero.CheckedChanged += new System.EventHandler(this.rbExtranjero_CheckedChanged);
            this.rbExtranjero.Click += new System.EventHandler(this.rbExtranjero_CheckedChanged);
            // 
            // rbNacionales
            // 
            this.rbNacionales.AutoSize = true;
            this.rbNacionales.Location = new System.Drawing.Point(85, 15);
            this.rbNacionales.Name = "rbNacionales";
            this.rbNacionales.Size = new System.Drawing.Size(83, 19);
            this.rbNacionales.TabIndex = 0;
            this.rbNacionales.TabStop = true;
            this.rbNacionales.Text = "Nacionales";
            this.rbNacionales.UseVisualStyleBackColor = true;
            this.rbNacionales.CheckedChanged += new System.EventHandler(this.rbNacionales_CheckedChanged);
            this.rbNacionales.Click += new System.EventHandler(this.rbNacionales_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(264, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 33);
            this.label6.TabIndex = 64;
            this.label6.Text = "Proveedores";
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.AllowUserToAddRows = false;
            this.dgvProveedor.AllowUserToDeleteRows = false;
            this.dgvProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvProveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Location = new System.Drawing.Point(82, 182);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.ReadOnly = true;
            this.dgvProveedor.ShowEditingIcon = false;
            this.dgvProveedor.Size = new System.Drawing.Size(429, 213);
            this.dgvProveedor.TabIndex = 62;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaVista.Properties.Resources.phone_call_icon_icons_com_63771;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(159, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // FrmReporteProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 460);
            this.Controls.Add(this.gbPerson);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvProveedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte Proveedores";
            this.Load += new System.EventHandler(this.FrmReporteProveedores_Load);
            this.gbPerson.ResumeLayout(false);
            this.gbPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPerson;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbJuridico;
        private System.Windows.Forms.RadioButton rbExtranjero;
        private System.Windows.Forms.RadioButton rbNacionales;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvProveedor;
    }
}