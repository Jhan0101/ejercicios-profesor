using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RegistroProductos
{
    public partial class frmCLientes : Form
    {
        public frmCLientes()
        {
            InitializeComponent();
        }

        private void frmCLientes_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del cliente.");
                txtNombre.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Ingrese el telefono del cliente.");
                txtTelefono.Focus();
                return;
            }
            if (txtTelefono.Text.Contains(" "))
            {
                MessageBox.Show("Ingrese el numero sin espacios.");
                txtTelefono.Focus();
                return;
            }

            Cliente cliente = new Cliente();
            cliente.Nombre = txtNombre.Text.Trim();
            cliente.Telefono = txtTelefono.Text.Trim();

            try
            {
                ClienteDAO dao = new ClienteDAO();
                dao.CrearCliente(cliente);
                MessageBox.Show("Cliente creado con exito.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar el cliente: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtNombre.Focus();
        }
    }


}
