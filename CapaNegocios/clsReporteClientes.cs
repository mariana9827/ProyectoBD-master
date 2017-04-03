using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocios
{
    public class clsReporteClientes
    {
        CapaDatos.clsrReporteClientes reporteClientes = new CapaDatos.clsrReporteClientes();

        public DataTable llenarDTGClientes ()
        {
            return reporteClientes.cargarClientes();
        }
        public DataTable llenarDTGClientesNac ()
        {
            return reporteClientes.cargarClientesNacionales();
        }

        public DataTable llenarDTGClientesExt ()
        {
            return reporteClientes.cargarClientesExtranjeros();
        }
        public DataTable llenarDTGClientesJur ()
        { 
            return reporteClientes.cargarClientesJuridicos();
        }
    }
}
