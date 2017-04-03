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
    public partial class FrmVentas : Form
    {
        public FrmVentas ()
        {
            InitializeComponent();
        }

        private void cboProd_SelectedIndexChanged (object sender, EventArgs e)
        {
            CapaNegocios.clsReporteProductos prod = new CapaNegocios.clsReporteProductos();
            DataTable dtProductos;

            dtProductos = prod.llenarDTGProductos();
            cboProd.DataSource = dtProductos;
            cboProd.DisplayMember = "Nombre";
            cboProd.ValueMember = "Id Producto";
        }

        private void btnInsertar_Click (object sender, EventArgs e)
        {
            CapaNegocios.clsVenta venta = new CapaNegocios.clsVenta();

            if (cboProd.SelectedValue!=null)
            {
                foreach (DataGridViewRow prod in dgvVentas.Rows)
                {
                    if (prod.Cells["IdProducto"].Value.ToString().Equals(cboProd.SelectedValue.ToString()))
                    {
                        prod.Cells["Cantidad"].Value = (int)prod.Cells["Cantidad"].Value+(int)nupCantidad.Value;
                        
                        lbValor.Text = "" + total();
                        return;
                    }
                }
                DataTable oDT = venta.llenarDTGProdcs(Convert.ToInt32(cboProd.SelectedValue));
                dgvVentas.Rows.Add(oDT.Rows[0]["Id Producto"], oDT.Rows[0]["Precio"], oDT.Rows[0]["Peso"], oDT.Rows[0]["Nombre"],oDT.Rows[0]["Categoría"], (int)nupCantidad.Value);

            }
            
            lbValor.Text = ""+total();
        }

        private void cboCliente_SelectedIndexChanged (object sender, EventArgs e)
        {
            CapaNegocios.clsReporteClientes clientes = new CapaNegocios.clsReporteClientes();
            DataTable dtClientes;

            dtClientes = clientes.llenarDTGClientes();
            cboCliente.DataSource = dtClientes;
            cboCliente.DisplayMember = "Nombre";
            cboCliente.ValueMember = "Identificación";
        }

        public int total ()
        {
            int acumTotal=0;
            foreach (DataGridViewRow total in dgvVentas.Rows)
            {
                acumTotal += Convert.ToInt32(total.Cells["Cantidad"].Value) * Convert.ToInt32(total.Cells["Precio"].Value);
            }
            return acumTotal;
        }

        private void btnAdd_Click (object sender, EventArgs e)
        {
            CapaNegocios.clsVenta factura = new CapaNegocios.clsVenta();

            var result=MessageBox.Show("¿Seguro que deseea realizar la factura?","Confirmación",MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (factura.realizarFactura((String)dtFecha.Text,total(),Int32.Parse(cboCliente.Text)))
                {
                    for (int i = 0; i < dgvVentas.Rows.Count; i++)
                    {
                        float precio = (float)dgvVentas["Precio",i].Value;
                        int cantidad=(int)dgvVentas["Cantidad",i].Value;
                        int producto=Convert.ToInt16(dgvVentas["IdProducto",i].Value);

                        if (!factura.insertarDetalle(i,precio,cantidad,producto))
                        {
                            MessageBox.Show("Error al crear la factura, matese :(");
                            return;
                        }
                        
                    }
                    MessageBox.Show("Factura realizada correctamente");
                }
                else
                {
                    MessageBox.Show("Error al crear la factura, matese :(");
                }
            } 
        }

        private void rbCredito_CheckedChanged (object sender, EventArgs e)
        {
            if (rbCredito.Checked)
            {
                FrmCredito credito = new FrmCredito();
                credito.Show();
            }
        }
     
    }
}
