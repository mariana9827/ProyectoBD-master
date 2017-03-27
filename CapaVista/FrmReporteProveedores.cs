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
    public partial class FrmReporteProveedores : Form
    {
        public FrmReporteProveedores ()
        {
            InitializeComponent();
        }

        private void FrmReporteProveedores_Load (object sender, EventArgs e)
        {

        }

        private void rbTodos_CheckedChanged (object sender, EventArgs e)
        {
            if (rbTodos.Checked)
            {
                dgvProveedor.Visible = true;
                CapaNegocios.clsReporteProveedores reporteProve = new CapaNegocios.clsReporteProveedores();
                DataTable dtrepProve = new DataTable();

                dtrepProve = reporteProve.llenarDTGProveedores();
                dgvProveedor.DataSource = dtrepProve;
            }
        }

        private void gbPerson_Enter (object sender, EventArgs e)
        {

        }

        private void rbNacionales_CheckedChanged (object sender, EventArgs e)
        {

            if (rbNacionales.Checked)
            {
                dgvProveedor.Visible = true;
                CapaNegocios.clsReporteProveedores reporteProveNac = new CapaNegocios.clsReporteProveedores();
                DataTable dtrepProveNac = new DataTable();

                dtrepProveNac = reporteProveNac.llenarDTGProveedoresNac();
                dgvProveedor.DataSource = dtrepProveNac;
            }
        }

        private void rbExtranjero_CheckedChanged (object sender, EventArgs e)
        {
            if (rbExtranjero.Checked)
            {
                dgvProveedor.Visible = true;
                CapaNegocios.clsReporteProveedores reporteProveExt = new CapaNegocios.clsReporteProveedores();
                DataTable dtrepProveExt = new DataTable();

                dtrepProveExt = reporteProveExt.llenarDTGProveedoresExt();
                dgvProveedor.DataSource = dtrepProveExt;
            }
        }

        private void rbJuridico_CheckedChanged (object sender, EventArgs e)
        {
            if (rbJuridico.Checked)
            {
                dgvProveedor.Visible = true;
                CapaNegocios.clsReporteProveedores reporteProveJur = new CapaNegocios.clsReporteProveedores();
                DataTable dtrepProveJur = new DataTable();

                dtrepProveJur = reporteProveJur.llenarDTGProveedoresJur();
                dgvProveedor.DataSource = dtrepProveJur;
            }
        }
    }
}
