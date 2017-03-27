using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class clsVenta
    {
        public bool realizarVenta (DateTime fecha, float precio, int identificacion)
        {
            return new CapaDatos.clsVenta().realizarVenta(fecha, precio, identificacion);
        }
    }
}
