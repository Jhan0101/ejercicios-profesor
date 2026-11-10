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
                string sql = "INSERT INTO Productos(Codigo, Nombre, Categoria, Precio, Stock, LlevaItbis) VALUES (@codigo, @nombre, @categoria, @precio, @stock, @itbis)";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@codigo", p.Codigo);
                cmd.Parameters.AddWithValue("@nombre",p.Nombre);
                cmd.Parameters.AddWithValue("@categoria", (object)p.Categoria ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@precio", p.Precio);
                cmd.Parameters.AddWithValue("@stock", p.Stock);
                cmd.Parameters.AddWithValue("@itbis", p.LlevaItbis);

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
                string sql = "SELECT ID, Codigo, Nombre, Categoria, Precio, Stock, FechaRegistro, LlevaItbis FROM Productos WHERE Estado = 1 ORDER BY ID DESC";
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
                string sql = "UPDATE Productos SET Codigo = @codigo, Nombre = @nombre, Categoria = @categoria, Precio = @precio, Stock = @stock, LlevaItbis = @itbis WHERE ID = @id";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@codigo", p.Codigo);
                cmd.Parameters.AddWithValue("@nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@categoria", (object)p.Categoria ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@precio", p.Precio);
                cmd.Parameters.AddWithValue("@stock", p.Stock);
                cmd.Parameters.AddWithValue("@id", p.ID);
                cmd.Parameters.AddWithValue("@itbis", p.LlevaItbis);

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

        public static bool ComprobarCodigo(string codigo, int idExluir = 0)
        {
            Conexion con = new Conexion();
            using(SqlConnection cn = con.ObtenerConexion())
            {
                string sql = "SELECT COUNT(*) FROM Productos WHERE Codigo = @codigo AND ID <> @id";
                using(SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@id", idExluir);
                    cn.Open();
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        public Producto BuscarPorCodigo(string codigo)
        {
            
            Conexion con = new Conexion();
            using(SqlConnection cn = con.ObtenerConexion())
            {
                string sql = "SELECT ID, Codigo, Nombre, Precio, Stock, LlevaItbis FROM Productos WHERE Codigo = @codigo AND Estado = 1";
                using(SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        if (dr.Read())
                        {
                            Producto p = new Producto();
                            p.ID = dr.GetInt32(0);
                            p.Codigo = dr.GetString(1);
                            p.Nombre = dr.GetString(2);
                            p.Precio = dr.GetDecimal(3);
                            p.Stock = dr.GetInt32(4);
                            p.LlevaItbis = dr.GetBoolean(5);
                            return p;
                        }
                    }
                }
            }

            return null;
        }
    }
}
