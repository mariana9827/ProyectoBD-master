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

        public DataTable cargarClientes ()
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtClientes;
            dtClientes = conecta.ejecutar("SELECT Id_Persona as Identificación, Activo as Activo from dbo.Cliente");
            return dtClientes;
        }


        public DataTable cargarClientesNacionales()
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtClientesNac;
            dtClientesNac = conecta.ejecutar("Select N.Nombre, N.Apellido1, N.Apellido2, N.Genero, N.Id_Persona From dbo.Nacional N Inner Join dbo.Cliente P on N.Id_Persona=P.Id_Persona");
            return dtClientesNac;
        }

        public DataTable cargarClientesExtranjeros ()
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtClientesExt;
            dtClientesExt = conecta.ejecutar("Select E.Nombre, E.Apellido1 as '1er Apellido', E.Apellido2 as '2do Apellido', E.Genero, E.Id_Persona as Identificación From dbo.Extranjera E Inner Join dbo.Cliente P on E.Id_Persona=P.Id_Persona");
            return dtClientesExt;
        }

        public DataTable cargarClientesJuridicos ()
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtClientesExt;
            dtClientesExt = conecta.ejecutar("Select J.Id_Persona as Identificación, j.Nombre as Nombre, J.Descripcion as Descripción From dbo.Juridica J Inner Join dbo.Cliente P on J.Id_Persona=P.Id_Persona");
            return dtClientesExt;
        }
    }
}
