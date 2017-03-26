namespace CapaVista
{
    partial class FrmCourrier
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCourrier));
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddCou = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cboJuridico = new System.Windows.Forms.ComboBox();
            this.juridicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoBDDataSet = new CapaVista.ProyectoBDDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.juridicaTableAdapter = new CapaVista.ProyectoBDDataSetTableAdapters.JuridicaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.juridicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(127, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 26);
            this.label8.TabIndex = 39;
            this.label8.Text = "Agregar Courrier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Júridico:";
            // 
            // btnAddCou
            // 
            this.btnAddCou.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCou.Location = new System.Drawing.Point(99, 201);
            this.btnAddCou.Name = "btnAddCou";
            this.btnAddCou.Size = new System.Drawing.Size(110, 34);
            this.btnAddCou.TabIndex = 33;
            this.btnAddCou.Text = "Agregar";
            this.btnAddCou.UseVisualStyleBackColor = true;
            this.btnAddCou.Click += new System.EventHandler(this.btnAddCou_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaVista.Properties.Resources.message;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // cboJuridico
            // 
            this.cboJuridico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJuridico.FormattingEnabled = true;
            this.cboJuridico.Location = new System.Drawing.Point(132, 105);
            this.cboJuridico.Name = "cboJuridico";
            this.cboJuridico.Size = new System.Drawing.Size(149, 21);
            this.cboJuridico.TabIndex = 40;
            this.cboJuridico.SelectedIndexChanged += new System.EventHandler(this.cboJuridico_SelectedIndexChanged);
            this.cboJuridico.DropDownStyleChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cboJuridico.Click += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // juridicaBindingSource
            // 
            this.juridicaBindingSource.DataMember = "Juridica";
            this.juridicaBindingSource.DataSource = this.proyectoBDDataSet;
            // 
            // proyectoBDDataSet
            // 
            this.proyectoBDDataSet.DataSetName = "ProyectoBDDataSet";
            this.proyectoBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nombre:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 153);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 20);
            this.txtName.TabIndex = 42;
            // 
            // juridicaTableAdapter
            // 
            this.juridicaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCourrier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 247);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboJuridico);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddCou);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCourrier";
            this.Text = "Courrier";
            this.Load += new System.EventHandler(this.FrmCourrier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juridicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddCou;
        private System.Windows.Forms.ComboBox cboJuridico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private ProyectoBDDataSet proyectoBDDataSet;
        private System.Windows.Forms.BindingSource juridicaBindingSource;
        private ProyectoBDDataSetTableAdapters.JuridicaTableAdapter juridicaTableAdapter;
    }
}