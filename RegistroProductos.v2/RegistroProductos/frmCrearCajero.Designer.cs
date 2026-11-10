namespace RegistroProductos
{
    partial class frmCrearCajero
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
            lblNombreUsuario = new Label();
            txtNombreUsuario = new TextBox();
            lblClave = new Label();
            txtClave = new TextBox();
            lblTurno = new Label();
            cmbTurno = new ComboBox();
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
            pnlFormulario.Size = new Size(452, 452);
            pnlFormulario.TabIndex = 0;
            // 
            // tlpFormulario
            // 
            tlpFormulario.BackColor = Color.FromArgb(37, 37, 38);
            tlpFormulario.ColumnCount = 1;
            tlpFormulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFormulario.Controls.Add(lblTitulo, 0, 0);
            tlpFormulario.Controls.Add(lblNombreUsuario, 0, 1);
            tlpFormulario.Controls.Add(txtNombreUsuario, 0, 2);
            tlpFormulario.Controls.Add(lblClave, 0, 3);
            tlpFormulario.Controls.Add(txtClave, 0, 4);
            tlpFormulario.Controls.Add(lblTurno, 0, 5);
            tlpFormulario.Controls.Add(cmbTurno, 0, 6);
            tlpFormulario.Controls.Add(btnGuardar, 0, 8);
            tlpFormulario.Dock = DockStyle.Fill;
            tlpFormulario.Location = new Point(24, 24);
            tlpFormulario.Name = "tlpFormulario";
            tlpFormulario.RowCount = 9;
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpFormulario.Size = new Size(404, 404);
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
            lblTitulo.Text = "Crear cajero";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.Dock = DockStyle.Fill;
            lblNombreUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombreUsuario.ForeColor = Color.FromArgb(190, 190, 198);
            lblNombreUsuario.Location = new Point(0, 64);
            lblNombreUsuario.Margin = new Padding(0);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(404, 28);
            lblNombreUsuario.TabIndex = 1;
            lblNombreUsuario.Text = "Nombre de usuario";
            lblNombreUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BackColor = Color.FromArgb(51, 51, 55);
            txtNombreUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtNombreUsuario.Dock = DockStyle.Fill;
            txtNombreUsuario.Font = new Font("Segoe UI", 10F);
            txtNombreUsuario.ForeColor = Color.FromArgb(241, 241, 241);
            txtNombreUsuario.Location = new Point(0, 92);
            txtNombreUsuario.Margin = new Padding(0, 0, 0, 16);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(404, 34);
            txtNombreUsuario.TabIndex = 0;
            // 
            // lblClave
            // 
            lblClave.Dock = DockStyle.Fill;
            lblClave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblClave.ForeColor = Color.FromArgb(190, 190, 198);
            lblClave.Location = new Point(0, 144);
            lblClave.Margin = new Padding(0);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(404, 28);
            lblClave.TabIndex = 2;
            lblClave.Text = "Clave";
            lblClave.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.FromArgb(51, 51, 55);
            txtClave.BorderStyle = BorderStyle.FixedSingle;
            txtClave.Dock = DockStyle.Fill;
            txtClave.Font = new Font("Segoe UI", 10F);
            txtClave.ForeColor = Color.FromArgb(241, 241, 241);
            txtClave.Location = new Point(0, 172);
            txtClave.Margin = new Padding(0, 0, 0, 16);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(404, 34);
            txtClave.TabIndex = 1;
            // 
            // lblTurno
            // 
            lblTurno.Dock = DockStyle.Fill;
            lblTurno.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTurno.ForeColor = Color.FromArgb(190, 190, 198);
            lblTurno.Location = new Point(0, 224);
            lblTurno.Margin = new Padding(0);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(404, 28);
            lblTurno.TabIndex = 3;
            lblTurno.Text = "Turno";
            lblTurno.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbTurno
            // 
            cmbTurno.BackColor = Color.FromArgb(51, 51, 55);
            cmbTurno.DisplayMember = "Dia";
            cmbTurno.Dock = DockStyle.Fill;
            cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTurno.FlatStyle = FlatStyle.Flat;
            cmbTurno.Font = new Font("Segoe UI", 10F);
            cmbTurno.ForeColor = Color.FromArgb(241, 241, 241);
            cmbTurno.FormattingEnabled = true;
            cmbTurno.Items.AddRange(new object[] { "Dia", "Tarde", "Noche" });
            cmbTurno.Location = new Point(0, 252);
            cmbTurno.Margin = new Padding(0, 0, 0, 16);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.Size = new Size(404, 36);
            cmbTurno.TabIndex = 2;
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
            btnGuardar.Location = new Point(0, 360);
            btnGuardar.Margin = new Padding(0);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(404, 44);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar cajero";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmCrearCajero
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(500, 500);
            Controls.Add(pnlFormulario);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(241, 241, 241);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmCrearCajero";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Crear cajero";
            pnlFormulario.ResumeLayout(false);
            tlpFormulario.ResumeLayout(false);
            tlpFormulario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFormulario;
        private TableLayoutPanel tlpFormulario;
        private Label lblTitulo;
        private Label lblNombreUsuario;
        private TextBox txtNombreUsuario;
        private Label lblClave;
        private TextBox txtClave;
        private Label lblTurno;
        private ComboBox cmbTurno;
        private Button btnGuardar;
    }
}
