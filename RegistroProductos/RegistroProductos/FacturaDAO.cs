using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroProductos
{
    public class FacturaDAO
    {
        public int GuardarFactura(Factura factura)
        {
            Conexion con = new Conexion();
            
            using (SqlConnection cn = con.ObtenerConexion())
            {
                cn.Open();
                SqlTransaction tr = cn.BeginTransaction();

                try
                {
                    int facturaId;
                    decimal totalBruto = factura.Items.Sum(i => i.SubTotal);
                    decimal totalItbis = factura.Items.Sum(i => i.Itbis);
                    decimal total = totalBruto + totalItbis;

                    string sql = @"INSERT INTO Facturas (FechaYHora, UsuarioID, TotalBruto, TotalItbis, Total, TipoPago, MontoPagado, Devuelta, ClienteID) 
                                    VALUES (@fechayhora, @usuarioId, @totalbruto, @totalitbis, @total, @tipoPago, @montoPagado, @devuelta, @clienteId); 
                                    SELECT CAST(SCOPE_IDENTITY() AS int);";

                    using(SqlCommand cmd = new SqlCommand(sql, cn, tr))
                    {
                        cmd.Parameters.AddWithValue("@fechayhora", DateTime.Now);
                        cmd.Parameters.AddWithValue("@usuarioId", factura.UsuarioId);
                        cmd.Parameters.AddWithValue("@totalbruto", totalBruto);
                        cmd.Parameters.AddWithValue("@totalitbis", totalItbis);
                        cmd.Parameters.AddWithValue("@total", total);
                        cmd.Parameters.AddWithValue("@tipoPago", factura.TipoPago);
                        cmd.Parameters.AddWithValue("@montoPagado", factura.MontoPagado);
                        cmd.Parameters.AddWithValue("@devuelta", factura.Devuelta);
                        cmd.Parameters.AddWithValue("@clienteId", factura.ClienteID.HasValue ? (Object)factura.ClienteID.Value : DBNull.Value);
                        facturaId = (int)cmd.ExecuteScalar();


                        
                    }
                  
                    foreach(ItemFactura it in factura.Items)
                    {
                        string sqlDetalle = @"INSERT INTO DetalleFactura (FacturaID, ProductoID, Cantidad, Precio, Itbis)
                                                VALUES (@facturaID, @productoID, @cantidad, @precio, @itbis);

                                                 UPDATE Productos
                                                 SET Stock = Stock - @cantidad
                                                 WHERE ID = @productoID AND Stock >= @cantidad;";
                        

                        using (SqlCommand cmdDet = new SqlCommand (sqlDetalle, cn, tr))
                        {
                            cmdDet.Parameters.AddWithValue("@facturaID", facturaId);
                            cmdDet.Parameters.AddWithValue("@productoID", it.ProductoID);
                            cmdDet.Parameters.AddWithValue("@cantidad", it.Cantidad);
                            cmdDet.Parameters.AddWithValue("@precio", it.Precio);
                            cmdDet.Parameters.AddWithValue("@itbis", it.Itbis);
                            int filas = cmdDet.ExecuteNonQuery();
                            
                            if (filas == 1)
                            {
                                throw new Exception("No hay stock suficiente.");
                            }
                        }
                    }

                    if (factura.TipoPago == "Credito")
                    {
                        string sqlCuentas = "INSERT INTO CuentasPorCobrar (FacturaID, Saldo) VALUES (@facturaId, @saldo)";
                        using(SqlCommand cmdCu = new SqlCommand(sqlCuentas, cn, tr))
                        {
                            cmdCu.Parameters.AddWithValue("@facturaId", facturaId);
                            cmdCu.Parameters.AddWithValue("@saldo", total);
                            cmdCu.ExecuteNonQuery();
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
