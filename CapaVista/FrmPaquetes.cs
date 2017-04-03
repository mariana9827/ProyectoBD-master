using System;
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
    public partial class FrmPaquetes : Form
    {
        public FrmPaquetes ()
        {
            InitializeComponent();
        }

        private void cboFactura_SelectedIndexChanged (object sender, EventArgs e)
        {
            CapaNegocios.clsCredito factura = new CapaNegocios.clsCredito();
            DataTable dtfactura = new DataTable();

            dtfactura = factura.cargarFactura();
            cboFactura.DataSource = dtfactura;
            cboFactura.DisplayMember = "Nombre";
            cboFactura.ValueMember = "Id_Persona";
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
    }
}
