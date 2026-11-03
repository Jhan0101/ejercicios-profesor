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
            txtCodigo = new TextBox();
            nuCantidad = new NumericUpDown();
            dgvCarrito = new DataGridView();
            lblCodigo = new Label();
            lblCantidad = new Label();
            btnAgregar = new Button();
            lblTotal = new Label();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)nuCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(78, 99);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(150, 31);
            txtCodigo.TabIndex = 0;
            // 
            // nuCantidad
            // 
            nuCantidad.Location = new Point(282, 100);
            nuCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nuCantidad.Name = "nuCantidad";
            nuCantidad.Size = new Size(180, 31);
            nuCantidad.TabIndex = 1;
            nuCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(71, 376);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 62;
            dgvCarrito.Size = new Size(876, 225);
            dgvCarrito.TabIndex = 2;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(78, 71);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(71, 25);
            lblCodigo.TabIndex = 3;
            lblCodigo.Text = "Codigo";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(280, 69);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(83, 25);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(78, 172);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 15F);
            lblTotal.Location = new Point(850, 332);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(81, 41);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total";
            lblTotal.Click += lblTotal_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(282, 172);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(151, 86);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar factura";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmFactura
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 674);
            Controls.Add(btnGuardar);
            Controls.Add(lblTotal);
            Controls.Add(btnAgregar);
            Controls.Add(lblCantidad);
            Controls.Add(lblCodigo);
            Controls.Add(dgvCarrito);
            Controls.Add(nuCantidad);
            Controls.Add(txtCodigo);
            KeyPreview = true;
            Name = "frmFactura";
            Text = "frmFactura";
            KeyDown += frmFactura_KeyDown;
            ((System.ComponentModel.ISupportInitialize)nuCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}