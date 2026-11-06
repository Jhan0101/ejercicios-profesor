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
            txtNombreUsuario = new TextBox();
            txtClave = new TextBox();
            cmbTurno = new ComboBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(132, 136);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(150, 31);
            txtNombreUsuario.TabIndex = 0;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(132, 230);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(150, 31);
            txtClave.TabIndex = 1;
            // 
            // cmbTurno
            // 
            cmbTurno.DisplayMember = "Dia";
            cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTurno.FormattingEnabled = true;
            cmbTurno.Items.AddRange(new object[] { "Dia", "Tarde", "Noche" });
            cmbTurno.Location = new Point(371, 136);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.Size = new Size(182, 33);
            cmbTurno.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(357, 228);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(258, 34);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar cajero";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmCrearCajero
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(cmbTurno);
            Controls.Add(txtClave);
            Controls.Add(txtNombreUsuario);
            Name = "frmCrearCajero";
            Text = "frmCrearCajero";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreUsuario;
        private TextBox txtClave;
        private ComboBox cmbTurno;
        private Button btnGuardar;
    }
}