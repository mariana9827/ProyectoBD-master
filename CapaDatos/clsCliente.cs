using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsCliente
    {
        public bool insertarNacional (int identificacion, String nombre, String apellido1, String apellido2, int genero)
        {
          
            clsConexion conect = new clsConexion();
            bool creadoPersona, creadoNacional, creadoCliente;

            creadoPersona=conect.ejecutarInsert("INSERT INTO dbo.Persona(Activo,Id_Persona,Id_TipoPersona) values (1,"+identificacion+", 1)");
            creadoCliente= conect.ejecutarInsert("INSERT INTO dbo.Cliente(Id_Persona,Activo) Values("+identificacion+",1)");
            creadoNacional = conect.ejecutarInsert("INSERT INTO dbo.Nacional (Nombre,Apellido1,Apellido2,Genero,Id_Persona) Values('"+nombre+"','"+apellido1+"','"+apellido2+"',"+genero+","+identificacion+")");
             
            if (creadoPersona && creadoNacional && creadoCliente)
            {
                return true;
            }
            return false;
        }

        public bool insertarExtranjera (int identificacion, String nombre, String apellido1, String apellido2, int genero)
        {

            clsConexion conect = new clsConexion();
            bool creadoPersona, creadoExtranjero, creadoCliente;

            creadoPersona = conect.ejecutarInsert("INSERT INTO dbo.Persona(Activo,Id_Persona,Id_TipoPersona) values (1," + identificacion + ",2)");
            creadoCliente = conect.ejecutarInsert("INSERT INTO dbo.Cliente(Id_Persona,Activo) Values(" + identificacion + ",1)");
            creadoExtranjero= conect.ejecutarInsert("INSERT INTO dbo.Extranjera(Nombre,Apellido1,Apellido2,Genero,Id_Persona) Values('" + nombre + "','" + apellido1 + "','" + apellido2 + "'," + genero + "," + identificacion + ")");

            if (creadoPersona && creadoExtranjero && creadoCliente)
            {
                return true;
            }
            return false;
        }

        public bool insertarJuridico(String descripcion, String nombre, int identificacion)
        {

            clsConexion conect = new clsConexion();
            bool creadoPersona, creadoJuridico, creadoCliente;

            creadoPersona = conect.ejecutarInsert("INSERT INTO dbo.Persona(Activo,Id_Persona,Id_TipoPersona) values (1," + identificacion + ", 3)");
            creadoCliente = conect.ejecutarInsert("INSERT INTO dbo.Cliente(Id_Persona,Activo) Values(" + identificacion + ",1)");
            creadoJuridico = conect.ejecutarInsert("INSERT INTO dbo.Juridica(Descripcion, Nombre, Id_Persona) VALUES('" + descripcion + "','" + nombre + "'," + identificacion + ")");

            if (creadoPersona && creadoJuridico && creadoCliente)
            {
                return true;
            }
            return false;
        }
    }
}
 