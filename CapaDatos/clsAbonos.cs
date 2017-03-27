using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsAbonos
    {
        public bool insertarAbono (int identificacion, float monto, DateTime fecha, float saldo, int factura)
        {
            CapaDatos.clsConexion conecta = new clsConexion();
            return conecta.ejecutarInsert("INSERT INTO dbo.Abonos (Id_Abonos,MontoAbonado,FechaAbono,SaldoPagar,Id_Factura)VALUES("+identificacion+","+monto+ ", '"+ fecha.Year.ToString() + fecha.Month.ToString() + fecha.Day.ToString() + "',"+saldo+","+factura+")");
        }
    }
}
