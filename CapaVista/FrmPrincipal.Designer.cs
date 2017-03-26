namespace CapaVista
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.btnCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nacionalExtranjeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jurídicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReports = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasPorCobrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paqueteriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem8.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem8.Margin = new System.Windows.Forms.Padding(280, 40, 20, 40);
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Padding = new System.Windows.Forms.Padding(4);
            this.toolStripMenuItem8.Size = new System.Drawing.Size(205, 35);
            this.toolStripMenuItem8.Text = "Empresa de Paqueteria";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(59)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(713, 119);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "MenuStrip";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCliente,
            this.ventaToolStripMenuItem,
            this.btnReports});
            this.menuStrip.Location = new System.Drawing.Point(0, 119);
            this.menuStrip.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(156, 454);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "MenuStrip";
            // 
            // btnCliente
            // 
            this.btnCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.proveedorToolStripMenuItem});
            this.btnCliente.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(16)))));
            this.btnCliente.Image = global::CapaVista.Properties.Resources.plus_icon_icons_com_69985;
            this.btnCliente.Margin = new System.Windows.Forms.Padding(20, 100, 20, 40);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Padding = new System.Windows.Forms.Padding(4);
            this.btnCliente.Size = new System.Drawing.Size(99, 35);
            this.btnCliente.Text = "Agregar";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nacionalExtranjeroToolStripMenuItem,
            this.jurídicaToolStripMenuItem,
            this.currierToolStripMenuItem});
            this.agregarToolStripMenuItem.Image = global::CapaVista.Properties.Resources.person_add_icon_icons_com_50077;
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(160, 28);
            this.agregarToolStripMenuItem.Text = "Cliente";
            // 
            // nacionalExtranjeroToolStripMenuItem
            // 
            this.nacionalExtranjeroToolStripMenuItem.Image = global::CapaVista.Properties.Resources.ios7_world_outline_icon_icons_com_50126;
            this.nacionalExtranjeroToolStripMenuItem.Name = "nacionalExtranjeroToolStripMenuItem";
            this.nacionalExtranjeroToolStripMenuItem.Size = new System.Drawing.Size(233, 28);
            this.nacionalExtranjeroToolStripMenuItem.Text = "Nacional/Extranjero";
            this.nacionalExtranjeroToolStripMenuItem.Click += new System.EventHandler(this.nacionalExtranjeroToolStripMenuItem_Click_1);
            // 
            // jurídicaToolStripMenuItem
            // 
            this.jurídicaToolStripMenuItem.Image = global::CapaVista.Properties.Resources.man_with_company1;
            this.jurídicaToolStripMenuItem.Name = "jurídicaToolStripMenuItem";
            this.jurídicaToolStripMenuItem.Size = new System.Drawing.Size(233, 28);
            this.jurídicaToolStripMenuItem.Text = "Jurídico";
            this.jurídicaToolStripMenuItem.Click += new System.EventHandler(this.jurídicaToolStripMenuItem_Click);
            // 
            // currierToolStripMenuItem
            // 
            this.currierToolStripMenuItem.Image = global::CapaVista.Properties.Resources.message;
            this.currierToolStripMenuItem.Name = "currierToolStripMenuItem";
            this.currierToolStripMenuItem.Size = new System.Drawing.Size(233, 28);
            this.currierToolStripMenuItem.Text = "Courrier";
            this.currierToolStripMenuItem.Click += new System.EventHandler(this.currierToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Image = global::CapaVista.Properties.Resources.shopping_cart_add_button_icon_icons_com_56132;
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(160, 28);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.proveedorToolStripMenuItem.Image = global::CapaVista.Properties.Resources.phone_call_icon_icons_com_63771;
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(160, 28);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            this.proveedorToolStripMenuItem.Click += new System.EventHandler(this.proveedorToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(134, 28);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(134, 28);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventaToolStripMenuItem.Image = global::CapaVista.Properties.Resources.carduse_card_payment_5122;
            this.ventaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 40, 20, 40);
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(99, 27);
            this.ventaToolStripMenuItem.Text = "Venta";
            // 
            // btnReports
            // 
            this.btnReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.cuentasPorCobrarToolStripMenuItem,
            this.paqueteriaToolStripMenuItem,
            this.proveedoresToolStripMenuItem1,
            this.productosToolStripMenuItem});
            this.btnReports.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Image = global::CapaVista.Properties.Resources._27799;
            this.btnReports.Margin = new System.Windows.Forms.Padding(20, 40, 20, 100);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(4);
            this.btnReports.Size = new System.Drawing.Size(99, 35);
            this.btnReports.Text = "Reportes";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Image = global::CapaVista.Properties.Resources._7b5f65_12de7cffa2f7494a9abfc5547d98718a;
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(229, 28);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // cuentasPorCobrarToolStripMenuItem
            // 
            this.cuentasPorCobrarToolStripMenuItem.Image = global::CapaVista.Properties.Resources.coins_stacks_money_icon_icons_com_56191;
            this.cuentasPorCobrarToolStripMenuItem.Name = "cuentasPorCobrarToolStripMenuItem";
            this.cuentasPorCobrarToolStripMenuItem.Size = new System.Drawing.Size(229, 28);
            this.cuentasPorCobrarToolStripMenuItem.Text = "Cuentas por Cobrar";
            // 
            // paqueteriaToolStripMenuItem
            // 
            this.paqueteriaToolStripMenuItem.Image = global::CapaVista.Properties.Resources.drop_box_online_social_media_icon_icons_com_71865;
            this.paqueteriaToolStripMenuItem.Name = "paqueteriaToolStripMenuItem";
            this.paqueteriaToolStripMenuItem.Size = new System.Drawing.Size(229, 28);
            this.paqueteriaToolStripMenuItem.Text = "Paqueteria";
            // 
            // proveedoresToolStripMenuItem1
            // 
            this.proveedoresToolStripMenuItem1.Image = global::CapaVista.Properties.Resources.phone_call_icon_icons_com_63771;
            this.proveedoresToolStripMenuItem1.Name = "proveedoresToolStripMenuItem1";
            this.proveedoresToolStripMenuItem1.Size = new System.Drawing.Size(229, 28);
            this.proveedoresToolStripMenuItem1.Text = "Proveedores";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Image = global::CapaVista.Properties.Resources.cart12;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(229, 28);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(59)))));
            this.pictureBox1.Image = global::CapaVista.Properties.Resources.delivery_packages_on_a_trolley__3_;
            this.pictureBox1.Location = new System.Drawing.Point(169, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(713, 573);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paquetería ";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem btnCliente;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nacionalExtranjeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jurídicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnReports;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cuentasPorCobrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        internal System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem currierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paqueteriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
    }
}



