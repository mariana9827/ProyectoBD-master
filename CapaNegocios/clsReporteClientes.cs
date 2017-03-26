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
    }
}
