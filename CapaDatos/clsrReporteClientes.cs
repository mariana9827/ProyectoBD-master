using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsrReporteClientes
    {

        public DataTable cargarClientes()
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtClientes;
            dtClientes= conecta.ejecutar("SELECT Id_Person as Identificación, Activo as Activo from dbo.Cliente");
            return dtClientes;
        }
    }
}
