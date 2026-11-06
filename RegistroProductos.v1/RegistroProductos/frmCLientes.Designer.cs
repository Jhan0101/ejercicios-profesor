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
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtTelefono = new TextBox();
            Telefono = new Label();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(93, 98);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(93, 70);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(93, 204);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 31);
            txtTelefono.TabIndex = 2;
            // 
            // Telefono
            // 
            Telefono.AutoSize = true;
            Telefono.Location = new Point(93, 176);
            Telefono.Name = "Telefono";
            Telefono.Size = new Size(79, 25);
            Telefono.TabIndex = 3;
            Telefono.Text = "Telefono";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(48, 282);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(266, 34);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar cliente";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmCLientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 450);
            Controls.Add(btnGuardar);
            Controls.Add(Telefono);
            Controls.Add(txtTelefono);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Name = "frmCLientes";
            Text = "frmCLientes";
            Load += frmCLientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtTelefono;
        private Label Telefono;
        private Button btnGuardar;
    }
}