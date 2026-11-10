namespace RegistroProductos
{
    partial class frmFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtCodigo = new TextBox();
            nuCantidad = new NumericUpDown();
            dgvCarrito = new DataGridView();
            lblCodigo = new Label();
            lblCantidad = new Label();
            btnAgregar = new Button();
            lblTotal = new Label();
            btnGuardar = new Button();
            pnlEncabezado = new Panel();
            lblTipoPagoUI = new Label();
            lblClienteUI = new Label();
            btnNuevoCliente = new Button();
            cmbClientes = new ComboBox();
            lblDevuelta2 = new Label();
            lblDevuelta1 = new Label();
            lblMonto = new Label();
            nuMontoPagado = new NumericUpDown();
            cmbTipoPago = new ComboBox();
            lblTitulo = new Label();
            pnlEntrada = new Panel();
            tlpEntrada = new TableLayoutPanel();
            flpAcciones = new FlowLayoutPanel();
            btnQuitar = new Button();
            pnlTabla = new Panel();
            tlpTabla = new TableLayoutPanel();
            lblMensaje = new Label();
            pnlTotal = new Panel();
            tlpTotal = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)nuCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nuMontoPagado).BeginInit();
            pnlEntrada.SuspendLayout();
            tlpEntrada.SuspendLayout();
            flpAcciones.SuspendLayout();
            pnlTabla.SuspendLayout();
            tlpTabla.SuspendLayout();
            pnlTotal.SuspendLayout();
            tlpTotal.SuspendLayout();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(51, 51, 55);
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Dock = DockStyle.Fill;
            txtCodigo.Font = new Font("Segoe UI", 10F);
            txtCodigo.ForeColor = Color.FromArgb(241, 241, 241);
            txtCodigo.Location = new Point(5, 25);
            txtCodigo.Margin = new Padding(5, 0, 5, 0);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(600, 34);
            txtCodigo.TabIndex = 0;
            // 
            // nuCantidad
            // 
            nuCantidad.BackColor = Color.FromArgb(51, 51, 55);
            nuCantidad.BorderStyle = BorderStyle.FixedSingle;
            nuCantidad.Dock = DockStyle.Fill;
            nuCantidad.Font = new Font("Segoe UI", 10F);
            nuCantidad.ForeColor = Color.FromArgb(241, 241, 241);
            nuCantidad.Location = new Point(615, 25);
            nuCantidad.Margin = new Padding(5, 0, 5, 0);
            nuCantidad.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nuCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nuCantidad.Name = "nuCantidad";
            nuCantidad.Size = new Size(150, 34);
            nuCantidad.TabIndex = 1;
            nuCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dgvCarrito
            // 
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.AllowUserToDeleteRows = false;
            dgvCarrito.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 45, 48);
            dgvCarrito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.BackgroundColor = Color.FromArgb(37, 37, 38);
            dgvCarrito.BorderStyle = BorderStyle.None;
            dgvCarrito.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCarrito.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(51, 51, 55);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(241, 241, 241);
            dataGridViewCellStyle2.Padding = new Padding(8, 4, 8, 4);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCarrito.ColumnHeadersHeight = 42;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(51, 51, 55);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(241, 241, 241);
            dataGridViewCellStyle3.Padding = new Padding(8, 4, 8, 4);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(36, 80, 115);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCarrito.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCarrito.Dock = DockStyle.Fill;
            dgvCarrito.EnableHeadersVisualStyles = false;
            dgvCarrito.GridColor = Color.FromArgb(63, 63, 70);
            dgvCarrito.Location = new Point(3, 3);
            dgvCarrito.MultiSelect = false;
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.ReadOnly = true;
            dgvCarrito.RowHeadersVisible = false;
            dgvCarrito.RowHeadersWidth = 62;
            dgvCarrito.RowTemplate.Height = 36;
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.Size = new Size(1084, 310);
            dgvCarrito.TabIndex = 2;
            // 
            // lblCodigo
            // 
            lblCodigo.Dock = DockStyle.Fill;
            lblCodigo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCodigo.ForeColor = Color.FromArgb(190, 190, 198);
            lblCodigo.Location = new Point(5, 0);
            lblCodigo.Margin = new Padding(5, 0, 5, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(600, 25);
            lblCodigo.TabIndex = 3;
            lblCodigo.Text = "Codigo";
            lblCodigo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCantidad
            // 
            lblCantidad.Dock = DockStyle.Fill;
            lblCantidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidad.ForeColor = Color.FromArgb(190, 190, 198);
            lblCantidad.Location = new Point(615, 0);
            lblCantidad.Margin = new Padding(5, 0, 5, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(150, 25);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad";
            lblCantidad.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(33, 150, 243);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 118, 210);
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(66, 165, 245);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(8, 0);
            btnAgregar.Margin = new Padding(0);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(140, 40);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblTotal
            // 
            lblTotal.Dock = DockStyle.Fill;
            lblTotal.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(241, 241, 241);
            lblTotal.Location = new Point(3, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Padding = new Padding(0, 0, 16, 0);
            lblTotal.Size = new Size(884, 48);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            lblTotal.Click += lblTotal_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(46, 125, 50);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Dock = DockStyle.Fill;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 94, 32);
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 142, 60);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(902, 0);
            btnGuardar.Margin = new Padding(12, 0, 0, 0);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(188, 48);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar factura";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.FromArgb(37, 37, 38);
            pnlEncabezado.Controls.Add(lblTipoPagoUI);
            pnlEncabezado.Controls.Add(lblClienteUI);
            pnlEncabezado.Controls.Add(btnNuevoCliente);
            pnlEncabezado.Controls.Add(cmbClientes);
            pnlEncabezado.Controls.Add(lblDevuelta2);
            pnlEncabezado.Controls.Add(lblDevuelta1);
            pnlEncabezado.Controls.Add(lblMonto);
            pnlEncabezado.Controls.Add(nuMontoPagado);
            pnlEncabezado.Controls.Add(cmbTipoPago);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(1138, 144);
            pnlEncabezado.TabIndex = 8;
            // 
            // lblTipoPagoUI
            // 
            lblTipoPagoUI.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTipoPagoUI.ForeColor = Color.FromArgb(190, 190, 198);
            lblTipoPagoUI.Location = new Point(200, 54);
            lblTipoPagoUI.Name = "lblTipoPagoUI";
            lblTipoPagoUI.Size = new Size(160, 35);
            lblTipoPagoUI.TabIndex = 0;
            lblTipoPagoUI.Text = "Tipo de pago";
            // 
            // lblClienteUI
            // 
            lblClienteUI.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblClienteUI.ForeColor = Color.FromArgb(190, 190, 198);
            lblClienteUI.Location = new Point(532, 64);
            lblClienteUI.Name = "lblClienteUI";
            lblClienteUI.Size = new Size(400, 24);
            lblClienteUI.TabIndex = 1;
            lblClienteUI.Text = "Cliente";
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoCliente.BackColor = Color.FromArgb(33, 150, 243);
            btnNuevoCliente.Cursor = Cursors.Hand;
            btnNuevoCliente.FlatAppearance.BorderSize = 0;
            btnNuevoCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 118, 210);
            btnNuevoCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(66, 165, 245);
            btnNuevoCliente.FlatStyle = FlatStyle.Flat;
            btnNuevoCliente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNuevoCliente.ForeColor = Color.White;
            btnNuevoCliente.Location = new Point(951, 91);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(160, 40);
            btnNuevoCliente.TabIndex = 8;
            btnNuevoCliente.Text = "Nuevo cliente";
            btnNuevoCliente.UseVisualStyleBackColor = false;
            btnNuevoCliente.Click += btnNuevoCliente_Click;
            // 
            // cmbClientes
            // 
            cmbClientes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbClientes.BackColor = Color.FromArgb(51, 51, 55);
            cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientes.FlatStyle = FlatStyle.Flat;
            cmbClientes.Font = new Font("Segoe UI", 10F);
            cmbClientes.ForeColor = Color.FromArgb(241, 241, 241);
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(532, 92);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(418, 36);
            cmbClientes.TabIndex = 7;
            // 
            // lblDevuelta2
            // 
            lblDevuelta2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDevuelta2.ForeColor = Color.FromArgb(190, 190, 198);
            lblDevuelta2.Location = new Point(376, 92);
            lblDevuelta2.Name = "lblDevuelta2";
            lblDevuelta2.Size = new Size(140, 32);
            lblDevuelta2.TabIndex = 6;
            lblDevuelta2.Text = "0,00";
            // 
            // lblDevuelta1
            // 
            lblDevuelta1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDevuelta1.ForeColor = Color.FromArgb(190, 190, 198);
            lblDevuelta1.Location = new Point(376, 64);
            lblDevuelta1.Name = "lblDevuelta1";
            lblDevuelta1.Size = new Size(140, 24);
            lblDevuelta1.TabIndex = 5;
            lblDevuelta1.Text = "Devuelta";
            // 
            // lblMonto
            // 
            lblMonto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMonto.ForeColor = Color.FromArgb(190, 190, 198);
            lblMonto.Location = new Point(24, 53);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(160, 35);
            lblMonto.TabIndex = 4;
            lblMonto.Text = "Monto pagado";
            // 
            // nuMontoPagado
            // 
            nuMontoPagado.BackColor = Color.FromArgb(51, 51, 55);
            nuMontoPagado.BorderStyle = BorderStyle.FixedSingle;
            nuMontoPagado.DecimalPlaces = 2;
            nuMontoPagado.Font = new Font("Segoe UI", 10F);
            nuMontoPagado.ForeColor = Color.FromArgb(241, 241, 241);
            nuMontoPagado.Location = new Point(24, 92);
            nuMontoPagado.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nuMontoPagado.Name = "nuMontoPagado";
            nuMontoPagado.Size = new Size(160, 34);
            nuMontoPagado.TabIndex = 3;
            nuMontoPagado.ThousandsSeparator = true;
            nuMontoPagado.ValueChanged += nuMontoPagado_ValueChanged;
            // 
            // cmbTipoPago
            // 
            cmbTipoPago.BackColor = Color.FromArgb(51, 51, 55);
            cmbTipoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPago.FlatStyle = FlatStyle.Flat;
            cmbTipoPago.Font = new Font("Segoe UI", 10F);
            cmbTipoPago.ForeColor = Color.FromArgb(241, 241, 241);
            cmbTipoPago.FormattingEnabled = true;
            cmbTipoPago.Items.AddRange(new object[] { "Contado", "Credito" });
            cmbTipoPago.Location = new Point(200, 92);
            cmbTipoPago.Name = "cmbTipoPago";
            cmbTipoPago.Size = new Size(160, 36);
            cmbTipoPago.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(241, 241, 241);
            lblTitulo.Location = new Point(29, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(800, 53);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nueva factura";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlEntrada
            // 
            pnlEntrada.BackColor = Color.FromArgb(37, 37, 38);
            pnlEntrada.Controls.Add(tlpEntrada);
            pnlEntrada.Dock = DockStyle.Top;
            pnlEntrada.Location = new Point(0, 144);
            pnlEntrada.Name = "pnlEntrada";
            pnlEntrada.Padding = new Padding(24, 12, 24, 12);
            pnlEntrada.Size = new Size(1138, 108);
            pnlEntrada.TabIndex = 9;
            // 
            // tlpEntrada
            // 
            tlpEntrada.BackColor = Color.FromArgb(37, 37, 38);
            tlpEntrada.ColumnCount = 3;
            tlpEntrada.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpEntrada.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tlpEntrada.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 320F));
            tlpEntrada.Controls.Add(lblCodigo, 0, 0);
            tlpEntrada.Controls.Add(txtCodigo, 0, 1);
            tlpEntrada.Controls.Add(lblCantidad, 1, 0);
            tlpEntrada.Controls.Add(nuCantidad, 1, 1);
            tlpEntrada.Controls.Add(flpAcciones, 2, 1);
            tlpEntrada.Dock = DockStyle.Fill;
            tlpEntrada.Location = new Point(24, 12);
            tlpEntrada.Name = "tlpEntrada";
            tlpEntrada.RowCount = 2;
            tlpEntrada.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpEntrada.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpEntrada.Size = new Size(1090, 84);
            tlpEntrada.TabIndex = 0;
            // 
            // flpAcciones
            // 
            flpAcciones.BackColor = Color.FromArgb(37, 37, 38);
            flpAcciones.Controls.Add(btnAgregar);
            flpAcciones.Controls.Add(btnQuitar);
            flpAcciones.Dock = DockStyle.Fill;
            flpAcciones.Location = new Point(770, 25);
            flpAcciones.Margin = new Padding(0);
            flpAcciones.Name = "flpAcciones";
            flpAcciones.Padding = new Padding(8, 0, 0, 0);
            flpAcciones.Size = new Size(320, 59);
            flpAcciones.TabIndex = 0;
            flpAcciones.WrapContents = false;
            // 
            // btnQuitar
            // 
            btnQuitar.BackColor = Color.FromArgb(198, 40, 40);
            btnQuitar.Cursor = Cursors.Hand;
            btnQuitar.FlatAppearance.BorderSize = 0;
            btnQuitar.FlatAppearance.MouseDownBackColor = Color.FromArgb(183, 28, 28);
            btnQuitar.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 57, 53);
            btnQuitar.FlatStyle = FlatStyle.Flat;
            btnQuitar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnQuitar.ForeColor = Color.White;
            btnQuitar.Location = new Point(158, 0);
            btnQuitar.Margin = new Padding(10, 0, 0, 0);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(140, 40);
            btnQuitar.TabIndex = 4;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = false;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // pnlTabla
            // 
            pnlTabla.BackColor = Color.FromArgb(30, 30, 30);
            pnlTabla.Controls.Add(tlpTabla);
            pnlTabla.Dock = DockStyle.Fill;
            pnlTabla.Location = new Point(0, 252);
            pnlTabla.Name = "pnlTabla";
            pnlTabla.Padding = new Padding(24, 16, 24, 8);
            pnlTabla.Size = new Size(1138, 370);
            pnlTabla.TabIndex = 10;
            // 
            // tlpTabla
            // 
            tlpTabla.BackColor = Color.FromArgb(37, 37, 38);
            tlpTabla.ColumnCount = 1;
            tlpTabla.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTabla.Controls.Add(dgvCarrito, 0, 0);
            tlpTabla.Controls.Add(lblMensaje, 0, 1);
            tlpTabla.Dock = DockStyle.Fill;
            tlpTabla.Location = new Point(24, 16);
            tlpTabla.Name = "tlpTabla";
            tlpTabla.RowCount = 2;
            tlpTabla.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTabla.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpTabla.Size = new Size(1090, 346);
            tlpTabla.TabIndex = 0;
            // 
            // lblMensaje
            // 
            lblMensaje.Dock = DockStyle.Fill;
            lblMensaje.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMensaje.ForeColor = Color.FromArgb(190, 190, 198);
            lblMensaje.Location = new Point(3, 316);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(1084, 30);
            lblMensaje.TabIndex = 3;
            lblMensaje.Text = "Presione F5 para guardar la factura en txt.";
            lblMensaje.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlTotal
            // 
            pnlTotal.BackColor = Color.FromArgb(37, 37, 38);
            pnlTotal.Controls.Add(tlpTotal);
            pnlTotal.Dock = DockStyle.Bottom;
            pnlTotal.Location = new Point(0, 622);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Padding = new Padding(24, 16, 24, 16);
            pnlTotal.Size = new Size(1138, 80);
            pnlTotal.TabIndex = 11;
            // 
            // tlpTotal
            // 
            tlpTotal.BackColor = Color.FromArgb(37, 37, 38);
            tlpTotal.ColumnCount = 2;
            tlpTotal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTotal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tlpTotal.Controls.Add(lblTotal, 0, 0);
            tlpTotal.Controls.Add(btnGuardar, 1, 0);
            tlpTotal.Dock = DockStyle.Fill;
            tlpTotal.Location = new Point(24, 16);
            tlpTotal.Name = "tlpTotal";
            tlpTotal.RowCount = 1;
            tlpTotal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTotal.Size = new Size(1090, 48);
            tlpTotal.TabIndex = 0;
            // 
            // frmFactura
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1138, 702);
            Controls.Add(pnlTabla);
            Controls.Add(pnlTotal);
            Controls.Add(pnlEntrada);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(241, 241, 241);
            KeyPreview = true;
            MinimumSize = new Size(1000, 580);
            Name = "frmFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Facturación";
            KeyDown += frmFactura_KeyDown;
            ((System.ComponentModel.ISupportInitialize)nuCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            pnlEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nuMontoPagado).EndInit();
            pnlEntrada.ResumeLayout(false);
            tlpEntrada.ResumeLayout(false);
            tlpEntrada.PerformLayout();
            flpAcciones.ResumeLayout(false);
            pnlTabla.ResumeLayout(false);
            tlpTabla.ResumeLayout(false);
            pnlTotal.ResumeLayout(false);
            tlpTotal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblClienteUI;

        private Label lblTipoPagoUI;

        private TextBox txtCodigo;
        private NumericUpDown nuCantidad;
        private DataGridView dgvCarrito;
        private Label lblCodigo;
        private Label lblCantidad;
        private Button btnAgregar;
        private Label lblTotal;
        private Button btnGuardar;
        private Panel pnlEncabezado;
        private Label lblTitulo;
        private Panel pnlEntrada;
        private TableLayoutPanel tlpEntrada;
        private FlowLayoutPanel flpAcciones;
        private Panel pnlTabla;
        private TableLayoutPanel tlpTabla;
        private Panel pnlTotal;
        private TableLayoutPanel tlpTotal;
        private Label lblMensaje;
        private Button btnQuitar;
        private ComboBox cmbTipoPago;
        private NumericUpDown nuMontoPagado;
        private Label lblDevuelta2;
        private Label lblDevuelta1;
        private Label lblMonto;
        private ComboBox cmbClientes;
        private Button btnNuevoCliente;
    }
}
