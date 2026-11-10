namespace RegistroProductos
{
    partial class frmCLientes
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
            pnlFormulario = new Panel();
            tlpFormulario = new TableLayoutPanel();
            lblTitulo = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            Telefono = new Label();
            txtTelefono = new TextBox();
            btnGuardar = new Button();
            pnlFormulario.SuspendLayout();
            tlpFormulario.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFormulario
            // 
            pnlFormulario.Anchor = AnchorStyles.None;
            pnlFormulario.BackColor = Color.FromArgb(37, 37, 38);
            pnlFormulario.Controls.Add(tlpFormulario);
            pnlFormulario.Location = new Point(24, 24);
            pnlFormulario.Name = "pnlFormulario";
            pnlFormulario.Padding = new Padding(24);
            pnlFormulario.Size = new Size(452, 372);
            pnlFormulario.TabIndex = 0;
            // 
            // tlpFormulario
            // 
            tlpFormulario.BackColor = Color.FromArgb(37, 37, 38);
            tlpFormulario.ColumnCount = 1;
            tlpFormulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFormulario.Controls.Add(lblTitulo, 0, 0);
            tlpFormulario.Controls.Add(lblNombre, 0, 1);
            tlpFormulario.Controls.Add(txtNombre, 0, 2);
            tlpFormulario.Controls.Add(Telefono, 0, 3);
            tlpFormulario.Controls.Add(txtTelefono, 0, 4);
            tlpFormulario.Controls.Add(btnGuardar, 0, 6);
            tlpFormulario.Dock = DockStyle.Fill;
            tlpFormulario.Location = new Point(24, 24);
            tlpFormulario.Name = "tlpFormulario";
            tlpFormulario.RowCount = 7;
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpFormulario.Size = new Size(404, 324);
            tlpFormulario.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(241, 241, 241);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Margin = new Padding(0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(404, 64);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nuevo cliente";
            // 
            // lblNombre
            // 
            lblNombre.Dock = DockStyle.Fill;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(190, 190, 198);
            lblNombre.Location = new Point(0, 64);
            lblNombre.Margin = new Padding(0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(404, 28);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(51, 51, 55);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Dock = DockStyle.Fill;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.ForeColor = Color.FromArgb(241, 241, 241);
            txtNombre.Location = new Point(0, 92);
            txtNombre.Margin = new Padding(0, 0, 0, 16);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(404, 34);
            txtNombre.TabIndex = 0;
            // 
            // Telefono
            // 
            Telefono.Dock = DockStyle.Fill;
            Telefono.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Telefono.ForeColor = Color.FromArgb(190, 190, 198);
            Telefono.Location = new Point(0, 144);
            Telefono.Margin = new Padding(0);
            Telefono.Name = "Telefono";
            Telefono.Size = new Size(404, 28);
            Telefono.TabIndex = 3;
            Telefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(51, 51, 55);
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Dock = DockStyle.Fill;
            txtTelefono.Font = new Font("Segoe UI", 10F);
            txtTelefono.ForeColor = Color.FromArgb(241, 241, 241);
            txtTelefono.Location = new Point(0, 172);
            txtTelefono.Margin = new Padding(0, 0, 0, 16);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(404, 34);
            txtTelefono.TabIndex = 2;
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
            btnGuardar.Location = new Point(0, 280);
            btnGuardar.Margin = new Padding(0);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(404, 44);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar cliente";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmCLientes
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(500, 420);
            Controls.Add(pnlFormulario);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(241, 241, 241);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmCLientes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo cliente";
            Load += frmCLientes_Load;
            pnlFormulario.ResumeLayout(false);
            tlpFormulario.ResumeLayout(false);
            tlpFormulario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFormulario;
        private TableLayoutPanel tlpFormulario;
        private Label lblTitulo;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtTelefono;
        private Label Telefono;
        private Button btnGuardar;
    }
}
