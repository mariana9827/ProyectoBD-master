namespace CapaVista
{
    partial class FrmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedores));
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbDes = new System.Windows.Forms.Label();
            this.btnAddCou = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.gbPerson = new System.Windows.Forms.GroupBox();
            this.rbJuridico = new System.Windows.Forms.RadioButton();
            this.rbExtranjero = new System.Windows.Forms.RadioButton();
            this.rbNacional = new System.Windows.Forms.RadioButton();
            this.lbExtran = new System.Windows.Forms.Label();
            this.gbGenre = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lbId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtApe2 = new System.Windows.Forms.TextBox();
            this.txtApe1 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbGen = new System.Windows.Forms.Label();
            this.lbApe1 = new System.Windows.Forms.Label();
            this.lbApe2 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.cboID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbPerson.SuspendLayout();
            this.gbGenre.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(141, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 26);
            this.label6.TabIndex = 19;
            this.label6.Text = "Nuevo Proveedor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaVista.Properties.Resources.phone_call_icon_icons_com_63771;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lbDes
            // 
            this.lbDes.AutoSize = true;
            this.lbDes.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDes.Location = new System.Drawing.Point(41, 194);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(91, 19);
            this.lbDes.TabIndex = 47;
            this.lbDes.Text = "Descripción:";
            this.lbDes.Visible = false;
            // 
            // btnAddCou
            // 
            this.btnAddCou.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCou.Location = new System.Drawing.Point(161, 478);
            this.btnAddCou.Name = "btnAddCou";
            this.btnAddCou.Size = new System.Drawing.Size(110, 34);
            this.btnAddCou.TabIndex = 50;
            this.btnAddCou.Text = "Agregar";
            this.btnAddCou.UseVisualStyleBackColor = true;
            this.btnAddCou.Visible = false;
            this.btnAddCou.Click += new System.EventHandler(this.btnAddCou_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(215, 195);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(138, 20);
            this.txtDesc.TabIndex = 53;
            this.txtDesc.Visible = false;
            // 
            // gbPerson
            // 
            this.gbPerson.Controls.Add(this.rbJuridico);
            this.gbPerson.Controls.Add(this.rbExtranjero);
            this.gbPerson.Controls.Add(this.rbNacional);
            this.gbPerson.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPerson.Location = new System.Drawing.Point(45, 79);
            this.gbPerson.Name = "gbPerson";
            this.gbPerson.Size = new System.Drawing.Size(308, 40);
            this.gbPerson.TabIndex = 56;
            this.gbPerson.TabStop = false;
            // 
            // rbJuridico
            // 
            this.rbJuridico.AutoSize = true;
            this.rbJuridico.Location = new System.Drawing.Point(225, 13);
            this.rbJuridico.Name = "rbJuridico";
            this.rbJuridico.Size = new System.Drawing.Size(67, 19);
            this.rbJuridico.TabIndex = 2;
            this.rbJuridico.TabStop = true;
            this.rbJuridico.Text = "Jurídico";
            this.rbJuridico.UseVisualStyleBackColor = true;
            this.rbJuridico.CheckedChanged += new System.EventHandler(this.rbJuridico_CheckedChanged);
            this.rbJuridico.Click += new System.EventHandler(this.rbJuridico_CheckedChanged);
            // 
            // rbExtranjero
            // 
            this.rbExtranjero.AutoSize = true;
            this.rbExtranjero.Location = new System.Drawing.Point(116, 13);
            this.rbExtranjero.Name = "rbExtranjero";
            this.rbExtranjero.Size = new System.Drawing.Size(80, 19);
            this.rbExtranjero.TabIndex = 1;
            this.rbExtranjero.TabStop = true;
            this.rbExtranjero.Text = "Extranjero";
            this.rbExtranjero.UseVisualStyleBackColor = true;
            this.rbExtranjero.CheckedChanged += new System.EventHandler(this.rbExtranjero_CheckedChanged);
            this.rbExtranjero.Click += new System.EventHandler(this.rbExtranjero_CheckedChanged);
            // 
            // rbNacional
            // 
            this.rbNacional.AutoSize = true;
            this.rbNacional.Location = new System.Drawing.Point(6, 13);
            this.rbNacional.Name = "rbNacional";
            this.rbNacional.Size = new System.Drawing.Size(72, 19);
            this.rbNacional.TabIndex = 0;
            this.rbNacional.TabStop = true;
            this.rbNacional.Text = "Nacional";
            this.rbNacional.UseVisualStyleBackColor = true;
            this.rbNacional.CheckedChanged += new System.EventHandler(this.rbNacional_CheckedChanged);
            this.rbNacional.Click += new System.EventHandler(this.rbNacional_CheckedChanged);
            // 
            // lbExtran
            // 
            this.lbExtran.AutoSize = true;
            this.lbExtran.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExtran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbExtran.Location = new System.Drawing.Point(356, 363);
            this.lbExtran.Name = "lbExtran";
            this.lbExtran.Size = new System.Drawing.Size(71, 15);
            this.lbExtran.TabIndex = 69;
            this.lbExtran.Text = "*Opcional*";
            this.lbExtran.Visible = false;
            // 
            // gbGenre
            // 
            this.gbGenre.Controls.Add(this.rbMale);
            this.gbGenre.Controls.Add(this.rbFemale);
            this.gbGenre.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGenre.Location = new System.Drawing.Point(215, 398);
            this.gbGenre.Name = "gbGenre";
            this.gbGenre.Size = new System.Drawing.Size(138, 68);
            this.gbGenre.TabIndex = 68;
            this.gbGenre.TabStop = false;
            this.gbGenre.Visible = false;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(7, 44);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(80, 19);
            this.rbMale.TabIndex = 1;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Masculino";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(7, 19);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(79, 19);
            this.rbFemale.TabIndex = 0;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Femenino";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(41, 146);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(104, 19);
            this.lbId.TabIndex = 66;
            this.lbId.Text = "Identificación:";
            this.lbId.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(215, 147);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(138, 20);
            this.txtId.TabIndex = 65;
            this.txtId.Visible = false;
            // 
            // txtApe2
            // 
            this.txtApe2.Location = new System.Drawing.Point(215, 358);
            this.txtApe2.Name = "txtApe2";
            this.txtApe2.Size = new System.Drawing.Size(138, 20);
            this.txtApe2.TabIndex = 64;
            this.txtApe2.Visible = false;
            // 
            // txtApe1
            // 
            this.txtApe1.Location = new System.Drawing.Point(215, 301);
            this.txtApe1.Name = "txtApe1";
            this.txtApe1.Size = new System.Drawing.Size(138, 20);
            this.txtApe1.TabIndex = 63;
            this.txtApe1.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(215, 246);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 20);
            this.txtName.TabIndex = 62;
            this.txtName.Visible = false;
            // 
            // lbGen
            // 
            this.lbGen.AutoSize = true;
            this.lbGen.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGen.Location = new System.Drawing.Point(41, 416);
            this.lbGen.Name = "lbGen";
            this.lbGen.Size = new System.Drawing.Size(62, 19);
            this.lbGen.TabIndex = 60;
            this.lbGen.Text = "Genero:";
            this.lbGen.Visible = false;
            // 
            // lbApe1
            // 
            this.lbApe1.AutoSize = true;
            this.lbApe1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApe1.Location = new System.Drawing.Point(41, 300);
            this.lbApe1.Name = "lbApe1";
            this.lbApe1.Size = new System.Drawing.Size(116, 19);
            this.lbApe1.TabIndex = 59;
            this.lbApe1.Text = "Primer Apellido:";
            this.lbApe1.Visible = false;
            // 
            // lbApe2
            // 
            this.lbApe2.AutoSize = true;
            this.lbApe2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApe2.Location = new System.Drawing.Point(41, 357);
            this.lbApe2.Name = "lbApe2";
            this.lbApe2.Size = new System.Drawing.Size(128, 19);
            this.lbApe2.TabIndex = 58;
            this.lbApe2.Text = "Segundo Apelido:";
            this.lbApe2.Visible = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(41, 247);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(68, 19);
            this.lbName.TabIndex = 57;
            this.lbName.Text = "Nombre:";
            this.lbName.Visible = false;
            // 
            // cboID
            // 
            this.cboID.FormattingEnabled = true;
            this.cboID.Location = new System.Drawing.Point(215, 147);
            this.cboID.Name = "cboID";
            this.cboID.Size = new System.Drawing.Size(138, 21);
            this.cboID.TabIndex = 70;
            this.cboID.Visible = false;
            // 
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 524);
            this.Controls.Add(this.cboID);
            this.Controls.Add(this.gbPerson);
            this.Controls.Add(this.lbExtran);
            this.Controls.Add(this.gbGenre);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtApe2);
            this.Controls.Add(this.txtApe1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbGen);
            this.Controls.Add(this.lbApe1);
            this.Controls.Add(this.lbApe2);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnAddCou);
            this.Controls.Add(this.lbDes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbPerson.ResumeLayout(false);
            this.gbPerson.PerformLayout();
            this.gbGenre.ResumeLayout(false);
            this.gbGenre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbDes;
        private System.Windows.Forms.Button btnAddCou;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.GroupBox gbPerson;
        private System.Windows.Forms.RadioButton rbJuridico;
        private System.Windows.Forms.RadioButton rbExtranjero;
        private System.Windows.Forms.RadioButton rbNacional;
        private System.Windows.Forms.Label lbExtran;
        private System.Windows.Forms.GroupBox gbGenre;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtApe2;
        private System.Windows.Forms.TextBox txtApe1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbGen;
        private System.Windows.Forms.Label lbApe1;
        private System.Windows.Forms.Label lbApe2;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ComboBox cboID;
    }
}