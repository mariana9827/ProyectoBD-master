using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsPaquetes
    {
        CapaDatos.clsConexion conect = new CapaDatos.clsConexion();

        public bool insertarPaquete (float peso, int identificacion, int direccion, int producto, String estado)
        {
            return conect.ejecutarInsert("INSERT INTO dbo.Paquetes (Activo,Peso,Id_Persona,Id_Direccion,Id_Producto,Estado)Value(1,"+peso+","+identificacion+","+direccion+","+producto+",'"+estado+"')");
        }

    }
}
