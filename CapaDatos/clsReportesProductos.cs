using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class clsReportesProductos
    {
        public DataTable cargarProductos()
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtProductos;
            dtProductos = conecta.ejecutar("SELECT Id_Producto as 'Ident. Producto',Activo,Precio,Peso,Costo as 'Costo Producto',Nombre,Id_Tipo as Categoría,Medida,Id_Persona as Identificación,Cantidad  FROM dbo.Producto");
            return dtProductos;
        }

    }
}
