using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Data;

namespace RegistroProductos
{
    public class ProductoDAO
    {
        public void InsertarProducto(Producto p)
        {
            Conexion con = new Conexion();
            using (SqlConnection cn = con.ObtenerConexion())
            {
                string sql = "INSERT INTO Productos(Nombre, Categoria, Precio, Stock) VALUES (@nombre, @categoria, @precio, @stock)";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@nombre",p.Nombre);
                cmd.Parameters.AddWithValue("@categoria", (object)p.Categoria ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@precio", p.Precio);
                cmd.Parameters.AddWithValue("@stock", p.Stock);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerProductos()
        {
            DataTable tabla = new DataTable();
            Conexion con = new Conexion();
            using (SqlConnection cn = con.ObtenerConexion())
            {
                string sql = "SELECT ID, Nombre, Categoria, Precio, Stock, FechaRegistro FROM Productos WHERE Estado = 1 ORDER BY ID DESC";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                da.Fill(tabla);
            }
            return tabla;

        }

        public void ActualizarProductos(Producto p)
        {
            Conexion con = new Conexion();
            using (SqlConnection cn = con.ObtenerConexion())
            {
                string sql = "UPDATE Productos SET Nombre = @nombre, Categoria = @categoria, Precio = @precio, Stock = @stock WHERE ID = @id";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@categoria", (object)p.Categoria ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@precio", p.Precio);
                cmd.Parameters.AddWithValue("@stock", p.Stock);
                cmd.Parameters.AddWithValue("@id", p.ID);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarProducto(int id)
        {
            Conexion con = new Conexion();
            using (SqlConnection cn = con.ObtenerConexion())
            {
                string sql = "UPDATE Productos SET Estado = 0 WHERE ID = @id";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", id);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            
        }
    }
}
