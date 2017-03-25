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
            CapaNegocios.clsCliente clienteNa = new CapaNegocios.clsCliente();
            if (rbNacional.Checked)
            {
                if (clienteNa.insertarNacional(Int32.Parse(txtId.Text), txtName.Text, txtApe1.Text, txtApe2.Text, rbMale.Checked))
                {
                    MessageBox.Show("Cliente agregado");
                    limpiar();
                }
            }
            if (rbExtranjero.Checked)
            {
                if (clienteNa.insertarExtranjera(Int32.Parse(txtId.Text), txtName.Text, txtApe1.Text, txtApe2.Text, rbMale.Checked))
                {
                    MessageBox.Show("Cliente agregado");
                    limpiar();
                }
            }
        }

        public void limpiar(){
            txtId.Text= " ";
            txtName.Text = " ";
            txtApe1.Text = " ";
            txtApe2.Text = "";
            rbExtranjero.Checked = false;
            rbNacional.Checked= false;
            rbFemale.Checked = false;
            rbMale.Checked = false;
        }

        private void rbExtranjero_CheckedChanged (object sender, EventArgs e)
        {
            if (rbExtranjero.Checked)
            {
                lbExtran.Visible = true;
            } else if (rbNacional.Checked)
            {
                lbExtran.Visible = false;
            }
        }
    }

 
}
