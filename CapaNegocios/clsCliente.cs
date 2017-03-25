using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class clsCliente
    {
        public bool insertarNacional (int identificacion, string nombre, string apellido1, string apellido2, bool genero)
        {
            int genre;

            if (genero)
            {
                genre = 1;
            }
            else
            {
                genre = 0;
            }
            return new CapaDatos.clsCliente().insertarNacional(identificacion, nombre, apellido1, apellido2,genre);
        }

        public bool insertarExtranjera(int identificacion, string nombre, string apellido1, string apellido2, bool genero)
        {
            int genre;

            if (genero)
            {
                genre = 1;
            }
            else
            {
                genre = 0;
            }
            return new CapaDatos.clsCliente().insertarExtranjera(identificacion, nombre, apellido1, apellido2, genre);
        }

        public bool insertarJuridico (String descripcion, String nombre, int identificacion)
        {
            return new CapaDatos.clsCliente().insertarJuridico(descripcion,nombre,identificacion);
        }
    }
}
