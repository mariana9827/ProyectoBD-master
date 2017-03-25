﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
   public class clsProducto
    {
        public DataTable cargarCategorias ()
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtCategoria;
            dtCategoria = conecta.ejecutar("SELECT Id_Tipo, Categoria FROM dbo.Tipo_Producto");
            return dtCategoria;
        }

        public bool insertarProductos (int codigo, float precio, float peso, float costo, String nombre, int tipo, String medida)
        {
            CapaDatos.clsConexion conexion = new CapaDatos.clsConexion();
            return conexion.ejecutarInsert("INSERT INTO dbo.Producto(Id_Producto,Activo,Precio,Peso,Costo,Nombre,Id_Tipo,Medida)VALUES("+codigo+",1,"+precio+ "," + peso + "," + costo + ",'"+nombre+"',"+tipo+",'"+medida+"')");
        }
    }
}
