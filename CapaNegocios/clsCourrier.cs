using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocios
{
    public class clsCourrier
    {

        public bool insertarCourrier ( String nombre,int identificacion)
        {
        
            return new CapaDatos.clsCourrier().insertarCourrier(nombre,identificacion);
        }


        public DataTable LLenarTipoJuridico ()
        {
            CapaDatos.clsCourrier Juridico = new CapaDatos.clsCourrier();
            return Juridico.CargarDatosJuridicos();

        }
    }
}
