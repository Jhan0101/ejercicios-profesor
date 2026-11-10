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
                string sql = "SELECT ID, NombreUsuario, Rol, Turno FROM Usuarios WHERE NombreUsuario = @usuario AND ClaveHash = @hash";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@hash", hash);

                    cn.Open();

                   using(SqlDataReader dr = cmd.ExecuteReader())
                    {
                       
                        if (dr.Read())
                        {
                            return new UsuarioSession { UsuarioID = dr.GetInt32(0),NombreUsuario = dr.GetString(1), Rol = dr.GetString(2), Turno = dr.GetString(3) };
                          
                        }
                    }
                }
            }
            return null;
        }

        public void CrearUsuario(Usuario usuario)
        {
            Conexion con = new Conexion();
            using(SqlConnection cn = con.ObtenerConexion())
            {
                string sql = "INSERT INTO Usuarios(NombreUsuario, ClaveHash, Rol, Turno) VALUES (@nombreUsuario, @claveHash, @rol, @turno)";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                { 
                    cmd.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);
                    cmd.Parameters.AddWithValue("@claveHash", usuario.ClaveHash);
                    cmd.Parameters.AddWithValue("@rol", usuario.Rol);
                    cmd.Parameters.AddWithValue("@turno", usuario.Turno);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
