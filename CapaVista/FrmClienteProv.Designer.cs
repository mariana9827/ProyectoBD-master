namespace CapaVista
{
    partial class FrmClienteProv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClienteProv));
            this.lbId = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnAddCou = new System.Windows.Forms.Button();
            this.lbDes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(45, 125);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(104, 19);
            this.lbId.TabIndex = 84;
            this.lbId.Text = "Identificación:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(198, 178);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 20);
            this.txtName.TabIndex = 80;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(45, 177);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(68, 19);
            this.lbName.TabIndex = 76;
            this.lbName.Text = "Nombre:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(198, 225);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(138, 20);
            this.txtDesc.TabIndex = 74;
            // 
            // btnAddCou
            // 
            this.btnAddCou.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCou.Location = new System.Drawing.Point(124, 278);
            this.btnAddCou.Name = "btnAddCou";
            this.btnAddCou.Size = new System.Drawing.Size(110, 34);
            this.btnAddCou.TabIndex = 73;
            this.btnAddCou.Text = "Agregar";
            this.btnAddCou.UseVisualStyleBackColor = true;
            this.btnAddCou.Click += new System.EventHandler(this.btnAddCou_Click);
            // 
            // lbDes
            // 
            this.lbDes.AutoSize = true;
            this.lbDes.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDes.Location = new System.Drawing.Point(45, 226);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(91, 19);
            this.lbDes.TabIndex = 72;
            this.lbDes.Text = "Descripción:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(153, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 26);
            this.label6.TabIndex = 71;
            this.label6.Text = "Nuevo Proveedor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaVista.Properties.Resources.phone_call_icon_icons_com_63771;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // cboID
            // 
            this.cboID.FormattingEnabled = true;
            this.cboID.Location = new System.Drawing.Point(198, 125);
            this.cboID.Name = "cboID";
            this.cboID.Size = new System.Drawing.Size(138, 21);
            this.cboID.TabIndex = 85;
            this.cboID.Click += new System.EventHandler(this.cboID_SelectedIndexChanged);
            // 
            // FrmClienteProv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 333);
            this.Controls.Add(this.cboID);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnAddCou);
            this.Controls.Add(this.lbDes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClienteProv";
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.FrmClienteProv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnAddCou;
        private System.Windows.Forms.Label lbDes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboID;
    }
}