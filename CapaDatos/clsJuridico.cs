using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class clsJuridico
    {
        clsConexion conect = new clsConexion();

  
        public bool insertarJuridico (String descripcion, String nombre, int identificacion)
        {
            bool creadoPersona, creadoJuridico;

            creadoPersona = conect.ejecutarInsert("INSERT INTO dbo.Persona(Activo,Id_Persona,Id_TipoPersona) values (1," + identificacion + ", 3)");
            creadoJuridico = conect.ejecutarInsert("INSERT INTO dbo.Juridica(Descripcion, Nombre, Id_Persona) VALUES('" + descripcion + "','" + nombre + "'," + identificacion + ")");

            if (creadoPersona && creadoJuridico)
            {
                return true;
            }
            return false;
        }



    }
}
