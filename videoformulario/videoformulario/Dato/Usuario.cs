using System;
using System.Collections.Generic;
using System.Text;
using videoformulario.Modelo;

namespace videoformulario.Dato
{
    public class Usuario
    {
        List<UsuarioModel> lista = new List<UsuarioModel>();

        public void Guardar(UsuarioModel usuario)
        {
            lista.Add(usuario);
        }

        public List<UsuarioModel> Consultar()
        {
            return lista;
        }
    }
}
