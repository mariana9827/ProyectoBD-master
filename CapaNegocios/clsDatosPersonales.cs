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

        public bool insertaDireccion (int pais, String nombre,int codpostal, String desc, int identificacion,int tipodire)
        {
            return new CapaDatos.clsDatosPersonales().insertarDireccion(pais,nombre,codpostal,desc,identificacion,tipodire);
        }
    }
}
