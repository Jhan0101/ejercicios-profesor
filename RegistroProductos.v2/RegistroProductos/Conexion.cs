using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace RegistroProductos
{
    public class Conexion
    {
        private string cadenaConexion = @"Data source=DESKTOP-JGD1NGD\SQLEXPRESS; Initial Catalog=RegistroProductos; Integrated Security=True; TrustServerCertificate=True";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
