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
        public DataTable llenarDTGClientes ()
        {
            CapaDatos.clsrReporteClientes reporteClientes = new CapaDatos.clsrReporteClientes();
            return reporteClientes.cargarClientes();
        }
        public DataTable llenarDTGClientesNac ()
        {
            CapaDatos.clsrReporteClientes reporteClientesNac = new CapaDatos.clsrReporteClientes();
            return reporteClientesNac.cargarClientesNacionales();
        }

        public DataTable llenarDTGClientesExt ()
        {
            CapaDatos.clsrReporteClientes reporteClientesExt = new CapaDatos.clsrReporteClientes();
            return reporteClientesExt.cargarClientesExtranjeros();
        }
        public DataTable llenarDTGClientesJur ()
        {
            CapaDatos.clsrReporteClientes reporteClientesJur = new CapaDatos.clsrReporteClientes();
            return reporteClientesJur.cargarClientesJuridicos();
        }
    }
}
