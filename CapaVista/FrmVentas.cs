﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class FrmVentas : Form
    {
        public FrmVentas ()
        {
            InitializeComponent();
        }

        private void cboProd_SelectedIndexChanged (object sender, EventArgs e)
        {
            CapaNegocios.clsReporteProductos prod = new CapaNegocios.clsReporteProductos();
            DataTable dtProductos;

            dtProductos = prod.llenarDTGProductos();
            cboProd.DataSource = dtProductos;
            cboProd.DisplayMember = "Nombre";
            cboProd.ValueMember = "Id Producto";
        }

        private void btnInsertar_Click (object sender, EventArgs e)
        {
            CapaNegocios.clsVenta venta = new CapaNegocios.clsVenta();

            if (cboProd.SelectedValue!=null)
            {
                foreach (DataGridViewRow prod in dgvVentas.Rows)
                {
                    if (prod.Cells["IdProducto"].Value.ToString().Equals(cboProd.SelectedValue.ToString()))
                    {
                        prod.Cells["Cantidad"].Value = (int)prod.Cells["Cantidad"].Value+(int)nupCantidad.Value;
                        return;
                    }
                }
                DataTable oDT = venta.llenarDTGProdcs(Convert.ToInt32(cboProd.SelectedValue));
                dgvVentas.Rows.Add(oDT.Rows[0]["Id Producto"], oDT.Rows[0]["Precio"], oDT.Rows[0]["Peso"], oDT.Rows[0]["Nombre"],oDT.Rows[0]["Categoría"], (int)nupCantidad.Value);

            }
        }
    }
}
