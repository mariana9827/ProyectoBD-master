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
        public DataTable CargarDatos (String user, String password)
        {
            CapaDatos.clsConexion conexion = new clsConexion();
            DataTable dtUsarios;

            dtUsarios = conexion.ejecutar("Select Usuario from dbo.Administrador where Usuario='"+user+"' and Contraseña='"+password+"'");
            return dtUsarios;
        }
    }
}
