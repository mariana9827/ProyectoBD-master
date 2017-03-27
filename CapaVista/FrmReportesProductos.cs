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
    public partial class FrmReportesProductos : Form
    {
        public FrmReportesProductos ()
        {
            InitializeComponent();
        }

        private void dgvCliente_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmReportesProductos_Load (object sender, EventArgs e)
        {

            CapaNegocios.clsReporteProductos reporteProductos = new CapaNegocios.clsReporteProductos();
            DataTable dtrepProductos = new DataTable();

            dtrepProductos= reporteProductos.llenarDTGProductos();
            dgvCliente.DataSource = dtrepProductos;
        }
    }
}
