using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaDatos
{
    public class clsLogin
    {
        public DataTable CargarDatos ()
        {
            CapaDatos.clsConexion conexion = new clsConexion();
            DataTable dtUsarios;

            dtUsarios = conexion.ejecutar("Select Usuario, Contraseña FROM dbo.Administrador");
            return dtUsarios;
        }
    }
}
