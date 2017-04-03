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

        private void FrmJuridico_Load (object sender, EventArgs e)
        {

        }

        private void btnAddCou_Click (object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Deseea agregar un courier?", "Confirmación", MessageBoxButtons.OKCancel);
            CapaNegocios.clsJuridico juridico = new clsJuridico();
            if (juridico.insertarJuridico(txtDesc.Text, Int32.Parse(txtId.Text), txtName.Text))
            {
                MessageBox.Show("Juridico agregado");
                limpiar();
                
                if (result == DialogResult.OK) {
                    FrmCourrier courrier= new FrmCourrier();
                    courrier.Show();
                }
          }
        }
    
       public void limpiar ()
        {
            txtName.Text = " ";
            txtId.Text = " ";
            txtDesc.Text = " ";
        }
    }
}