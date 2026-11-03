using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Globalization;
using System.IO;

namespace RegistroProductos
{
    public partial class frmFactura : Form
    {
        private BindingList<ItemFactura> carrito = new BindingList<ItemFactura>();
        private int usuarioId;
        private List<ItemFactura> venta;
        private int numeroFactura;
        private DateTime fechaVenta;

        public frmFactura(int idUsuario)
        {
            InitializeComponent();
            usuarioId = idUsuario;

            dgvCarrito.DataSource = carrito;

            if (dgvCarrito.Columns.Contains("ProductoID"))
            {
                dgvCarrito.Columns["ProductoID"].Visible = false;
            }

            ActualizarTotal();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Escriba el codigo del producto.");
                txtCodigo.Focus();
                return;
            }

            ProductoDAO dao = new ProductoDAO();
            Producto p = dao.BuscarPorCodigo(txtCodigo.Text.Trim());

            if (p == null)
            {
                MessageBox.Show("Producto no encontrado.");
                txtCodigo.Focus();
                return;
            }

            ItemFactura existente = carrito.FirstOrDefault(x => x.ProductoID == p.ID);

            int tiene = 0;
            int cantidadNueva = (int)nuCantidad.Value;

            if (existente != null)
            {
                tiene = existente.Cantidad;
            }

            int totalQueda = tiene + cantidadNueva;

            if (totalQueda > p.Stock)
            {
                MessageBox.Show($"Lleva {tiene}. Quedan {p.Stock - tiene} disponibles.");
                return;
            }

            if (existente != null)
            {
                existente.Cantidad += cantidadNueva;
                carrito.ResetBindings();
            }
            else
            {
                ItemFactura item = new ItemFactura();
                item.ProductoID = p.ID;
                item.Codigo = p.Codigo;
                item.Nombre = p.Nombre;
                item.Precio = p.Precio;
                item.Cantidad = (int)nuCantidad.Value;

                carrito.Add(item);
            }


            txtCodigo.Clear();
            nuCantidad.Value = 1;
            txtCodigo.Focus();
            ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            decimal total = carrito.Sum(c => c.SubTotal);
            lblTotal.Text = total.ToString("C2", new CultureInfo("es-DO"));
            carrito.ResetBindings();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (carrito.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto.");
                return;
            }
            try
            {
                FacturaDAO dao = new FacturaDAO();
                int id = dao.GuardarFactura(usuarioId, carrito.ToList());
                MessageBox.Show($"Factura guardada.");
                numeroFactura = id;
                fechaVenta = DateTime.Now;
                venta = carrito.ToList();
                carrito.Clear();
                ActualizarTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar: " + ex.Message);
            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void frmFactura_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                if(venta == null || venta.Count == 0)
                {
                    MessageBox.Show("Primero guarde una factura");
                    return;
                }
                string contenido = CrearTextoFactura();
                GuardarFacturaTxt(contenido);
                MessageBox.Show($"Se guardo la factura {numeroFactura} correctamente");
            }
        }
        private string CrearTextoFactura()
        {
            string linea = new string('=', 56);
            StringBuilder factura = new StringBuilder();
            factura.AppendLine(linea);
            factura.AppendLine($"FACTURA N.º: {numeroFactura}");
            factura.AppendLine(linea);
            factura.AppendLine($"Fecha: {fechaVenta}");
            factura.AppendLine(linea);
            factura.AppendLine($"{"CÓDIGO",-10}{"PRODUCTO",-24}{"CANT.",8}{"SUBTOTAL",14}");
            factura.AppendLine(linea);
            
            foreach(ItemFactura item in venta)
            {
                factura.AppendLine($"{item.Codigo,-10}{item.Nombre,-24}{item.Cantidad,8}{item.SubTotal.ToString("C2", new CultureInfo("es-DO")),14}");
            }

            decimal total = venta.Sum(item => item.SubTotal);
            factura.AppendLine(linea);
            factura.AppendLine($"TOTAL: {total.ToString("C2", new CultureInfo("es-DO"))}");

            return factura.ToString();
        }

        private void GuardarFacturaTxt(string contenido)
        {
            string documentos = Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments);

            string carpeta = Path.Combine(
                documentos,
                "RegistroProductos",
                "Facturas");

            Directory.CreateDirectory(carpeta);
            string nombreArchivo = $"Factura_{numeroFactura}.txt";
            string rutaArchivo = Path.Combine(carpeta, nombreArchivo);

            File.WriteAllText(rutaArchivo, contenido, Encoding.UTF8);
        }
    }
}
