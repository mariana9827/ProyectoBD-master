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
    public partial class FrmCliente : Form
    {
        public FrmCliente ()
        {
            
            InitializeComponent();
        }


        private void FrmCliente_Load (object sender, EventArgs e)
        {

        }

        private void btnAdd_Click (object sender, EventArgs e)
        {
            CapaNegocios.clsCliente cliente = new CapaNegocios.clsCliente();

            if (rbNacional.Checked)
            {
                if (cliente.insertarNacional(Int32.Parse(txtId.Text),txtName.Text, txtApe1.Text,txtApe2.Text,rbMale.Checked))
                {
                    MessageBox.Show("Cliente Nacional Agregado");
                    limpiar();
                }
            }
            if (rbExtranjero.Checked)
            {
                if (cliente.insertarExtranjera(Int32.Parse(txtId.Text), txtName.Text, txtApe1.Text, txtApe2.Text, rbMale.Checked))
                {
                    MessageBox.Show("Proveedor Extranjero Agregado");
                    limpiar();
                }
            }
            if (rbJuridico.Checked)
            {
                if (cliente.insertarJuridico(txtDesc.Text, txtName.Text, Int32.Parse(txtId.Text)))
                {
                    MessageBox.Show("Proveedor Juridico Agregado");
                    limpiar();
                }
            }
        }

        public void limpiar () {
            txtId.Text = " "; 
            txtDesc.Text= " ";
            txtName.Text = " ";
            txtApe1.Text = " ";
            txtApe2.Text = "";
            rbFemale.Checked = false;
            rbMale.Checked = false;
        }

        private void rbExtranjero_CheckedChanged (object sender, EventArgs e)
        {
            lbId.Visible = true;
            lbName.Visible = true;
            lbApe1.Visible = true;
            lbApe2.Visible = true;
            lbGen.Visible = true;
            lbDes.Visible = false;
            txtId.Visible = true;
            txtDesc.Visible = false;
            txtName.Visible = true;
            txtApe1.Visible = true;
            txtApe2.Visible = true;
            gbGenre.Visible = true;
            lbExtran.Visible = true;
            btnAdd.Visible = true;
        }

        private void rbNacional_CheckedChanged (object sender, EventArgs e)
        {
            lbId.Visible = true;
            lbName.Visible = true;
            lbApe1.Visible = true;
            lbApe2.Visible = true;
            lbGen.Visible = true;
            txtId.Visible = true;
            lbDes.Visible = false;
            txtDesc.Visible = false;
            txtName.Visible = true;
            txtApe1.Visible = true;
            txtApe2.Visible = true;
            gbGenre.Visible = true;
            lbExtran.Visible = false;
            btnAdd.Visible = true;
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
            btnAdd.Visible = true;
        }
    }

 
}
