using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;

namespace RegistroProductos
{
    public class ReporteDAO
    {
        public DataTable ObtenerCuadreDia(DateTime fecha)
        {
            DataTable tabla = new DataTable();
            Conexion con = new Conexion();

            using(SqlConnection cn = con.ObtenerConexion())
            {
                string sql = @"SELECT 
                                    COUNT(*) AS CantidadFacturas,
                                    COALESCE(SUM(
                                        CASE WHEN TipoPago = 'Contado' THEN Total ELSE 0 END
                                    ), 0) AS TotalContado,
                                    COALESCE(SUM(
                                        CASE WHEN TipoPago = 'Credito' THEN Total ELSE 0 END
                                    ), 0) AS TotalCredito,
                                    COALESCE(SUM(Total), 0) AS TotalVendido
                                    FROM Facturas
                                    WHERE FechaYHora >= @fecha
                                        AND FechaYHora < DATEADD(DAY, 1, @fecha)";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha.Date;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
            }
            return tabla;
        }

        public DataTable ObtenerVentaPorCajero(DateTime fecha)
        {
            DataTable tabla = new DataTable();
            Conexion con = new Conexion();

            using (SqlConnection cn = con.ObtenerConexion())
            {
                string sql = @"SELECT u.NombreUsuario, SUM(f.Total) AS TotalVendido,COUNT(*) AS CantidadFacturas   
                                FROM Facturas f 
                                INNER JOIN  Usuarios u ON f.UsuarioID = u.ID
                                WHERE f.FechaYHora >= @fecha 
                                AND f.FechaYHora < DATEADD(DAY, 1, @fecha)
                                GROUP BY u.ID, u.NombreUsuario";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha.Date;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
            }
            return tabla;
        }

        public DataTable ObtenerInventarioStock()
        {
            DataTable tabla = new DataTable();
            Conexion con = new Conexion();
            using (SqlConnection cn  = con.ObtenerConexion())
            {
                string sql = @"SELECT Codigo, Nombre, Precio, Stock 
                               FROM Productos WHERE Estado = 1 AND Stock > 0
                               ORDER BY Nombre";
                using(SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    using(SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
            }
            return tabla;
        }

        public DataTable ObtenerFacturasPorTipoPago(DateTime fecha, string tipoPago)
        {
            DataTable tabla = new DataTable();
            Conexion con = new Conexion();
            
            using (SqlConnection cn = con.ObtenerConexion())
            {
                string sql = @"SELECT ID, FechaYHora, TipoPago, Total
                               FROM Facturas
                               WHERE FechaYHora>= @fecha
                               AND FechaYHora < DATEADD(DAY, 1, @fecha)
                               AND TipoPago = @tipoPago
                               ORDER BY FechaYHora, ID;";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha.Date;
                    cmd.Parameters.Add("@tipoPago", SqlDbType.VarChar, 20).Value = tipoPago;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
            }
            return tabla;
        }

        public DataTable ObtenerTopClientes()
        {
            DataTable tabla = new DataTable();
            Conexion con = new Conexion();

            using (SqlConnection cn = con.ObtenerConexion())
            {
                string sql = @"SELECT TOP 5 c.ID, c.Nombre, SUM(f.Total) AS TotalComprado
                               FROM Clientes c
                               INNER JOIN Facturas f ON c.ID = f.ClienteID
                               GROUP BY c.ID, c.Nombre
                               ORDER BY TotalComprado DESC";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
            }
            return tabla;
        }
    }
}
