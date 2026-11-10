using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RegistroProductos
{
    public partial class frmMenu : Form
    {
        private readonly UsuarioSession sesion;
        frmLogin login = new frmLogin();


        public frmMenu(UsuarioSession s)
        {
            InitializeComponent();
            Estilo.Aplicar(this);
            sesion = s;
            AplicarPermisos();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            using (frmRegistroProducto f = new frmRegistroProducto(sesion))
            {
                f.ShowDialog();
            }

        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            using (frmFactura f = new frmFactura(sesion))
            {
                f.ShowDialog();
            }
        }

        private void AplicarPermisos()
        {
            btnProductos.Visible = false;
            btnFacturas.Visible = false;
            btnCrearCajero.Visible = false;
            btnReportes.Visible = false;

            if (sesion.Rol == "Administrador")
            {
                btnProductos.Visible = true;
                btnFacturas.Visible = true;
                btnCrearCajero.Visible = true;
                btnReportes.Visible = true;
            }
            else if (sesion.Rol == "Cajero")
            {
                btnFacturas.Visible = true;
                btnProductos.Visible = true;
            }
        }

        private void btnCrearCajero_Click(object sender, EventArgs e)
        {
            using (frmCrearCajero f = new frmCrearCajero(sesion))
            {
                f.ShowDialog();
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            using(frmReportes f = new frmReportes())
            {
                f.ShowDialog();
            }
        }
    }
}
