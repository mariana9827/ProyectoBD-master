using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocios
{
    public class clsProducto
    {
        public DataTable llenarCategoria ()
        {
            CapaDatos.clsProducto categoria = new CapaDatos.clsProducto();
            return categoria.cargarCategorias();
        }
        
    }
    
}
