using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class clsJuridico
    {

        public bool insertarJuridico(String descripcion, int identificacion, String nombre)
        {
            return new CapaDatos.clsJuridico().insertarJuridico(descripcion,nombre,identificacion);
        }
    }
}
