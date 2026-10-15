namespace videoformulario
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
            label1 = new Label();
            label2 = new Label();
            txtnombre = new TextBox();
            txtedad = new TextBox();
            btnguardar = new Button();
            btnlimpiar = new Button();
            grilla = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grilla).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 69);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre:  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 120);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 1;
            label2.Text = "Edad: ";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(164, 69);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(294, 31);
            txtnombre.TabIndex = 2;
            // 
            // txtedad
            // 
            txtedad.Location = new Point(164, 120);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(143, 31);
            txtedad.TabIndex = 3;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(538, 69);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(112, 82);
            btnguardar.TabIndex = 4;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(696, 69);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(112, 82);
            btnlimpiar.TabIndex = 5;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // grilla
            // 
            grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grilla.Location = new Point(77, 202);
            grilla.Name = "grilla";
            grilla.RowHeadersWidth = 62;
            grilla.Size = new Size(573, 225);
            grilla.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 480);
            Controls.Add(grilla);
            Controls.Add(btnlimpiar);
            Controls.Add(btnguardar);
            Controls.Add(txtedad);
            Controls.Add(txtnombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grilla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtnombre;
        private TextBox txtedad;
        private Button btnguardar;
        private Button btnlimpiar;
        private DataGridView grilla;
    }
}
