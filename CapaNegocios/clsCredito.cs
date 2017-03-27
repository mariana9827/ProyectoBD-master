using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class clsCredito
    {
        public bool insertarCredito (float saldo, DateTime pago, float monto, DateTime limite, int identificacion, int idpago)
        {
            return new CapaDatos.clsCredito().insertarCredito(saldo,pago,monto,limite,identificacion,idpago);
        }
    }
}
