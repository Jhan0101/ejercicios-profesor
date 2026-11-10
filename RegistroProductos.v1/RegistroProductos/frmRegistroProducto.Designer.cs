namespace RegistroProductos
{
    partial class frmRegistroProducto
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
            btnGuardar = new Button();
            lblNombre = new Label();
            lblCategoria = new Label();
            txtNombre = new TextBox();
            txtCategoria = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            lblStock = new Label();
            dgvProductos = new DataGridView();
            btnActualizar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            pnlEncabezado = new Panel();
            pnlCampos = new Panel();
            tlpCampos = new TableLayoutPanel();
            pnlBotones = new Panel();
            flpBotones = new FlowLayoutPanel();
            chkLlevaItbis = new CheckBox();
            pnlTabla = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            pnlEncabezado.SuspendLayout();
            pnlCampos.SuspendLayout();
            tlpCampos.SuspendLayout();
            pnlBotones.SuspendLayout();
            flpBotones.SuspendLayout();
            pnlTabla.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(46, 125, 50);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 94, 32);
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 142, 60);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(24, 16);
            btnGuardar.Margin = new Padding(0, 0, 12, 0);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 44);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Añadir";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblNombre
            // 
            lblNombre.Dock = DockStyle.Fill;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(190, 190, 198);
            lblNombre.Location = new Point(217, 0);
            lblNombre.Margin = new Padding(5, 0, 5, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(202, 25);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
            lblNombre.Click += label1_Click;
            // 
            // lblCategoria
            // 
            lblCategoria.Dock = DockStyle.Fill;
            lblCategoria.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCategoria.ForeColor = Color.FromArgb(190, 190, 198);
            lblCategoria.Location = new Point(429, 0);
            lblCategoria.Margin = new Padding(5, 0, 5, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(202, 25);
            lblCategoria.TabIndex = 3;
            lblCategoria.Text = "Categoria";
            lblCategoria.TextAlign = ContentAlignment.MiddleLeft;
            lblCategoria.Click += label2_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(51, 51, 55);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Dock = DockStyle.Fill;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.ForeColor = Color.FromArgb(241, 241, 241);
            txtNombre.Location = new Point(217, 25);
            txtNombre.Margin = new Padding(5, 0, 5, 0);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(202, 34);
            txtNombre.TabIndex = 0;
            // 
            // txtCategoria
            // 
            txtCategoria.BackColor = Color.FromArgb(51, 51, 55);
            txtCategoria.BorderStyle = BorderStyle.FixedSingle;
            txtCategoria.Dock = DockStyle.Fill;
            txtCategoria.Font = new Font("Segoe UI", 10F);
            txtCategoria.ForeColor = Color.FromArgb(241, 241, 241);
            txtCategoria.Location = new Point(429, 25);
            txtCategoria.Margin = new Padding(5, 0, 5, 0);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(202, 34);
            txtCategoria.TabIndex = 1;
            // 
            // lblPrecio
            // 
            lblPrecio.Dock = DockStyle.Fill;
            lblPrecio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrecio.ForeColor = Color.FromArgb(190, 190, 198);
            lblPrecio.Location = new Point(641, 0);
            lblPrecio.Margin = new Padding(5, 0, 5, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(202, 25);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio";
            lblPrecio.TextAlign = ContentAlignment.MiddleLeft;
            lblPrecio.Click += label1_Click_1;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(51, 51, 55);
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Dock = DockStyle.Fill;
            txtPrecio.Font = new Font("Segoe UI", 10F);
            txtPrecio.ForeColor = Color.FromArgb(241, 241, 241);
            txtPrecio.Location = new Point(641, 25);
            txtPrecio.Margin = new Padding(5, 0, 5, 0);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(202, 34);
            txtPrecio.TabIndex = 2;
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.FromArgb(51, 51, 55);
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.Dock = DockStyle.Fill;
            txtStock.Font = new Font("Segoe UI", 10F);
            txtStock.ForeColor = Color.FromArgb(241, 241, 241);
            txtStock.Location = new Point(853, 25);
            txtStock.Margin = new Padding(5, 0, 5, 0);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(202, 34);
            txtStock.TabIndex = 3;
            // 
            // lblStock
            // 
            lblStock.Dock = DockStyle.Fill;
            lblStock.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStock.ForeColor = Color.FromArgb(190, 190, 198);
            lblStock.Location = new Point(853, 0);
            lblStock.Margin = new Padding(5, 0, 5, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(202, 25);
            lblStock.TabIndex = 8;
            lblStock.Text = "Stock";
            lblStock.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 45, 48);
            dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.FromArgb(37, 37, 38);
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(51, 51, 55);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(241, 241, 241);
            dataGridViewCellStyle2.Padding = new Padding(8, 4, 8, 4);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.ColumnHeadersHeight = 42;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(51, 51, 55);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(241, 241, 241);
            dataGridViewCellStyle3.Padding = new Padding(8, 4, 8, 4);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(36, 80, 115);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.Dock = DockStyle.Fill;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.GridColor = Color.FromArgb(63, 63, 70);
            dgvProductos.Location = new Point(24, 16);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.RowTemplate.Height = 36;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(1052, 368);
            dgvProductos.TabIndex = 7;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(33, 150, 243);
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 118, 210);
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(66, 165, 245);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(176, 16);
            btnActualizar.Margin = new Padding(0, 0, 12, 0);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(140, 44);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(198, 40, 40);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(183, 28, 28);
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 57, 53);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(328, 16);
            btnEliminar.Margin = new Padding(0, 0, 12, 0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 44);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(241, 241, 241);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(24, 0, 0, 0);
            label1.Size = new Size(1100, 70);
            label1.TabIndex = 12;
            label1.Text = "Registro de Productos";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCodigo
            // 
            lblCodigo.Dock = DockStyle.Fill;
            lblCodigo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCodigo.ForeColor = Color.FromArgb(190, 190, 198);
            lblCodigo.Location = new Point(5, 0);
            lblCodigo.Margin = new Padding(5, 0, 5, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(202, 25);
            lblCodigo.TabIndex = 13;
            lblCodigo.Text = "Codigo";
            lblCodigo.TextAlign = ContentAlignment.MiddleLeft;
            lblCodigo.Click += label2_Click_1;
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
            txtCodigo.Size = new Size(202, 34);
            txtCodigo.TabIndex = 14;
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.FromArgb(37, 37, 38);
            pnlEncabezado.Controls.Add(label1);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(1100, 70);
            pnlEncabezado.TabIndex = 15;
            // 
            // pnlCampos
            // 
            pnlCampos.BackColor = Color.FromArgb(37, 37, 38);
            pnlCampos.Controls.Add(tlpCampos);
            pnlCampos.Dock = DockStyle.Top;
            pnlCampos.Location = new Point(0, 70);
            pnlCampos.Name = "pnlCampos";
            pnlCampos.Padding = new Padding(20, 12, 20, 12);
            pnlCampos.Size = new Size(1100, 100);
            pnlCampos.TabIndex = 16;
            // 
            // tlpCampos
            // 
            tlpCampos.BackColor = Color.FromArgb(37, 37, 38);
            tlpCampos.ColumnCount = 5;
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpCampos.Controls.Add(lblCodigo, 0, 0);
            tlpCampos.Controls.Add(txtCodigo, 0, 1);
            tlpCampos.Controls.Add(lblNombre, 1, 0);
            tlpCampos.Controls.Add(txtNombre, 1, 1);
            tlpCampos.Controls.Add(lblCategoria, 2, 0);
            tlpCampos.Controls.Add(txtCategoria, 2, 1);
            tlpCampos.Controls.Add(lblPrecio, 3, 0);
            tlpCampos.Controls.Add(txtPrecio, 3, 1);
            tlpCampos.Controls.Add(lblStock, 4, 0);
            tlpCampos.Controls.Add(txtStock, 4, 1);
            tlpCampos.Dock = DockStyle.Fill;
            tlpCampos.Location = new Point(20, 12);
            tlpCampos.Name = "tlpCampos";
            tlpCampos.RowCount = 2;
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCampos.Size = new Size(1060, 76);
            tlpCampos.TabIndex = 0;
            // 
            // pnlBotones
            // 
            pnlBotones.BackColor = Color.FromArgb(37, 37, 38);
            pnlBotones.Controls.Add(flpBotones);
            pnlBotones.Dock = DockStyle.Bottom;
            pnlBotones.Location = new Point(0, 570);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(1100, 80);
            pnlBotones.TabIndex = 17;
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.FromArgb(37, 37, 38);
            flpBotones.Controls.Add(btnGuardar);
            flpBotones.Controls.Add(btnActualizar);
            flpBotones.Controls.Add(btnEliminar);
            flpBotones.Controls.Add(chkLlevaItbis);
            flpBotones.Dock = DockStyle.Fill;
            flpBotones.Location = new Point(0, 0);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new Padding(24, 16, 24, 16);
            flpBotones.Size = new Size(1100, 80);
            flpBotones.TabIndex = 0;
            flpBotones.WrapContents = false;
            // 
            // chkLlevaItbis
            // 
            chkLlevaItbis.AutoSize = true;
            chkLlevaItbis.Checked = true;
            chkLlevaItbis.CheckState = CheckState.Checked;
            chkLlevaItbis.Font = new Font("Segoe UI", 10F);
            chkLlevaItbis.ForeColor = Color.FromArgb(241, 241, 241);
            chkLlevaItbis.Location = new Point(492, 26);
            chkLlevaItbis.Margin = new Padding(12, 10, 0, 0);
            chkLlevaItbis.Name = "chkLlevaItbis";
            chkLlevaItbis.Size = new Size(129, 32);
            chkLlevaItbis.TabIndex = 8;
            chkLlevaItbis.Text = "Lleva ITBIS";
            chkLlevaItbis.UseVisualStyleBackColor = true;
            // 
            // pnlTabla
            // 
            pnlTabla.BackColor = Color.FromArgb(30, 30, 30);
            pnlTabla.Controls.Add(dgvProductos);
            pnlTabla.Dock = DockStyle.Fill;
            pnlTabla.Location = new Point(0, 170);
            pnlTabla.Name = "pnlTabla";
            pnlTabla.Padding = new Padding(24, 16, 24, 16);
            pnlTabla.Size = new Size(1100, 400);
            pnlTabla.TabIndex = 18;
            // 
            // frmRegistroProducto
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1100, 650);
            Controls.Add(pnlTabla);
            Controls.Add(pnlBotones);
            Controls.Add(pnlCampos);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(241, 241, 241);
            MinimumSize = new Size(1000, 580);
            Name = "frmRegistroProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Productos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            pnlEncabezado.ResumeLayout(false);
            pnlCampos.ResumeLayout(false);
            tlpCampos.ResumeLayout(false);
            tlpCampos.PerformLayout();
            pnlBotones.ResumeLayout(false);
            flpBotones.ResumeLayout(false);
            flpBotones.PerformLayout();
            pnlTabla.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnGuardar;
        private Label lblNombre;
        private Label lblCategoria;
        private TextBox txtNombre;
        private TextBox txtCategoria;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Label lblStock;
        private DataGridView dgvProductos;
        private Button btnActualizar;
        private Button btnEliminar;
        private Label label1;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Panel pnlEncabezado;
        private Panel pnlCampos;
        private TableLayoutPanel tlpCampos;
        private Panel pnlBotones;
        private FlowLayoutPanel flpBotones;
        private Panel pnlTabla;
        private CheckBox chkLlevaItbis;
    }
}
