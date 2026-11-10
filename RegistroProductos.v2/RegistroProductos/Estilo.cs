using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RegistroProductos
{
    public static class Estilo
    {
        public static readonly Color Primario = Color.FromArgb(33, 150, 243);
        public static readonly Color Secundario = Color.FromArgb(45, 45, 48);
        public static readonly Color Fondo = Color.FromArgb(30, 30, 30);
        public static readonly Color Texto = Color.FromArgb(241, 241, 241);
        public static readonly Color TextoSecundario = Color.FromArgb(160, 160, 160);
        public static readonly Color Campo = Color.FromArgb(51, 51, 55);
        public static readonly Color Acento = Color.FromArgb(66, 165, 245);
        public static readonly Color Peligro = Color.FromArgb(198, 40, 40);

        private static readonly Font FuenteBase = new Font("Segoe UI", 10F, FontStyle.Regular);
        private static readonly Font FuenteEtiqueta = new Font("Segoe UI", 9F, FontStyle.Bold);
        private static readonly Font FuenteTitulo = new Font("Segoe UI", 20F, FontStyle.Bold);
        private static readonly Font FuenteBoton = new Font("Segoe UI", 10F, FontStyle.Bold);
        private static readonly Font FuenteBotonDestacado = new Font("Segoe UI", 16F, FontStyle.Bold);

        public static Font Fuente => FuenteBase;

        public static void AplicarBoton(Button b)
        {
            bool esDestacado = b.Font.Size >= 14F;
            bool esPeligroso = b.Name.Contains("Eliminar", StringComparison.OrdinalIgnoreCase)
                || b.Name.Contains("Quitar", StringComparison.OrdinalIgnoreCase)
                || b.Text.Contains("Eliminar", StringComparison.OrdinalIgnoreCase)
                || b.Text.Contains("Quitar", StringComparison.OrdinalIgnoreCase);
            Color color = esPeligroso ? Peligro : Primario;
            Color colorHover = esPeligroso
                ? Color.FromArgb(229, 57, 53)
                : Acento;
            Color colorPresionado = esPeligroso
                ? Color.FromArgb(183, 28, 28)
                : Color.FromArgb(25, 118, 210);

            b.BackColor = color;
            b.ForeColor = Color.White;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.FlatAppearance.MouseOverBackColor = colorHover;
            b.FlatAppearance.MouseDownBackColor = colorPresionado;
            b.Font = esDestacado ? FuenteBotonDestacado : FuenteBoton;
            b.Cursor = Cursors.Hand;
            b.UseVisualStyleBackColor = false;
        }

        public static void AplicarTextBox(TextBox t)
        {
            t.BackColor = Campo;
            t.ForeColor = Texto;
            t.Font = Fuente;
            t.BorderStyle = BorderStyle.FixedSingle;
        }
   
        public static void AplicarTabla(DataGridView d)
        {
            d.EnableHeadersVisualStyles = false;
            d.ColumnHeadersDefaultCellStyle.BackColor = Campo;
            d.ColumnHeadersDefaultCellStyle.ForeColor = Texto;
            d.DefaultCellStyle.BackColor = Campo;
            d.DefaultCellStyle.ForeColor = Texto;
            d.RowHeadersVisible = false;
        }

        public static void Aplicar(Form f)
        {
            f.BackColor = Fondo;

            foreach (Control c in f.Controls)
            {
                switch (c)
                {
                    case Button b:
                        AplicarBoton(b);
                        break;
                    case Label l:
                        l.ForeColor = Texto;
                        l.Font = Fuente;
                        break;
                    case TextBox t:
                        AplicarTextBox(t);
                        break;
                    case DataGridView d:
                        AplicarTabla(d);
                        break;

                }
            }
        }
        public static void AplicarFactura(Form formulario, Panel pnlEncabezado,
            Label lblTitulo, Label lblMonto, Label lblDevuelta1, Label lblDevuelta2,
            NumericUpDown nuMontoPagado, ComboBox cmbTipoPago, ComboBox cmbClientes,
            Button btnNuevoCliente, DataGridView dgvCarrito,
            Label lblTipoPagoUI, Label lblClienteUI)
        {
            formulario.BackColor = Estilo.Fondo;
            formulario.Font = Estilo.Fuente;
            formulario.WindowState = FormWindowState.Normal;
            Rectangle area = Screen.FromControl(formulario).WorkingArea;
            formulario.Size = new Size((int)(area.Width * 0.90), (int)(area.Height * 0.90));

            foreach (Label etiqueta in new[] { lblTipoPagoUI, lblClienteUI })
            {
                etiqueta.AutoSize = false;
                etiqueta.Dock = DockStyle.None;
                etiqueta.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                etiqueta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                etiqueta.ForeColor = Estilo.TextoSecundario;
                etiqueta.TextAlign = ContentAlignment.MiddleLeft;
                etiqueta.Padding = new Padding(0);
                etiqueta.Margin = new Padding(0);
            }

            foreach (ComboBox combo in new[] { cmbTipoPago, cmbClientes })
            {
                combo.BackColor = Estilo.Campo;
                combo.ForeColor = Estilo.Texto;
                combo.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                combo.FlatStyle = FlatStyle.Flat;
                combo.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                combo.Margin = new Padding(0);
            }

            nuMontoPagado.BackColor = Estilo.Campo;
            nuMontoPagado.ForeColor = Estilo.Texto;
            nuMontoPagado.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            nuMontoPagado.BorderStyle = BorderStyle.FixedSingle;
            nuMontoPagado.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            nuMontoPagado.Margin = new Padding(0);

            lblMonto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMonto.ForeColor = Estilo.TextoSecundario;
            lblMonto.AutoSize = false;
            lblMonto.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblDevuelta1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDevuelta1.ForeColor = Estilo.TextoSecundario;
            lblDevuelta1.AutoSize = false;
            lblDevuelta1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblDevuelta2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDevuelta2.ForeColor = Estilo.Texto;
            lblDevuelta2.AutoSize = false;
            lblDevuelta2.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            Estilo.AplicarBoton(btnNuevoCliente);
            btnNuevoCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            Estilo.AplicarTabla(dgvCarrito);

            lblTitulo.Dock = DockStyle.None;
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblTitulo.Padding = new Padding(0);
            lblTitulo.Margin = new Padding(0);

            pnlEncabezado.Resize += (_, _) => LayoutEncabezado(formulario, pnlEncabezado, lblTitulo, lblMonto, lblDevuelta1, lblDevuelta2, nuMontoPagado, cmbTipoPago, cmbClientes, btnNuevoCliente, lblTipoPagoUI, lblClienteUI);
            LayoutEncabezado(formulario, pnlEncabezado, lblTitulo, lblMonto, lblDevuelta1, lblDevuelta2, nuMontoPagado, cmbTipoPago, cmbClientes, btnNuevoCliente, lblTipoPagoUI, lblClienteUI);
        }

        private static void LayoutEncabezado(Form formulario, Panel pnlEncabezado,
            Label lblTitulo, Label lblMonto, Label lblDevuelta1, Label lblDevuelta2,
            NumericUpDown nuMontoPagado, ComboBox cmbTipoPago, ComboBox cmbClientes,
            Button btnNuevoCliente, Label lblTipoPagoUI, Label lblClienteUI)
        {
            float escala = formulario.DeviceDpi / 96F;
            int U(int valor) => (int)Math.Round(valor * escala);

            int espacio = U(16);
            int anchoFila = pnlEncabezado.ClientSize.Width - U(48) - 4 * espacio;
            int anchoMonto = Math.Min(U(160), (int)(anchoFila * 0.18));
            int anchoPago = Math.Min(U(160), (int)(anchoFila * 0.18));
            int anchoDevuelta = Math.Min(U(140), (int)(anchoFila * 0.14));
            int anchoBoton = Math.Min(U(148), (int)(anchoFila * 0.20));
            int pagoX = U(24) + anchoMonto + espacio;
            int devueltaX = pagoX + anchoPago + espacio;
            int clienteX = devueltaX + anchoDevuelta + espacio;
            int botonX = pnlEncabezado.ClientSize.Width - U(24) - anchoBoton;

            pnlEncabezado.Height = U(144);
            lblTitulo.SetBounds(U(24), U(12), pnlEncabezado.ClientSize.Width - U(48), U(44));
            lblMonto.SetBounds(U(24), U(64), anchoMonto, U(24));
            nuMontoPagado.SetBounds(U(24), U(92), anchoMonto, U(32));
            cmbTipoPago.SetBounds(pagoX, U(92), anchoPago, U(32));
            lblTipoPagoUI.SetBounds(cmbTipoPago.Left, lblMonto.Top, cmbTipoPago.Width, lblMonto.Height);
            lblDevuelta1.SetBounds(devueltaX, U(64), anchoDevuelta, U(24));
            lblDevuelta2.SetBounds(devueltaX, U(92), anchoDevuelta, U(32));
            cmbClientes.SetBounds(clienteX, U(92), botonX - espacio - clienteX, U(32));
            lblClienteUI.SetBounds(cmbClientes.Left, U(64), cmbClientes.Width, U(24));
            btnNuevoCliente.SetBounds(botonX, U(88), anchoBoton, U(40));

            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            lblDevuelta1.TextAlign = ContentAlignment.MiddleLeft;
            lblDevuelta2.TextAlign = ContentAlignment.MiddleLeft;
        }

    }
}
