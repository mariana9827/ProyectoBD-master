using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public  class clsDatosPersonales
    {
        public DataTable CargarPais ()
        {
            CapaDatos.clsDatosPersonales datos = new CapaDatos.clsDatosPersonales();
            return datos.pais();
        }
        public DataTable CargarTipoCorreo ()
        {
            CapaDatos.clsDatosPersonales datos = new CapaDatos.clsDatosPersonales();
            return datos.tipoCorreo();
        }
        public DataTable CargarTipoDireccion ()
        {
            CapaDatos.clsDatosPersonales datos = new CapaDatos.clsDatosPersonales();
            return datos.tipoDireccion();
        }
        public DataTable CargarTipoTelefono ()
        {
            CapaDatos.clsDatosPersonales datos = new CapaDatos.clsDatosPersonales();
            return datos.tipoTelefono();
        }
    }
}
