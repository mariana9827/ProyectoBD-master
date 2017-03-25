using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
   public class clsProducto
    {
        public DataTable cargarCategorias ()
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtCategoria;
            dtCategoria = conecta.ejecutar("SELECT Id_Tipo, Categoria FROM dbo.Tipo_Producto");
            return dtCategoria;
        }
    }
}
