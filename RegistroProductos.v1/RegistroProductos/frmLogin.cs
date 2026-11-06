using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RegistroProductos
{
    public partial class frmLogin : Form
    {
        public UsuarioSession Sesion { get; private set; }
        public frmLogin()
        {
            InitializeComponent();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text;

            string hash = Seguridad.GenerarHash(clave);

            UsuarioDAO dao = new UsuarioDAO();
            UsuarioSession session = dao.ValidarUsuario(usuario, hash);

            if (session == null)
            {
                MessageBox.Show("Usuario o clave incorrecta.");
            }
            else
            {
                if (session.Rol == "Cajero" && !Seguridad.EstaEnTurno(session.Turno, DateTime.Now.TimeOfDay))
                {
                    MessageBox.Show("No puede ingresar fuera de turno.");
                    return;
                }
                Sesion = session;
                this.DialogResult = DialogResult.OK;
            }

        }

        private void pnlTarjeta_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
