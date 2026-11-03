using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroProductos
{
    public class FacturaDAO
    {
        public int GuardarFactura(int usuarioId, List<ItemFactura> items)
        {
            Conexion con = new Conexion();
            
            using (SqlConnection cn = con.ObtenerConexion())
            {
                cn.Open();
                SqlTransaction tr = cn.BeginTransaction();

                try
                {
                    int facturaId;
                    decimal total = items.Sum(i => i.SubTotal);
                    string sql = @"INSERT INTO Facturas (FechaYHora, UsuarioID, Total) 
                                    VALUES (@fechayhora, @usuarioId, @total); 
                                    SELECT CAST(SCOPE_IDENTITY() AS int);";

                    using(SqlCommand cmd = new SqlCommand(sql, cn, tr))
                    {
                        cmd.Parameters.AddWithValue("@fechayhora", DateTime.Now);
                        cmd.Parameters.AddWithValue("@usuarioId", usuarioId);
                        cmd.Parameters.AddWithValue("@total", total);
                        facturaId = (int)cmd.ExecuteScalar();


                        
                    }
                  
                    foreach(ItemFactura it in items)
                    {
                        string sqlDetalle = @"INSERT INTO DetalleFactura (FacturaID, ProductoID, Cantidad, Precio)
                                                VALUES (@facturaID, @productoID, @cantidad, @precio);

                                                 UPDATE Productos
                                                 SET Stock = Stock - @cantidad
                                                 WHERE ID = @productoID AND Stock >= @cantidad;";
                        

                        using (SqlCommand cmdDet = new SqlCommand (sqlDetalle, cn, tr))
                        {
                            cmdDet.Parameters.AddWithValue("@facturaID", facturaId);
                            cmdDet.Parameters.AddWithValue("@productoID", it.ProductoID);
                            cmdDet.Parameters.AddWithValue("@cantidad", it.Cantidad);
                            cmdDet.Parameters.AddWithValue("@precio", it.Precio);
                            int filas = cmdDet.ExecuteNonQuery();
                            
                            if (filas == 1)
                            {
                                throw new Exception("No hay stock suficiente.");
                            }
                        }
                    }
                    tr.Commit();
                    return facturaId;
                }
                catch
                {
                    tr.Rollback();
                    throw;
                }
                
            }
        }
    }
}
