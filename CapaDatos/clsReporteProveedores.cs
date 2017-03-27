using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsReporteProveedores
    {
        public DataTable cargarProveedores ()
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtProveedor;
            dtProveedor = conecta.ejecutar("SELECT Activo,Descripcion,Id_Persona,Nombre From dbo.Proveedor");
            return dtProveedor;
        }


        public DataTable cargarProveedoresNacionales ()
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtProveedorNac;
            dtProveedorNac = conecta.ejecutar("Select E.Nombre, E.Apellido1 as '1er Apellido', E.Apellido2 as '2do Apellido', E.Genero, E.Id_Persona as Identificación From dbo.Nacional E Inner Join dbo.Proveedor P on E.Id_Persona=P.Id_Persona");
            return dtProveedorNac;
        }

        public DataTable cargarProveedoresExtranjeros()
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtProveedorExt;
            dtProveedorExt = conecta.ejecutar("Select E.Nombre, E.Apellido1 as '1er Apellido', E.Apellido2 as '2do Apellido', E.Genero, E.Id_Persona as Identificación From dbo.Extranjera E Inner Join dbo.Proveedor P on E.Id_Persona=P.Id_Persona");
            return dtProveedorExt;
        }

        public DataTable cargarProveedoresJuridicos ()
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtProveedorJur;
            dtProveedorJur = conecta.ejecutar("Select J.Id_Persona as Identificación,j.Nombre, j.Descripcion as Descripción From dbo.Juridica J Inner Join dbo.Proveedor P on J.Id_Persona=P.Id_Persona");
            return dtProveedorJur; 
        }
    }
}

