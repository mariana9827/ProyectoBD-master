using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace CapaVista
{
    public partial class FrmJuridico : Form
    {
        public FrmJuridico ()
        {
            InitializeComponent();
        }

        private void btnAdd_Click (object sender, EventArgs e)
        {

        }

        public void cboCourrier_SelectedIndexChanged (object sender, EventArgs e)
        {

        }

        private void FrmJuridico_Load (object sender, EventArgs e)
        {

        }


        private void btnAdd_Click_1 (object sender, EventArgs e)
        {
            CapaNegocios.clsCliente juridico = new CapaNegocios.clsCliente();
            if (juridico.insertarJuridico(txtDesc.Text, txtName.Text, Int32.Parse(txtID.Text)))
            {
                MessageBox.Show("Cliente agregado");
                limpiar();
            }
        }
        public void limpiar ()
        {
            txtID.Text = " ";
            txtName.Text = " ";
            txtDesc.Text = " ";
        }
    }
}