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
    public partial class FrmLogin : Form
    {
        public FrmLogin ()
        {
            InitializeComponent();
        }

        private void button1_Click (object sender, EventArgs e)
        {
            CapaNegocios.clsLogin login = new CapaNegocios.clsLogin();
            if (login.login(txtUser.Text,textPassw.Text).Rows.Count>0)
            {
                new FrmPrincipal().Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña invalidos, intente de nuevo.");
            }
        }
    }
}
