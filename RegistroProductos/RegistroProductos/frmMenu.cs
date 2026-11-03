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

        public frmMenu(UsuarioSession s)
        {
            InitializeComponent();
            sesion = s;
            AplicarPermisos();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            using (frmRegistroProducto f = new frmRegistroProducto())
            {
                f.ShowDialog();
            }
            
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            using(frmFactura f = new frmFactura(sesion.UsuarioID))
            {
                f.ShowDialog();
            }
        }

        private void AplicarPermisos()
        {
            btnProductos.Visible = false;
            btnFacturas.Visible = false;

            if(sesion.Rol == "Administrador")
            {
                btnProductos.Visible = true;
                btnFacturas.Visible = true;
            }
            else if(sesion.Rol == "Cajero")
            {
                btnFacturas.Visible = true;
            }
        }
    }
}
