using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroProductos
{
    public class UsuarioSession
    {
        public int UsuarioID { get; set; }
        public string NombreUsuario { get; set; }
        public string Rol { get; set; }
        public string Turno { get; set; }
    }
}
