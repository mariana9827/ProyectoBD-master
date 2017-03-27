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
            cboProd.ValueMember = "Id_Producto";
        }
    }
}
