using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocios
{
   public class clsReporteProductos
    {
        public DataTable llenarDTGProductos ()
        {
            CapaDatos.clsReportesProductos reporteProductos= new CapaDatos.clsReportesProductos();
            return reporteProductos.cargarProductos();
        }
    }
}
