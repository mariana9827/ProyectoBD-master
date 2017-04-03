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
    public partial class FrmPago : Form
    {
        public FrmPago ()
        {
            InitializeComponent();
        }

        private void cboFactura_SelectedIndexChanged (object sender, EventArgs e)
        {

        }

        private void cboFactura_SelectedIndexChanged_1 (object sender, EventArgs e)
        {
            CapaNegocios.clsCredito factura = new CapaNegocios.clsCredito();
            DataTable dtfactura = new DataTable();

            dtfactura = factura.cargarFactura();
            cboFactura.DataSource = dtfactura;
            cboFactura.DisplayMember = "Nombre";
            cboFactura.ValueMember = "Id_Persona";
        }

        private void rbContado_CheckedChanged (object sender, EventArgs e)
        {
            txtSaldo.Visible = false;
            dtPago.Visible = false;
            txtMonto.Visible = true;
            cboFactura.Visible = true;
            dtLimite.Visible = false;
            lbfact.Visible = true;
            lbFlim.Visible = false;
            lbFpago.Visible = false;
            lbmonto.Visible = true;
            lbsaldo.Visible = false;
            btnAdd.Visible = true;
        }

        private void btnAdd_Click (object sender, EventArgs e)
        {
            CapaNegocios.clsCredito pago = new CapaNegocios.clsCredito();

            if (rbCredito.Checked)
            {
                if (pago.PagoCredito(Int32.Parse(cboFactura.Text)))
                {
                    if (pago.insertarCredito(float.Parse(txtSaldo.Text), dtPago.Text, float.Parse(txtMonto.Text), dtLimite.Text,Int32.Parse(cboFactura.Text)))
                    {
                        MessageBox.Show("Crédito realizado");
                    }
                }
            }
            if (rbContado.Checked)
            {
                if (pago.PagoContado(Int32.Parse(cboFactura.Text)))
                {
                    MessageBox.Show("Pago a contado realizado");
                }
            }
        }

        private void rbCredito_CheckedChanged (object sender, EventArgs e)
        {
            txtSaldo.Visible = true;
            dtPago.Visible = true;
            txtMonto.Visible = true;
            cboFactura.Visible = true;
            dtLimite.Visible = true;
            lbfact.Visible = true;
            lbFlim.Visible = true;
            lbFpago.Visible = true;
            lbmonto.Visible = true;
            lbsaldo.Visible = true;
            btnAdd.Visible = true;
        }
    }
}
