using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class clsProveedor
    {
        public bool insertarNacional (int identificacion, String nombre, String apellido1, String apellido2, int genero, String descripcion)
        {

            clsConexion conect = new clsConexion();
            bool creadoPersona, creadoNacional, creadoProveedor;

            creadoPersona = conect.ejecutarInsert("INSERT INTO dbo.Persona(Activo,Id_Persona,Id_TipoPersona) values (1," + identificacion + ", 1)");
            creadoProveedor=conect.ejecutarInsert("INSERT INTO dbo.Proveedor(Activo,Descripcion,Id_Persona)Values(1,'" + descripcion + "'," + identificacion + ")");
            creadoNacional = conect.ejecutarInsert("INSERT INTO dbo.Nacional (Nombre,Apellido1,Apellido2,Genero,Id_Persona) Values('" + nombre + "','" + apellido1 + "','" + apellido2 + "'," + genero + "," + identificacion + ")");

            if (creadoPersona && creadoNacional && creadoProveedor)
            {
                return true;
            }
            return false;
        }

        public bool insertarExtranjera (int identificacion, String nombre, String apellido1, String apellido2, int genero, String descripcion)
        {

            clsConexion conect = new clsConexion();
            bool creadoPersona, creadoExtranjero, creadoProveedor;

            creadoPersona = conect.ejecutarInsert("INSERT INTO dbo.Persona(Activo,Id_Persona,Id_TipoPersona) values (1," + identificacion + ",2)");
            creadoProveedor = conect.ejecutarInsert("INSERT INTO dbo.Proveedor(Activo,Descripcion,Id_Persona)Values(1,'" + descripcion + "'," + identificacion + ")");
            creadoExtranjero = conect.ejecutarInsert("INSERT INTO dbo.Extranjera(Nombre,Apellido1,Apellido2,Genero,Id_Persona) Values('" + nombre + "','" + apellido1 + "','" + apellido2 + "'," + genero + "," + identificacion + ")");

            if (creadoPersona && creadoExtranjero && creadoProveedor)
            {
                return true;
            }
            return false;
        }

        public bool insertarJuridico (String descripcion, String nombre, int identificacion)
        {

            clsConexion conect = new clsConexion();
            bool creadoPersona, creadoJuridico, creadoProveedor;

            creadoPersona = conect.ejecutarInsert("INSERT INTO dbo.Persona(Activo,Id_Persona,Id_TipoPersona) values (1," + identificacion + ", 3)");
            creadoProveedor = conect.ejecutarInsert("INSERT INTO dbo.Proveedor(Activo,Descripcion,Id_Persona)Values(1,'" + descripcion + "'," + identificacion + ")");
            creadoJuridico = conect.ejecutarInsert("INSERT INTO dbo.Juridica(Descripcion, Nombre, Id_Persona) VALUES('" + descripcion + "','" + nombre + "'," + identificacion + ")");

            if (creadoPersona && creadoJuridico && creadoProveedor)
            {
                return true;
            }
            return false;
        }
    }
}
