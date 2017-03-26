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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores ()
        {
            InitializeComponent();
 
        }

        private void btnAddCou_Click (object sender, EventArgs e)
        {
            CapaNegocios.clsProveedor proveedor = new CapaNegocios.clsProveedor();
        
                if (rbNacional.Checked)
                {
                    if (proveedor.insertarNacional(Int32.Parse(txtId.Text), txtName.Text, txtApe1.Text, txtApe2.Text, rbMale.Checked, txtDesc.Text))
                    {
                        MessageBox.Show("Proveedor Nacional Agregado");
                        limpiar();
                    }
                }
                if (rbExtranjero.Checked)
                {
                    if (proveedor.insertarExtranjera(Int32.Parse(txtId.Text), txtName.Text, txtApe1.Text, txtApe2.Text, rbMale.Checked, txtDesc.Text))
                    {
                        MessageBox.Show("Proveedor Extranjero Agregado");
                        limpiar();
                    }
                }
                if (rbJuridico.Checked)
                {
                    if (proveedor.insertarJuridico(txtDesc.Text, txtName.Text, Int32.Parse(txtId.Text)))
                    {
                        MessageBox.Show("Proveedor Juridico Agregado");
                        limpiar();
                    }
                }
          } 

        public void limpiar ()
        {
            txtId.Text = " ";
            txtName.Text = " ";
            txtApe1.Text = " ";
            txtApe2.Text = "";
            rbExtranjero.Checked = false;
            rbNacional.Checked = false;
            rbFemale.Checked = false;
            rbMale.Checked = false;
            txtDesc.Text = " ";
            rbJuridico.Checked = false;
        }

        private void rbNacional_CheckedChanged (object sender, EventArgs e)
        {
            lbId.Visible = true;
            lbName.Visible = true;
            lbApe1.Visible = true;
            lbApe2.Visible = true;
            lbGen.Visible = true;
            lbDes.Visible = true;
            txtId.Visible = true;
            txtDesc.Visible = true;
            txtName.Visible = true;
            txtApe1.Visible = true;
            txtApe2.Visible = true;
            gbGenre.Visible = true;
            lbExtran.Visible = false;
            btnAddCou.Visible = true;
        }

        private void rbExtranjero_CheckedChanged (object sender, EventArgs e)
        {
            lbId.Visible = true;
            lbName.Visible = true;
            lbApe1.Visible = true;
            lbApe2.Visible = true;
            lbGen.Visible = true;
            lbDes.Visible = true;
            txtId.Visible = true;
            txtDesc.Visible = true;
            txtName.Visible = true;
            txtApe1.Visible = true;
            txtApe2.Visible = true;
            gbGenre.Visible = true;
            lbExtran.Visible = true;
            btnAddCou.Visible = true;
        }

        private void rbJuridico_CheckedChanged (object sender, EventArgs e)
        {
            lbId.Visible = true;
            lbName.Visible = true;
            lbApe1.Visible = false;
            lbApe2.Visible = false;
            lbGen.Visible = false;
            lbDes.Visible = true;
            txtId.Visible = true;
            txtDesc.Visible = true;
            txtName.Visible = true;
            txtApe1.Visible = false;
            txtApe2.Visible = false;
            gbGenre.Visible = false;
            lbExtran.Visible = false;
            btnAddCou.Visible = true;
        }


    }

}
 

