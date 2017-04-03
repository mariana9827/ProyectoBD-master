using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
   public class clsCredito
    
    {
        CapaDatos.clsConexion conect= new CapaDatos.clsConexion();

        public bool insertarCredito(float saldo, String pago, float monto, String limite, int identificacion)
        {
            return conect.ejecutarInsert("insert dbo.Credito(Saldo, FechaPago, MontoPagado, FechaLimite, Id_TipoPago,Id_Pago,Id_Factura)values("+saldo+ ",'" + pago+ "',"+monto+ ",'" + limite + "',1,IDENT_Current('dbo.Pago'),"+identificacion+")");
        }

        public DataTable factura ()
        {
            DataTable dtFactura;
            dtFactura = conect.ejecutar("Select ID_Factura,Id_Persona from dbo.Factura");
            return dtFactura;
        }
        public bool insertarPagoCredito(int identificacion)
        {
            return conect.ejecutarInsert("INSERT INTO dbo.Pago(Id_TipoPago, Activo, Id_Factura)Values(1,1,"+identificacion+")");
        }
        public bool insertarPagoContado(int identificacion)
        {
            return conect.ejecutarInsert("INSERT INTO dbo.Pago(Id_TipoPago, Activo, Id_Factura)Values(0,1,"+identificacion+")");
        }
        
    }
}
