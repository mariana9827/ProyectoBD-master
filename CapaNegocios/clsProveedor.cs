using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
   public class clsProveedor
    {
  
        public bool insertarNacional (int identificacion, string nombre, string apellido1, string apellido2, bool genero,String descripcion)
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
            return new CapaDatos.clsProveedor().insertarNacional(identificacion, nombre, apellido1, apellido2, genre,descripcion);
        }

        public bool insertarExtranjera (int identificacion, string nombre, string apellido1, string apellido2, bool genero, String descripcion)
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
            return new CapaDatos.clsProveedor().insertarExtranjera(identificacion, nombre, apellido1, apellido2, genre,descripcion);
        }

        public bool insertarJuridico (String descripcion, String nombre, int identificacion)
        {
            return new CapaDatos.clsProveedor().insertarJuridico(descripcion,nombre,identificacion);
        }
    }
} 
