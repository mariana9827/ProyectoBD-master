using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public  class clsVenta
    {
        public bool realizarFactura(String fecha, float precio, int identificacion)
        {
            return new CapaDatos.clsVenta().insertarFactura(fecha, precio, identificacion);
        }

        public DataTable llenarDTGProdcs (int identificacion)
        {
            CapaDatos.clsVenta ventas = new CapaDatos.clsVenta();
            return ventas.llenarProduct(identificacion);
        }

        public bool insertarDetalle (int detalle, float precio, int cantidad, int producto)
        {
            return new CapaDatos.clsVenta().insertarDetalle(detalle,precio,cantidad,producto);
            
        }
    }
}
