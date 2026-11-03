using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace RegistroProductos
{
    public class Seguridad
    {

        public static string GenerarHash(string clave)
        {
            byte[] bt1 = Encoding.UTF8.GetBytes(clave);
            byte[] bt2 = SHA256.HashData(bt1);

            return Convert.ToHexString(bt2);
        }
    }
}
