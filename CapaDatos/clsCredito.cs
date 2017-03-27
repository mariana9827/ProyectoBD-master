using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class clsCredito
    {
        public bool insertarCredito(float saldo, DateTime pago, float monto, DateTime limite, int identificacion, int idpago)
        {
            clsConexion conect = new clsConexion();
            return conect.ejecutarInsert("insert dbo.Credito(Saldo, FechaPago, MontoPagado, FechaLimite, Id_Pago, Id_Factura)values("+saldo+ ",'" + pago.Year.ToString() + pago.Month.ToString() + pago.Day.ToString() + "',"+monto+ ",'" + limite.Year.ToString() + limite.Month.ToString() + limite.Day.ToString() + "',1,"+idpago+","+identificacion+")");
        }
    }
}
