namespace CapaVista
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lbDes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbGenre.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(168, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nuevo Cliente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaVista.Properties.Resources.person_add_icon_icons_com_50077;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(125, 462);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 34);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbJuridico);
            this.groupBox1.Controls.Add(this.rbExtranjero);
            this.groupBox1.Controls.Add(this.rbNacional);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 40);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            // 
            // rbJuridico
            // 
            this.rbJuridico.AutoSize = true;
            this.rbJuridico.Location = new System.Drawing.Point(231, 13);
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
            this.rbExtranjero.Location = new System.Drawing.Point(115, 13);
            this.rbExtranjero.Name = "rbExtranjero";
            this.rbExtranjero.Size = new System.Drawing.Size(80, 19);
            this.rbExtranjero.TabIndex = 1;
            this.rbExtranjero.TabStop = true;
            this.rbExtranjero.Text = "Extranjero";
            this.rbExtranjero.UseVisualStyleBackColor = true;
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
            this.rbNacional.Click += new System.EventHandler(this.rbNacional_CheckedChanged);
            // 
            // lbExtran
            // 
            this.lbExtran.AutoSize = true;
            this.lbExtran.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExtran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbExtran.Location = new System.Drawing.Point(186, 363);
            this.lbExtran.Name = "lbExtran";
            this.lbExtran.Size = new System.Drawing.Size(71, 15);
            this.lbExtran.TabIndex = 90;
            this.lbExtran.Text = "*Opcional*";
            this.lbExtran.Visible = false;
            // 
            // gbGenre
            // 
            this.gbGenre.Controls.Add(this.rbMale);
            this.gbGenre.Controls.Add(this.rbFemale);
            this.gbGenre.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGenre.Location = new System.Drawing.Point(189, 386);
            this.gbGenre.Name = "gbGenre";
            this.gbGenre.Size = new System.Drawing.Size(138, 68);
            this.gbGenre.TabIndex = 89;
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
            this.lbId.Location = new System.Drawing.Point(36, 181);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(104, 19);
            this.lbId.TabIndex = 88;
            this.lbId.Text = "Identificación:";
            this.lbId.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(189, 182);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(138, 20);
            this.txtId.TabIndex = 87;
            this.txtId.Visible = false;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtApe2
            // 
            this.txtApe2.Location = new System.Drawing.Point(189, 340);
            this.txtApe2.Name = "txtApe2";
            this.txtApe2.Size = new System.Drawing.Size(138, 20);
            this.txtApe2.TabIndex = 86;
            this.txtApe2.Visible = false;
            // 
            // txtApe1
            // 
            this.txtApe1.Location = new System.Drawing.Point(189, 285);
            this.txtApe1.Name = "txtApe1";
            this.txtApe1.Size = new System.Drawing.Size(138, 20);
            this.txtApe1.TabIndex = 85;
            this.txtApe1.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(189, 230);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 20);
            this.txtName.TabIndex = 84;
            this.txtName.Visible = false;
            // 
            // lbGen
            // 
            this.lbGen.AutoSize = true;
            this.lbGen.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGen.Location = new System.Drawing.Point(36, 398);
            this.lbGen.Name = "lbGen";
            this.lbGen.Size = new System.Drawing.Size(62, 19);
            this.lbGen.TabIndex = 83;
            this.lbGen.Text = "Genero:";
            this.lbGen.Visible = false;
            // 
            // lbApe1
            // 
            this.lbApe1.AutoSize = true;
            this.lbApe1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApe1.Location = new System.Drawing.Point(36, 282);
            this.lbApe1.Name = "lbApe1";
            this.lbApe1.Size = new System.Drawing.Size(116, 19);
            this.lbApe1.TabIndex = 82;
            this.lbApe1.Text = "Primer Apellido:";
            this.lbApe1.Visible = false;
            // 
            // lbApe2
            // 
            this.lbApe2.AutoSize = true;
            this.lbApe2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApe2.Location = new System.Drawing.Point(36, 339);
            this.lbApe2.Name = "lbApe2";
            this.lbApe2.Size = new System.Drawing.Size(128, 19);
            this.lbApe2.TabIndex = 81;
            this.lbApe2.Text = "Segundo Apelido:";
            this.lbApe2.Visible = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(36, 229);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(68, 19);
            this.lbName.TabIndex = 80;
            this.lbName.Text = "Nombre:";
            this.lbName.Visible = false;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(189, 137);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(138, 20);
            this.txtDesc.TabIndex = 79;
            this.txtDesc.Visible = false;
            // 
            // lbDes
            // 
            this.lbDes.AutoSize = true;
            this.lbDes.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDes.Location = new System.Drawing.Point(36, 138);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(91, 19);
            this.lbDes.TabIndex = 78;
            this.lbDes.Text = "Descripción:";
            this.lbDes.Visible = false;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 508);
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
            this.Controls.Add(this.lbDes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbGenre.ResumeLayout(false);
            this.gbGenre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lbDes;
    }
}