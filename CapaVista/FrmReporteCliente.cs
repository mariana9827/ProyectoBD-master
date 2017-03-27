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

        private void FrmReporteCliente_Load (object sender, EventArgs e)
        {
              
        }

        private void dgvCliente_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void rbTodos_CheckedChanged (object sender, EventArgs e)
        {
            if (rbTodos.Checked)
            {
                dgvCliente.Visible = true;
                CapaNegocios.clsReporteClientes reporteCliente = new CapaNegocios.clsReporteClientes();
                DataTable dtrepCliente = new DataTable();

                dtrepCliente = reporteCliente.llenarDTGClientes();
                dgvCliente.DataSource = dtrepCliente;
            }
  
        }
        

        private void rbNacionales_CheckedChanged (object sender, EventArgs e)
        {
            if (rbNacionales.Checked)
            {
                dgvCliente.Visible = true;
                CapaNegocios.clsReporteClientes reporteClienteNac = new CapaNegocios.clsReporteClientes();
                DataTable dtrepClienteNac = new DataTable();

                dtrepClienteNac= reporteClienteNac.llenarDTGClientesNac();
                dgvCliente.DataSource = dtrepClienteNac;
            }
        }

        private void rbJuridico_CheckedChanged (object sender, EventArgs e)
        {
            if (rbJuridico.Checked)
            {
                dgvCliente.Visible = true;
                CapaNegocios.clsReporteClientes reporteClienteJur = new CapaNegocios.clsReporteClientes();
                DataTable dtrepClienteJur = new DataTable();

                dtrepClienteJur = reporteClienteJur.llenarDTGClientesJur();
                dgvCliente.DataSource = dtrepClienteJur;
            }
        }

        private void rbExtranjero_CheckedChanged (object sender, EventArgs e)
        {
            if (rbExtranjero.Checked)
            {
                dgvCliente.Visible = true;
                CapaNegocios.clsReporteClientes reporteClienteExt = new CapaNegocios.clsReporteClientes();
                DataTable dtrepClienteExt = new DataTable();

                dtrepClienteExt = reporteClienteExt.llenarDTGClientesExt();
                dgvCliente.DataSource = dtrepClienteExt;
            }
        }
    }
}
