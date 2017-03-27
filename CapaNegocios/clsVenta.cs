using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public  class clsVenta
    {
        public bool insertarVenta (DateTime fecha,float precio, int identificacion)
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
             return conecta.ejecutarInsert("INSERT INTO dbo.Factura(FechaVenta,Activo,Precio,Id_Persona)VALUES('"+fecha.Year.ToString()+fecha.Month.ToString()+fecha.Day.ToString()+"',1,"+precio+","+identificacion+")");
        }
    
    }
}
