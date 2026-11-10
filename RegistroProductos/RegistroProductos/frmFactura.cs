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
        private decimal total;
        private Factura ultimaFactura;
        private UsuarioSession session;

        public frmFactura(UsuarioSession s)
        {
            InitializeComponent();
            Estilo.Aplicar(this);
            Estilo.AplicarFactura(this, pnlEncabezado,
                lblTitulo, lblMonto, lblDevuelta1, lblDevuelta2,
                nuMontoPagado, cmbTipoPago, cmbClientes, btnNuevoCliente, dgvCarrito,
                lblTipoPagoUI, lblClienteUI);
            CargarCliente();
            session = s;
            usuarioId = session.UsuarioID;

            dgvCarrito.DataSource = carrito;
            dgvCarrito.Columns["Itbis"].DefaultCellStyle.Format = "N2";
            dgvCarrito.Columns["LlevaItbis"].Visible = false;

            if (dgvCarrito.Columns.Contains("ProductoID"))
            {
                dgvCarrito.Columns["ProductoID"].Visible = false;
            }

            ActualizarTotal();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(session.Rol == "Cajero" && !Seguridad.EstaEnTurno(session.Turno, DateTime.Now.TimeOfDay))
            {
                MessageBox.Show("No puede hacer una venta fuera de horario.");
                return;
            }
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
                item.LlevaItbis = p.LlevaItbis;

                carrito.Add(item);
            }


            txtCodigo.Clear();
            nuCantidad.Value = 1;
            txtCodigo.Focus();
            ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            total = CalcularTotal();
            lblTotal.Text = total.ToString("C2", new CultureInfo("es-DO"));
            carrito.ResetBindings();
            ActualizarDevuelta();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            decimal total = CalcularTotal();
            if (carrito.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto.");
                return;
            }
            if (cmbTipoPago.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de pago.");
                cmbTipoPago.Focus();
                return;
            }
            if (cmbTipoPago.Text == "Contado" && nuMontoPagado.Value < total)
            {
                MessageBox.Show("El monto pagado es insuficiente.");
                nuMontoPagado.Focus();
                return;
            }
            if (cmbTipoPago.Text == "Credito" && cmbClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cliente.");
                cmbClientes.Focus();
                return;
            }
            try
            {
                Factura f = new Factura();
                f.UsuarioId = usuarioId;
                f.TipoPago = cmbTipoPago.Text;
                f.Items = carrito.ToList();
                f.MontoPagado = cmbTipoPago.Text == "Contado" ? nuMontoPagado.Value : 0m;
                f.Devuelta = cmbTipoPago.Text == "Contado" ? nuMontoPagado.Value - total : 0m;
                f.ClienteID = cmbClientes.SelectedIndex != -1 ? Convert.ToInt32(cmbClientes.SelectedValue) : null;

                FacturaDAO dao = new FacturaDAO();
                int id = dao.GuardarFactura(f);
                ultimaFactura = f;
                MessageBox.Show($"Factura guardada.");

                numeroFactura = id;
                fechaVenta = DateTime.Now;
                venta = carrito.ToList();
                carrito.Clear();
                cmbTipoPago.SelectedIndex = -1;
                nuMontoPagado.Value = 0;
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
            if (e.KeyCode == Keys.F5)
            {
                if (venta == null || venta.Count == 0)
                {
                    MessageBox.Show("Primero guarde una factura");
                    return;
                }
                string contenido = CrearTextoFactura();
                GuardarFacturaTxt(contenido);
                MessageBox.Show($"Se guardo la factura {numeroFactura.ToString("D5")} correctamente");
            }
        }
        private string CrearTextoFactura()
        {
            string linea = new string('=', 84);
            StringBuilder factura = new StringBuilder();
            factura.AppendLine(linea);
            factura.AppendLine($"FACTURA N.º: {numeroFactura.ToString("D5")}");
            factura.AppendLine(linea);
            factura.AppendLine($"Fecha: {fechaVenta.ToString("dd/MM/yyyy HH:mm")}");
            factura.AppendLine(linea);
            factura.AppendLine($"TIPO DE PAGO: {ultimaFactura.TipoPago}");
            factura.AppendLine(linea);
            factura.AppendLine($"ID CAJERO: {ultimaFactura.UsuarioId}");
            factura.AppendLine($"NOMBRE: {session.NombreUsuario}");
            factura.AppendLine(linea);
            factura.AppendLine($"{"CÓDIGO",-10}{"PRODUCTO",-24}{"PRECIO",14}{"CANT.",8}{"SUBTOTAL",14}{"ITBIS",14}");
            factura.AppendLine(linea);

            foreach (ItemFactura item in venta)
            {
                factura.AppendLine($"{item.Codigo,-10}" +
                                   $"{item.Nombre,-24}" +
                                   $"{item.Precio.ToString("C2", new CultureInfo("es-DO")),14}" +
                                   $"{item.Cantidad,8}" +
                                   $"{item.SubTotal.ToString("C2", new CultureInfo("es-DO")),14}" +
                                   $"{item.Itbis.ToString("C2", new CultureInfo("es-DO")),14}");
            }

            decimal totalBruto = venta.Sum(item => item.SubTotal);
            decimal totalItbis = venta.Sum(item => item.Itbis);
            decimal total = totalBruto + totalItbis;
            factura.AppendLine(linea);
            factura.AppendLine($"TOTAL BRUTO: {totalBruto.ToString("C2", new CultureInfo("es-DO"))}");
            factura.AppendLine($"TOTAL ITBIS: {totalItbis.ToString("C2", new CultureInfo("es-DO"))}");
            factura.AppendLine($"TOTAL: {total.ToString("C2", new CultureInfo("es-DO"))}");

            if (ultimaFactura.TipoPago == "Contado")
            {
                factura.AppendLine($"MONTO PAGADO: {ultimaFactura.MontoPagado.ToString("C2", new CultureInfo("es-DO"))}");
                factura.AppendLine($"DEVUELTA: {ultimaFactura.Devuelta.ToString("C2", new CultureInfo("es-DO"))}");
            }

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
            string nombreArchivo = $"Factura_{numeroFactura.ToString("D5")}.txt";
            string rutaArchivo = Path.Combine(carpeta, nombreArchivo);

            File.WriteAllText(rutaArchivo, contenido, Encoding.UTF8);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.CurrentRow == null)
            {
                MessageBox.Show("Seleccione la fila que desea quitar primero.");
                return;
            }

            ItemFactura item = dgvCarrito.CurrentRow.DataBoundItem as ItemFactura;
            if (item != null)
            {
                carrito.Remove(item);
                ActualizarTotal();
            }
        }

        private void ActualizarDevuelta()
        {
            total = CalcularTotal();
            decimal devuelta = nuMontoPagado.Value - total;
            lblDevuelta2.Text = devuelta.ToString("C2", new CultureInfo("es-DO"));
        }

        private void nuMontoPagado_ValueChanged(object sender, EventArgs e)
        {
            ActualizarDevuelta();
        }

        private decimal CalcularTotal()
        {
            decimal totalBruto = carrito.Sum(c => c.SubTotal);
            decimal totalItbis = carrito.Sum(c => c.Itbis);
            decimal total = totalBruto + totalItbis;

            return total;
        }

        private void CargarCliente()
        {
            ClienteDAO dao = new ClienteDAO();
            cmbClientes.DisplayMember = "Nombre";
            cmbClientes.ValueMember = "ID";
            cmbClientes.DataSource = dao.ObtenerClientes();
            cmbClientes.SelectedIndex = -1;
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            using(frmCLientes f = new frmCLientes())
            {
                f.ShowDialog();
            }
            CargarCliente();
        }
    }
}
