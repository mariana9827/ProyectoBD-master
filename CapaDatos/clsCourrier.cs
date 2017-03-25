using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsCourrier
    {
        public bool insertarCourrier (String descripcion, int identificacion)
        {
            clsConexion conect = new clsConexion();
            return conect.ejecutarInsert("INSERT INTO dbo.Currier(Activo, Descripcion, Id_Persona)VALUES(1,'" + descripcion + "'," + identificacion + ")");
        }

        public DataTable CargarDatosJuridicos ()
        {
            CapaDatos.clsConexion conexion = new CapaDatos.clsConexion();
            DataTable dtJuridico;
            dtJuridico = conexion.ejecutar("SELECT Descripcion, Nombre, Id_Persona FROM dbo.Juridica");
            return dtJuridico;
        }
    }
}
