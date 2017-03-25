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
    public partial class FrmCourrier : Form
    {
        public FrmCourrier ()
        {
            InitializeComponent();
        }

        private void btnAddCou_Click (object sender, EventArgs e)
        {
            CapaNegocios.clsCourrier clienteNa = new CapaNegocios.clsCourrier();
        
                if (clienteNa.insertarCourrier(txtName.Text,int.Parse(cboJuridico.SelectedValue.ToString())))
                {
                    MessageBox.Show("Courrier agregado");
                    limpiar();
                }
            
        }

        public void limpiar ()
        {
             txtName.Text = " ";
         
        }

        private void comboBox1_SelectedIndexChanged (object sender, EventArgs e)
        {
            DataTable oDT = new DataTable();
            CapaNegocios.clsCourrier juridico = new CapaNegocios.clsCourrier();

            oDT = juridico.LLenarTipoJuridico();
            cboJuridico.DataSource = oDT;
            cboJuridico.DisplayMember = "Nombre";
            cboJuridico.ValueMember = "Id_Persona";
        }

        private void FrmCourrier_Load (object sender, EventArgs e)
        {
            
        }
    }
}
