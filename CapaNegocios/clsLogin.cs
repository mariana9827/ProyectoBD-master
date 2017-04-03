using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocios
{
    public class clsLogin
    {
     public DataTable login(String user, String password)
        {
            return new CapaDatos.clsLogin().CargarDatos(user,password);
        }
    }
}
