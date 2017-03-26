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
    public partial class FrmReporteCliente : Form
    {
        public FrmReporteCliente ()
        {
            InitializeComponent();
        }

        private void dgvCliente_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
            CapaNegocios.clsReporteClientes reporteCliente = new CapaNegocios.clsReporteClientes();
            DataTable dtrepCliente = new DataTable();

            dtrepCliente = reporteCliente.llenarDTGClientes();
            dgvCliente.DataSource = dtrepCliente;
           
        }
    }
}
