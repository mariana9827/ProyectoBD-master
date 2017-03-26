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
    public partial class FrmProductocs : Form
    {
        public FrmProductocs ()
        {
            InitializeComponent();
        }

        private void label6_Click (object sender, EventArgs e)
        {

        }

        private void cboTipo_SelectedIndexChanged (object sender, EventArgs e)
        {
            CapaNegocios.clsProducto categoria = new CapaNegocios.clsProducto();
            DataTable dtCategoria = new DataTable();

            dtCategoria = categoria.llenarCategoria();
            cboTipo.DataSource = dtCategoria;
            cboTipo.DisplayMember = "Categoria";
            cboTipo.ValueMember = "Id_Tipo";

        }

        private void FrmProductocs_Load (object sender, EventArgs e)
        {

        }

        private void btnAddCou_Click (object sender, EventArgs e)
        {
            CapaNegocios.clsProducto producto = new CapaNegocios.clsProducto();

            if (producto.insertarProd(Int32.Parse(txtCod.Text), float.Parse(txtSale.Text), float.Parse(txtPeso.Text), float.Parse(txtCosto.Text), txtName.Text, int.Parse(cboTipo.SelectedValue.ToString()), cboMedida.Text,int.Parse(cboProveedor.SelectedValue.ToString())))
            {
                MessageBox.Show("Producto agregado");
                limpiar();

            }
        }

        private void comboBox1_SelectedIndexChanged (object sender, EventArgs e)
        {

        }

        private void txtPeso_TextChanged (object sender, EventArgs e)
        {

        }

        private void limpiar ()
        {
            txtCod.Text = " ";
            txtCosto.Text = " ";
            txtName.Text = " ";
            txtPeso.Text = " ";
            txtSale.Text = " ";
            cboMedida.Text = " ";
            cboTipo.Text = " ";
        }

        private void cboProveedor_SelectedIndexChanged (object sender, EventArgs e)
        {
            CapaNegocios.clsProducto proveedor = new CapaNegocios.clsProducto();
            DataTable dtProveedor = new DataTable();

            dtProveedor = proveedor.llenarPersona();
            cboProveedor.DataSource = dtProveedor;
            cboProveedor.DisplayMember = "Id_Persona";
            cboProveedor.ValueMember = "Id_Persona";
        }

        private void cboTipo_SelectedIndexChanged_1 (object sender, EventArgs e)
        {
            CapaNegocios.clsProducto categoria = new CapaNegocios.clsProducto();
            DataTable dtcategoria = new DataTable();

            dtcategoria = categoria.llenarCategoria();
            cboTipo.DataSource = dtcategoria;
            cboTipo.DisplayMember = "Nombre";
            cboTipo.ValueMember = "Id_Tipo";
        }
    }
}
