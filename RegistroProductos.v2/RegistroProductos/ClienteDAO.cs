using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace RegistroProductos
{
    public class ClienteDAO
    {
        public void CrearCliente(Cliente c)
        {
            Conexion con = new Conexion();
            using(SqlConnection cn = con.ObtenerConexion())
            {
                string sql = "INSERT INTO Clientes ( Nombre, Telefono) VALUES ( @nombre, @telefono)";
                using(SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    
                    cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                    cmd.Parameters.AddWithValue("@telefono", c.Telefono);
                    

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }


        }

        public DataTable ObtenerClientes()
        {
            DataTable tabla = new DataTable();
            Conexion con = new Conexion();
            using(SqlConnection cn = con.ObtenerConexion())
            {
                string sql = "SELECT ID, Nombre, Telefono FROM Clientes WHERE Estado = 1 ORDER BY Nombre";
                using (SqlDataAdapter da = new SqlDataAdapter(sql, cn))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }
    }
}

