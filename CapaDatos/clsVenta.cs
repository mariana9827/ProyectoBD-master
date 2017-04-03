using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsVenta

    {
        public bool insertarFactura (String fecha, float precio, int identificacion)
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            return conecta.ejecutarInsert("INSERT INTO dbo.Factura(FechaVenta,Activo,Precio,Id_Persona)VALUES('" +fecha + "',1," + precio + "," + identificacion + ")");
        }

        public DataTable llenarProduct (int identificacion)
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtProd;
            dtProd = conecta.ejecutar("SELECT Id_Producto as 'Id Producto', Precio, Peso, Nombre, Id_Tipo as Categoría,Id_Persona as Identificación From dbo.Producto WHERE Id_Producto=(" + identificacion + ")");
            return dtProd;
        }

        public bool insertarDetalle (int detalle, float precio, int cantidad, int producto)
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            return conecta.ejecutarInsert("INSERT INTO dbo.Detalle (Id_Detalle,PrecioVenta,Cantidad,Id_Producto,Id_Factura) VALUES("+detalle+","+precio+","+cantidad+","+producto+ ",  IDENT_Current('dbo.Factura'))");
        }
       
    }
}
