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
            txtCodigo = new TextBox();
            nuCantidad = new NumericUpDown();
            dgvCarrito = new DataGridView();
            lblCodigo = new Label();
            lblCantidad = new Label();
            btnAgregar = new Button();
            lblTotal = new Label();
            btnGuardar = new Button();
            pnlEncabezado = new Panel();
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
            txtCodigo.Font = new Font("Segoe UI", 11F);
            txtCodigo.ForeColor = Color.FromArgb(241, 241, 241);
            txtCodigo.Location = new Point(5, 25);
            txtCodigo.Margin = new Padding(5, 0, 5, 0);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(326, 37);
            txtCodigo.TabIndex = 0;
            // 
            // nuCantidad
            // 
            nuCantidad.BackColor = Color.FromArgb(51, 51, 55);
            nuCantidad.BorderStyle = BorderStyle.FixedSingle;
            nuCantidad.Dock = DockStyle.Fill;
            nuCantidad.Font = new Font("Segoe UI", 11F);
            nuCantidad.ForeColor = Color.FromArgb(241, 241, 241);
            nuCantidad.Location = new Point(341, 25);
            nuCantidad.Margin = new Padding(5, 0, 5, 0);
            nuCantidad.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nuCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nuCantidad.Name = "nuCantidad";
            nuCantidad.Size = new Size(230, 37);
            nuCantidad.TabIndex = 1;
            nuCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dgvCarrito
            // 
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.AllowUserToDeleteRows = false;
            dgvCarrito.AllowUserToResizeRows = false;
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvCarrito.BorderStyle = BorderStyle.None;
            dgvCarrito.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCarrito.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCarrito.ColumnHeadersHeight = 40;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCarrito.Dock = DockStyle.Fill;
            dgvCarrito.EnableHeadersVisualStyles = false;
            dgvCarrito.GridColor = Color.FromArgb(63, 63, 70);
            dgvCarrito.Location = new Point(3, 3);
            dgvCarrito.MultiSelect = false;
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.ReadOnly = true;
            dgvCarrito.RowHeadersVisible = false;
            dgvCarrito.RowHeadersWidth = 62;
            dgvCarrito.RowTemplate.Height = 35;
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.Size = new Size(954, 334);
            dgvCarrito.TabIndex = 2;
            // 
            // lblCodigo
            // 
            lblCodigo.Dock = DockStyle.Fill;
            lblCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCodigo.ForeColor = Color.FromArgb(160, 160, 160);
            lblCodigo.Location = new Point(5, 0);
            lblCodigo.Margin = new Padding(5, 0, 5, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(326, 25);
            lblCodigo.TabIndex = 3;
            lblCodigo.Text = "Codigo";
            lblCodigo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCantidad
            // 
            lblCantidad.Dock = DockStyle.Fill;
            lblCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCantidad.ForeColor = Color.FromArgb(160, 160, 160);
            lblCantidad.Location = new Point(341, 0);
            lblCantidad.Margin = new Padding(5, 0, 5, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(230, 25);
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
            btnAgregar.Location = new Point(0, 5);
            btnAgregar.Margin = new Padding(0);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(140, 45);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblTotal
            // 
            lblTotal.Dock = DockStyle.Fill;
            lblTotal.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(66, 165, 245);
            lblTotal.Location = new Point(3, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(794, 60);
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
            btnGuardar.Location = new Point(803, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(154, 54);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar factura";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.FromArgb(37, 37, 38);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(1000, 70);
            pnlEncabezado.TabIndex = 8;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(66, 165, 245);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(20, 0, 0, 0);
            lblTitulo.Size = new Size(1000, 70);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nueva factura";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlEntrada
            // 
            pnlEntrada.BackColor = Color.FromArgb(45, 45, 48);
            pnlEntrada.Controls.Add(tlpEntrada);
            pnlEntrada.Dock = DockStyle.Top;
            pnlEntrada.Location = new Point(0, 70);
            pnlEntrada.Name = "pnlEntrada";
            pnlEntrada.Padding = new Padding(20, 10, 20, 10);
            pnlEntrada.Size = new Size(1000, 100);
            pnlEntrada.TabIndex = 9;
            // 
            // tlpEntrada
            // 
            tlpEntrada.ColumnCount = 3;
            tlpEntrada.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpEntrada.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpEntrada.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpEntrada.Controls.Add(lblCodigo, 0, 0);
            tlpEntrada.Controls.Add(txtCodigo, 0, 1);
            tlpEntrada.Controls.Add(lblCantidad, 1, 0);
            tlpEntrada.Controls.Add(nuCantidad, 1, 1);
            tlpEntrada.Controls.Add(flpAcciones, 2, 1);
            tlpEntrada.Dock = DockStyle.Fill;
            tlpEntrada.Location = new Point(20, 10);
            tlpEntrada.Name = "tlpEntrada";
            tlpEntrada.RowCount = 2;
            tlpEntrada.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpEntrada.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpEntrada.Size = new Size(960, 80);
            tlpEntrada.TabIndex = 0;
            // 
            // flpAcciones
            // 
            flpAcciones.Controls.Add(btnAgregar);
            flpAcciones.Controls.Add(btnQuitar);
            flpAcciones.Dock = DockStyle.Fill;
            flpAcciones.Location = new Point(579, 28);
            flpAcciones.Name = "flpAcciones";
            flpAcciones.Padding = new Padding(0, 5, 0, 0);
            flpAcciones.Size = new Size(378, 49);
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
            btnQuitar.Location = new Point(150, 5);
            btnQuitar.Margin = new Padding(10, 0, 0, 0);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(140, 45);
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
            pnlTabla.Location = new Point(0, 170);
            pnlTabla.Name = "pnlTabla";
            pnlTabla.Padding = new Padding(20, 15, 20, 15);
            pnlTabla.Size = new Size(1000, 400);
            pnlTabla.TabIndex = 10;
            // 
            // tlpTabla
            // 
            tlpTabla.ColumnCount = 1;
            tlpTabla.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTabla.Controls.Add(dgvCarrito, 0, 0);
            tlpTabla.Controls.Add(lblMensaje, 0, 1);
            tlpTabla.Dock = DockStyle.Fill;
            tlpTabla.Location = new Point(20, 15);
            tlpTabla.Name = "tlpTabla";
            tlpTabla.RowCount = 2;
            tlpTabla.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTabla.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpTabla.Size = new Size(960, 370);
            tlpTabla.TabIndex = 0;
            // 
            // lblMensaje
            // 
            lblMensaje.Dock = DockStyle.Fill;
            lblMensaje.ForeColor = Color.FromArgb(160, 160, 160);
            lblMensaje.Location = new Point(3, 340);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(954, 30);
            lblMensaje.TabIndex = 3;
            lblMensaje.Text = "Presione F5 para guardar la factura en txt.";
            lblMensaje.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlTotal
            // 
            pnlTotal.BackColor = Color.FromArgb(45, 45, 48);
            pnlTotal.Controls.Add(tlpTotal);
            pnlTotal.Dock = DockStyle.Bottom;
            pnlTotal.Location = new Point(0, 570);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Padding = new Padding(20, 10, 20, 10);
            pnlTotal.Size = new Size(1000, 80);
            pnlTotal.TabIndex = 11;
            // 
            // tlpTotal
            // 
            tlpTotal.ColumnCount = 2;
            tlpTotal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTotal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tlpTotal.Controls.Add(lblTotal, 0, 0);
            tlpTotal.Controls.Add(btnGuardar, 1, 0);
            tlpTotal.Dock = DockStyle.Fill;
            tlpTotal.Location = new Point(20, 10);
            tlpTotal.Name = "tlpTotal";
            tlpTotal.RowCount = 1;
            tlpTotal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTotal.Size = new Size(960, 60);
            tlpTotal.TabIndex = 0;
            // 
            // frmFactura
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1000, 650);
            Controls.Add(pnlTabla);
            Controls.Add(pnlTotal);
            Controls.Add(pnlEntrada);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeyPreview = true;
            MinimumSize = new Size(800, 500);
            Name = "frmFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Facturación";
            KeyDown += frmFactura_KeyDown;
            ((System.ComponentModel.ISupportInitialize)nuCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            pnlEncabezado.ResumeLayout(false);
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
    }
}