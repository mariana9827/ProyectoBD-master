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
    }
}
