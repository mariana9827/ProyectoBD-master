using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class clsCredito
    {
        public bool insertarCredito (float saldo, String pago, float monto, String limite,int identificacion)
        {
            return new CapaDatos.clsCredito().insertarCredito(saldo,pago,monto,limite,identificacion);
        }

        public DataTable cargarFactura ()
        {
            return new CapaDatos.clsCredito().factura();
        }
        public bool PagoCredito(int identificacion)
        {
            return new CapaDatos.clsCredito().insertarPagoCredito(identificacion);
        }
        public bool PagoContado(int identificacion  )
        {
            return new CapaDatos.clsCredito().insertarPagoContado(identificacion);
        }
    }
}
