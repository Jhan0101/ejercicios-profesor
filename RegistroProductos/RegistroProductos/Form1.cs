using System.Drawing.Text;

namespace RegistroProductos
{
    public partial class Form1 : Form
    {
        private int idSeleccionado = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Escriba un nombre para el producto.");
                txtNombre.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio valido mayor a cero.");
                txtPrecio.Focus();
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Ingrese un numero de stock mayor o igual a cero.");
                txtStock.Focus();
                return;
            }

            try
            {
                Producto p = new Producto();
                p.Nombre = txtNombre.Text.Trim();
                p.Categoria = string.IsNullOrWhiteSpace(txtCategoria.Text) ? null : txtCategoria.Text.Trim();
                p.Precio = precio;
                p.Stock = stock;

                ProductoDAO dao = new ProductoDAO();
                dao.InsertarProducto(p);
                MessageBox.Show("Producto guardado.");
                LimpiarCampos();
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar: " + ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtCategoria.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtNombre.Focus();
            idSeleccionado = 0;
        }

        private void CargarProductos()
        {
            ProductoDAO dao = new ProductoDAO();
            dgvProductos.DataSource = dao.ObtenerProductos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
            if (fila.IsNewRow) return;

            idSeleccionado = Convert.ToInt32(fila.Cells["ID"].Value);
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtCategoria.Text = fila.Cells["Categoria"].Value.ToString();
            txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
            txtStock.Text = fila.Cells["Stock"].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("No ha seleccionado ninguna fila.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Escriba un nombre para el producto.");
                txtNombre.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio valido mayor a cero.");
                txtPrecio.Focus();
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Ingrese un numero de stock mayor o igual a cero.");
                txtStock.Focus();
                return;
            }

            try
            {
                Producto p = new Producto();
                p.Nombre = txtNombre.Text.Trim();
                p.Categoria = string.IsNullOrWhiteSpace(txtCategoria.Text) ? null : txtCategoria.Text.Trim();
                p.Precio = precio;
                p.Stock = stock;
                p.ID = idSeleccionado;

                ProductoDAO dao = new ProductoDAO();
                dao.ActualizarProductos(p);

                MessageBox.Show("Producto actualizado.");
                LimpiarCampos();
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar el producto: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto de la lista.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "Seguro que desea eliminar el producto " + txtNombre.Text + "?",
                "Confirmar.", 
                MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.No) return;

            try
            {
                ProductoDAO dao = new ProductoDAO();
                dao.EliminarProducto(idSeleccionado);

                MessageBox.Show("Producto eliminado.");
                LimpiarCampos();
                CargarProductos();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el producto: " + ex.Message);
            }
        }
    }
}
