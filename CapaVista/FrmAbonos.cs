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
    public partial class FrmAbonos : Form
    {
        public FrmAbonos ()
        {
            InitializeComponent();
        }

        private void btnAdd_Click (object sender, EventArgs e)
        {
            CapaNegocios.clsAbono abono = new CapaNegocios.clsAbono();
            if (abono.insertarAbono(Int32.Parse(txtID.Text),float.Parse(txtMonto.Text),dtFecha.Value,float.Parse(txtSaldo.Text)))
            {
                MessageBox.Show("Courrier agregado");
                limpiar();
            }
        }
        private void limpiar ()
        {
            txtID.Text = " ";
            txtMonto.Text = " ";
            txtSaldo.Text = " ";
        }
    }
}
