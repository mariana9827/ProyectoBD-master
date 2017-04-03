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
    public partial class FrmClienteProv : Form
    {
        public FrmClienteProv ()
        {
            InitializeComponent();
        }

        private void FrmClienteProv_Load (object sender, EventArgs e)
        {

        }

        private void cboID_SelectedIndexChanged (object sender, EventArgs e)
        {
            CapaNegocios.clsReporteClientes clientes = new CapaNegocios.clsReporteClientes();
            DataTable dtCliente = new DataTable();

            dtCliente = clientes.llenarDTGClientes();
            cboID.DataSource = dtCliente;
            cboID.DisplayMember = "Identificación";
            cboID.ValueMember = "Identificación";

        }

        private void btnAddCou_Click (object sender, EventArgs e)
        {
            CapaNegocios.clsProveedor prove = new CapaNegocios.clsProveedor();
            if (prove.insertarProveedor(txtDesc.Text,Int32.Parse(cboID.SelectedValue.ToString()),txtName.Text))
            {
                MessageBox.Show("Nuevo proveedor, agregado");
            }
        }

        private void txtName_TextChanged (object sender, EventArgs e)
        {
            
        }
    }
}
