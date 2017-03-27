using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class clsAbono
    {
        public bool insertarAbono (int identificacion, float monto, DateTime fecha, float saldo)
        {

            return new CapaNegocios.clsAbono().insertarAbono(identificacion, monto, fecha, saldo);
        }
    }
}
