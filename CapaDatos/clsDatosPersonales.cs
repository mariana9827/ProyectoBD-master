using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;

namespace CapaDatos
{
   public class clsDatosPersonales
    {
        CapaDatos.clsConexion conexion = new CapaDatos.clsConexion();

        public DataTable pais ()
        {
            DataTable dtPais;
            dtPais = conexion.ejecutar("select Id_Pais, Nombre from dbo.Pais");
            return dtPais;
        }
        public DataTable tipoCorreo ()
        {
            DataTable dtCorreo;
            dtCorreo= conexion.ejecutar("SELECT Id_tipoco,Descripcion FROM dbo.Tipo_Correo");
            return dtCorreo;
        }

        public DataTable tipoDireccion ()
        {
            DataTable dtAdress;
            dtAdress= conexion.ejecutar("SELECT Id_TipoDireccion,Descripcion FROM dbo.Tipo_Direccion");
            return dtAdress;
        }

        public DataTable tipoTelefono ()
        {
            DataTable dtTel;
            dtTel = conexion.ejecutar("SELECT Id_tipotel,Descripcion FROM dbo.Tipo_tel");
            return dtTel;
        }

        public bool insertarDireccion (int pais, String nombre,int codpostal,String desc,int identificacion,int tipodir)
        {
            bool creadoProvincia, creadoDireccion;

            creadoProvincia = conexion.ejecutarInsert("INSERT INTO dbo.Provincia(Nombre, Id_Pais)Values('"+nombre+"',"+pais+")");
            creadoDireccion = conexion.ejecutarInsert("INSERT INTO dbo.Direccion(Id_Provincia,Id_Pais,Id_TipoDireccion,CodPostal,Descripcion,Activo,Id_Persona)VALUES(IDENT_Current('dbo.Provincia'),"+pais+","+tipodir+","+codpostal+","+desc+",1,"+identificacion+")");

            if (creadoProvincia && creadoDireccion)
            { 
                return true;
            }
            return false;
          
        }


    }
}
