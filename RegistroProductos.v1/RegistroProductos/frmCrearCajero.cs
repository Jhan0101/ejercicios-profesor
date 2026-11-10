using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RegistroProductos
{
    public partial class frmCrearCajero : Form
    {
        private UsuarioSession session;
        public frmCrearCajero(UsuarioSession s)
        {
            InitializeComponent();
            Estilo.Aplicar(this);
            session = s;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (session == null || session.Rol != "Administrador")
            {
                MessageBox.Show("Acceso denegado.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                MessageBox.Show("Escriba el nombre del cajero.");
                txtNombreUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {

                MessageBox.Show("Escriba la clave.");
                txtClave.Focus();
                return;
            }

            if (txtClave.Text.Contains(" "))
            {
                MessageBox.Show("No se permiten espacios para la clave.");
                txtClave.Focus();
                return;
            }

            if (cmbTurno.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un turno.");
                cmbTurno.Focus();
                return;
            }

            Usuario nuevoUsuario = new Usuario();
            nuevoUsuario.NombreUsuario = txtNombreUsuario.Text.Trim();
            nuevoUsuario.ClaveHash = Seguridad.GenerarHash(txtClave.Text);
            nuevoUsuario.Rol = "Cajero";
            nuevoUsuario.Turno = cmbTurno.Text;

            try
            {
                UsuarioDAO dao = new UsuarioDAO();
                dao.CrearUsuario(nuevoUsuario);
                MessageBox.Show("Cajero creado correctamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido crear al cajero: " +  ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtNombreUsuario.Clear();
            txtClave.Clear();
            cmbTurno.SelectedIndex = -1;
            txtNombreUsuario.Focus();
        }
    }
}
