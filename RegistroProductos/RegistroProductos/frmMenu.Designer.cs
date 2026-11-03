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
            SuspendLayout();
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(306, 101);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(112, 34);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnFacturas
            // 
            btnFacturas.Location = new Point(306, 190);
            btnFacturas.Name = "btnFacturas";
            btnFacturas.Size = new Size(112, 34);
            btnFacturas.TabIndex = 1;
            btnFacturas.Text = "Facturas";
            btnFacturas.UseVisualStyleBackColor = true;
            btnFacturas.Click += btnFacturas_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFacturas);
            Controls.Add(btnProductos);
            Name = "frmMenu";
            Text = "frmMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProductos;
        private Button btnFacturas;
    }
}