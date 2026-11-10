namespace RegistroProductos
{
    partial class frmLogin
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            btnEntrar = new Button();
            lblUsuario = new Label();
            lblClave = new Label();
            pnlTarjeta = new Panel();
            tlpLogin = new TableLayoutPanel();
            lblTitulo = new Label();
            pnlTarjeta.SuspendLayout();
            tlpLogin.SuspendLayout();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(51, 51, 55);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Dock = DockStyle.Fill;
            txtUsuario.Font = new Font("Segoe UI", 10F);
            txtUsuario.ForeColor = Color.FromArgb(241, 241, 241);
            txtUsuario.Location = new Point(0, 105);
            txtUsuario.Margin = new Padding(0);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(320, 34);
            txtUsuario.TabIndex = 0;
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.FromArgb(51, 51, 55);
            txtClave.BorderStyle = BorderStyle.FixedSingle;
            txtClave.Dock = DockStyle.Fill;
            txtClave.Font = new Font("Segoe UI", 10F);
            txtClave.ForeColor = Color.FromArgb(241, 241, 241);
            txtClave.Location = new Point(0, 182);
            txtClave.Margin = new Padding(0);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(320, 34);
            txtClave.TabIndex = 1;
            txtClave.UseSystemPasswordChar = true;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(33, 150, 243);
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.Dock = DockStyle.Top;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 118, 210);
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(66, 165, 245);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(0, 244);
            btnEntrar.Margin = new Padding(0, 10, 0, 0);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(320, 44);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Dock = DockStyle.Fill;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(190, 190, 198);
            lblUsuario.Location = new Point(0, 80);
            lblUsuario.Margin = new Padding(0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(320, 25);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            lblUsuario.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Dock = DockStyle.Fill;
            lblClave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblClave.ForeColor = Color.FromArgb(190, 190, 198);
            lblClave.Location = new Point(0, 157);
            lblClave.Margin = new Padding(0);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(320, 25);
            lblClave.TabIndex = 4;
            lblClave.Text = "Clave";
            lblClave.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pnlTarjeta
            // 
            pnlTarjeta.Anchor = AnchorStyles.None;
            pnlTarjeta.BackColor = Color.FromArgb(37, 37, 38);
            pnlTarjeta.Controls.Add(tlpLogin);
            pnlTarjeta.Location = new Point(32, 40);
            pnlTarjeta.Name = "pnlTarjeta";
            pnlTarjeta.Padding = new Padding(28);
            pnlTarjeta.Size = new Size(376, 380);
            pnlTarjeta.TabIndex = 5;
            pnlTarjeta.Paint += pnlTarjeta_Paint;
            // 
            // tlpLogin
            // 
            tlpLogin.BackColor = Color.FromArgb(37, 37, 38);
            tlpLogin.ColumnCount = 1;
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpLogin.Controls.Add(lblTitulo, 0, 0);
            tlpLogin.Controls.Add(lblUsuario, 0, 1);
            tlpLogin.Controls.Add(txtUsuario, 0, 2);
            tlpLogin.Controls.Add(lblClave, 0, 3);
            tlpLogin.Controls.Add(txtClave, 0, 4);
            tlpLogin.Controls.Add(btnEntrar, 0, 5);
            tlpLogin.Dock = DockStyle.Fill;
            tlpLogin.Location = new Point(28, 28);
            tlpLogin.Name = "tlpLogin";
            tlpLogin.RowCount = 6;
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpLogin.Size = new Size(320, 324);
            tlpLogin.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(241, 241, 241);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Margin = new Padding(0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(320, 80);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Bienvenido";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(440, 460);
            Controls.Add(pnlTarjeta);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(241, 241, 241);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar sesión";
            pnlTarjeta.ResumeLayout(false);
            tlpLogin.ResumeLayout(false);
            tlpLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Button btnEntrar;
        private Label lblUsuario;
        private Label lblClave;
        private Panel pnlTarjeta;
        private TableLayoutPanel tlpLogin;
        private Label lblTitulo;
    }
}
