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
            dtProductos = conecta.ejecutar("SELECT Id_Producto as 'Id Producto', Activo, Precio, Peso, Costo, Nombre, Id_Tipo as Categoría,Medida,Id_Persona as Identificación, Cantidad From dbo.Producto");
            return dtProductos;
        }

    }
}
