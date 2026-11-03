using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Data;

namespace RegistroProductos
{
    public class UsuarioDAO
    {
        public UsuarioSession ValidarUsuario(string usuario, string hash)
        {

            Conexion con = new Conexion();
            using (SqlConnection cn = con.ObtenerConexion())
            {
                string sql = "SELECT ID, Rol FROM Usuarios WHERE NombreUsuario = @usuario AND ClaveHash = @hash";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@hash", hash);

                    cn.Open();

                   using(SqlDataReader dr = cmd.ExecuteReader())
                    {
                       
                        if (dr.Read())
                        {
                            return new UsuarioSession { UsuarioID = dr.GetInt32(0),Rol = dr.GetString(1) };
                          
                        }
                    }
                }
            }
            return null;
        }

    }
}
