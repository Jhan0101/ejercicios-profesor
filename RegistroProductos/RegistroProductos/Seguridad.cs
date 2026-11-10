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

        public static bool EstaEnTurno(string turno, TimeSpan hora)
        {
            if (turno == "Dia")
            {
                return hora >= new TimeSpan(6, 0, 0) && hora < new TimeSpan(14, 0, 0);
            }
            if (turno == "Tarde")
            {
                return hora >= new TimeSpan(14, 0, 0) && hora < new TimeSpan(22, 0, 0);
            }
            if (turno == "Noche")
            {
                return hora >= new TimeSpan(22, 0, 0) || hora < new TimeSpan(6, 0, 0);
            }
            return false;
        }
    }
}
