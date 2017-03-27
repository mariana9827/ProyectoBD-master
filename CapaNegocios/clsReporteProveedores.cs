using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class clsReporteProveedores
    {
        public DataTable llenarDTGProveedores ()
        {
            CapaDatos.clsReporteProveedores reporteProveedores = new CapaDatos.clsReporteProveedores();
            return reporteProveedores.cargarProveedores();
        }
        public DataTable llenarDTGProveedoresNac ()
        {
            CapaDatos.clsReporteProveedores reporteProveedoresNac = new CapaDatos.clsReporteProveedores();
            return reporteProveedoresNac.cargarProveedoresNacionales();
        }

        public DataTable llenarDTGProveedoresExt ()
        {
            CapaDatos.clsReporteProveedores reporteProveedoresExt = new CapaDatos.clsReporteProveedores();
            return reporteProveedoresExt.cargarProveedoresExtranjeros();
        }
        public DataTable llenarDTGProveedoresJur ()
        {
            CapaDatos.clsReporteProveedores reporteProveedoresJur = new CapaDatos.clsReporteProveedores();
            return reporteProveedoresJur.cargarProveedoresJuridicos();
        }
    }
}
