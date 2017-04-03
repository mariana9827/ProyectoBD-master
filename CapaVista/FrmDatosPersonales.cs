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
    public partial class FrmDatosPersonales : Form
    {
        public FrmDatosPersonales ()
        {
            InitializeComponent();
        }

        private void cboPais_SelectedIndexChanged (object sender, EventArgs e)
        {
            CapaNegocios.clsDatosPersonales pais =  new CapaNegocios.clsDatosPersonales();
            DataTable dtpais = new DataTable();

            dtpais = pais.CargarPais();
            cboPais.DataSource = dtpais;
            cboPais.DisplayMember ="Nombre";
            cboPais.ValueMember= "Id_Pais";
        }

        private void cboId_SelectedIndexChanged (object sender, EventArgs e)
        {
            CapaNegocios.clsReporteClientes clientes = new CapaNegocios.clsReporteClientes();
            DataTable dtCliente = new DataTable();

            dtCliente = clientes.llenarDTGClientes();
            cboId.DataSource = dtCliente;
            cboId.DisplayMember = "Identificación";
            cboId.ValueMember = "Identificación";
        }

        private void cboAdress_SelectedIndexChanged (object sender, EventArgs e)
        {

            CapaNegocios.clsDatosPersonales clientes = new CapaNegocios.clsDatosPersonales();
            DataTable dtCliente = new DataTable();

            dtCliente = clientes.CargarTipoDireccion();
            cboAdress.DataSource = dtCliente;
            cboAdress.DisplayMember = "Descripcion";
            cboAdress.ValueMember = "Id_TipoDireccion";
        }

        private void cboTel_SelectedIndexChanged (object sender, EventArgs e)
        {
            CapaNegocios.clsDatosPersonales clientes = new CapaNegocios.clsDatosPersonales();
            DataTable dtCliente = new DataTable();

            dtCliente = clientes.CargarTipoTelefono();
            cboTel.DataSource = dtCliente;
            cboTel.DisplayMember = "Descripcion";
            cboTel.ValueMember = "Id_tipotel";
        }

        private void cboCorreo_SelectedIndexChanged (object sender, EventArgs e)
        {
            CapaNegocios.clsDatosPersonales clientes = new CapaNegocios.clsDatosPersonales();
            DataTable dtCliente = new DataTable();

            dtCliente = clientes.CargarTipoCorreo();
            cboCorreo.DataSource = dtCliente;
            cboCorreo.DisplayMember = "Descripcion";
            cboCorreo.ValueMember = "Id_tipoco";
        }

        private void cboTel_SelectedIndexChanged_1 (object sender, EventArgs e)
        {

        }

        private void btnAdd_Click (object sender, EventArgs e)
        {
            CapaNegocios.clsDatosPersonales datos = new CapaNegocios.clsDatosPersonales();
            if (datos.insertaDireccion(Convert.ToInt32(cboPais.SelectedValue),txtprov.Text,Int32.Parse(txtCodPos.Text),txtDescDir.Text,Convert.ToInt32(cboId.SelectedValue),Convert.ToInt32(cboAdress.SelectedValue)))
            {
                MessageBox.Show("Direccion insertada");
            }
        }
    }
}
