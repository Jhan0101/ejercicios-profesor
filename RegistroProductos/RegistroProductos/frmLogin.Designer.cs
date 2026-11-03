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
            pnlTarjeta.SuspendLayout();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(99, 102);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(165, 34);
            txtUsuario.TabIndex = 0;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(99, 189);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(165, 34);
            txtClave.TabIndex = 1;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(114, 297);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(123, 38);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(99, 71);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(79, 28);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(99, 158);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(59, 28);
            lblClave.TabIndex = 4;
            lblClave.Text = "Clave";
            // 
            // pnlTarjeta
            // 
            pnlTarjeta.Anchor = AnchorStyles.None;
            pnlTarjeta.BackColor = Color.White;
            pnlTarjeta.Controls.Add(tlpLogin);
            pnlTarjeta.Location = new Point(40, 40);
            pnlTarjeta.Name = "pnlTarjeta";
            pnlTarjeta.Padding = new Padding(25);
            pnlTarjeta.Size = new Size(320, 340);
            pnlTarjeta.TabIndex = 5;
            // 
            // tlpLogin
            // 
            tlpLogin.ColumnCount = 1;
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLogin.Dock = DockStyle.Fill;
            tlpLogin.Location = new Point(25, 25);
            tlpLogin.Name = "tlpLogin";
            tlpLogin.RowCount = 6;
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpLogin.Size = new Size(270, 290);
            tlpLogin.TabIndex = 0;
            // 
            // frmLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(378, 404);
            Controls.Add(pnlTarjeta);
            Controls.Add(lblClave);
            Controls.Add(lblUsuario);
            Controls.Add(btnEntrar);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar sesion";
            pnlTarjeta.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
    }
}