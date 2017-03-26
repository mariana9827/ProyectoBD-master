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
     
        public bool insertarProd (int codigo, float precio, float peso, float costo, String nombre, int tipo, String medidas,int identificacion )
        {
            return new CapaDatos.clsProducto().insertarProductos(codigo,precio,peso,costo,nombre,tipo, medidas, identificacion);
        }

        public DataTable llenarPersona ()
        {
            CapaDatos.clsProducto persona = new CapaDatos.clsProducto();
            return persona.cargarProveedor();
        }
    }

}
