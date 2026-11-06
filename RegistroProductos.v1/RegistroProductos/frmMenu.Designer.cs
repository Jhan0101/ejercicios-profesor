namespace RegistroProductos
{
    partial class frmMenu
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
            btnProductos = new Button();
            btnFacturas = new Button();
            pnlEncabezado = new Panel();
            btnCrearCajero = new Button();
            lblTitulo = new Label();
            tlpMenu = new TableLayoutPanel();
            pnlEncabezado.SuspendLayout();
            tlpMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.FromArgb(33, 150, 243);
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.Dock = DockStyle.Fill;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 118, 210);
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(66, 165, 245);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(75, 55);
            btnProductos.Margin = new Padding(15);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(310, 300);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnFacturas
            // 
            btnFacturas.BackColor = Color.FromArgb(46, 125, 50);
            btnFacturas.Cursor = Cursors.Hand;
            btnFacturas.Dock = DockStyle.Fill;
            btnFacturas.FlatAppearance.BorderSize = 0;
            btnFacturas.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 94, 32);
            btnFacturas.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 142, 60);
            btnFacturas.FlatStyle = FlatStyle.Flat;
            btnFacturas.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnFacturas.ForeColor = Color.White;
            btnFacturas.Location = new Point(415, 55);
            btnFacturas.Margin = new Padding(15);
            btnFacturas.Name = "btnFacturas";
            btnFacturas.Size = new Size(310, 300);
            btnFacturas.TabIndex = 1;
            btnFacturas.Text = "Facturas";
            btnFacturas.UseVisualStyleBackColor = false;
            btnFacturas.Click += btnFacturas_Click;
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.FromArgb(37, 37, 38);
            pnlEncabezado.Controls.Add(btnCrearCajero);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(800, 90);
            pnlEncabezado.TabIndex = 2;
            // 
            // btnCrearCajero
            // 
            btnCrearCajero.Location = new Point(43, 25);
            btnCrearCajero.Name = "btnCrearCajero";
            btnCrearCajero.Size = new Size(112, 34);
            btnCrearCajero.TabIndex = 1;
            btnCrearCajero.Text = "Crear cajero";
            btnCrearCajero.UseVisualStyleBackColor = true;
            btnCrearCajero.Click += btnCrearCajero_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(66, 165, 245);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(800, 90);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema de Gestión";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpMenu
            // 
            tlpMenu.ColumnCount = 2;
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMenu.Controls.Add(btnProductos, 0, 0);
            tlpMenu.Controls.Add(btnFacturas, 1, 0);
            tlpMenu.Dock = DockStyle.Fill;
            tlpMenu.Location = new Point(0, 90);
            tlpMenu.Name = "tlpMenu";
            tlpMenu.Padding = new Padding(60, 40, 60, 40);
            tlpMenu.RowCount = 1;
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMenu.Size = new Size(800, 410);
            tlpMenu.TabIndex = 0;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(800, 500);
            Controls.Add(tlpMenu);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú principal";
            pnlEncabezado.ResumeLayout(false);
            tlpMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnProductos;
        private Button btnFacturas;
        private Panel pnlEncabezado;
        private Label lblTitulo;
        private TableLayoutPanel tlpMenu;
        private Button btnCrearCajero;
    }
}