namespace RegistroProductos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkGreen;
            btnGuardar.ForeColor = SystemColors.ButtonFace;
            btnGuardar.Location = new Point(76, 359);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 40);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Añadir";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Lavender;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(13, 42);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 28);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(13, 118);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(103, 28);
            lblCategoria.TabIndex = 3;
            lblCategoria.Text = "Categoria";
            lblCategoria.Click += label2_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(13, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(236, 34);
            txtNombre.TabIndex = 0;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(13, 149);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(236, 34);
            txtCategoria.TabIndex = 1;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(13, 194);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(71, 28);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio";
            lblPrecio.Click += label1_Click_1;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(13, 225);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(236, 34);
            txtPrecio.TabIndex = 2;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(13, 301);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(236, 34);
            txtStock.TabIndex = 3;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(13, 270);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(64, 28);
            lblStock.TabIndex = 8;
            lblStock.Text = "Stock";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.GhostWhite;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(294, 73);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(1082, 368);
            dgvProductos.TabIndex = 7;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.LightSlateGray;
            btnActualizar.ForeColor = SystemColors.ButtonFace;
            btnActualizar.Location = new Point(76, 405);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(110, 40);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(76, 451);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 40);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(659, 9);
            label1.Name = "label1";
            label1.Size = new Size(353, 45);
            label1.TabIndex = 12;
            label1.Text = "Registro de Productos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1407, 504);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(dgvProductos);
            Controls.Add(lblStock);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtCategoria);
            Controls.Add(txtNombre);
            Controls.Add(lblCategoria);
            Controls.Add(lblNombre);
            Controls.Add(btnGuardar);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Productos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}
