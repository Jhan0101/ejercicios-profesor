namespace RegistroProductos
{
    partial class frmReportes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dtpFechas = new DateTimePicker();
            btnConslutar = new Button();
            dgvReportes = new DataGridView();
            cmbReportes = new ComboBox();
            cmbTipoPago = new ComboBox();
            lblTituloReportes = new Label();
            lblReporteUI = new Label();
            lblFechaUI = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // dtpFechas
            // 
            dtpFechas.CalendarForeColor = Color.FromArgb(241, 241, 241);
            dtpFechas.CalendarMonthBackground = Color.FromArgb(51, 51, 55);
            dtpFechas.CalendarTitleBackColor = Color.FromArgb(37, 37, 38);
            dtpFechas.CalendarTitleForeColor = Color.FromArgb(241, 241, 241);
            dtpFechas.CalendarTrailingForeColor = Color.FromArgb(190, 190, 198);
            dtpFechas.Font = new Font("Segoe UI", 10F);
            dtpFechas.Format = DateTimePickerFormat.Short;
            dtpFechas.Location = new Point(470, 162);
            dtpFechas.Margin = new Padding(4, 4, 4, 4);
            dtpFechas.Name = "dtpFechas";
            dtpFechas.Size = new Size(210, 34);
            dtpFechas.TabIndex = 0;
            // 
            // btnConslutar
            // 
            btnConslutar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConslutar.BackColor = Color.FromArgb(33, 150, 243);
            btnConslutar.Cursor = Cursors.Hand;
            btnConslutar.FlatAppearance.BorderSize = 0;
            btnConslutar.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 118, 210);
            btnConslutar.FlatAppearance.MouseOverBackColor = Color.FromArgb(66, 165, 245);
            btnConslutar.FlatStyle = FlatStyle.Flat;
            btnConslutar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConslutar.ForeColor = Color.White;
            btnConslutar.Location = new Point(1008, 156);
            btnConslutar.Margin = new Padding(4, 4, 4, 4);
            btnConslutar.Name = "btnConslutar";
            btnConslutar.Size = new Size(276, 60);
            btnConslutar.TabIndex = 1;
            btnConslutar.Text = "Consultar";
            btnConslutar.UseVisualStyleBackColor = false;
            btnConslutar.Click += btnConslutar_Click;
            // 
            // dgvReportes
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 45, 48);
            dgvReportes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReportes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReportes.ReadOnly = true;
            dgvReportes.AllowUserToAddRows = false;
            dgvReportes.AllowUserToDeleteRows = false;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportes.BackgroundColor = Color.FromArgb(37, 37, 38);
            dgvReportes.BorderStyle = BorderStyle.None;
            dgvReportes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReportes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(51, 51, 55);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(241, 241, 241);
            dataGridViewCellStyle2.Padding = new Padding(8, 4, 8, 4);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReportes.ColumnHeadersHeight = 42;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(51, 51, 55);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(241, 241, 241);
            dataGridViewCellStyle3.Padding = new Padding(8, 4, 8, 4);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(36, 80, 115);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvReportes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvReportes.EnableHeadersVisualStyles = false;
            dgvReportes.GridColor = Color.FromArgb(63, 63, 70);
            dgvReportes.Location = new Point(36, 240);
            dgvReportes.Margin = new Padding(4, 4, 4, 4);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.RowHeadersVisible = false;
            dgvReportes.RowHeadersWidth = 62;
            dgvReportes.RowTemplate.Height = 36;
            dgvReportes.Size = new Size(1248, 524);
            dgvReportes.TabIndex = 2;
            // 
            // cmbReportes
            // 
            cmbReportes.BackColor = Color.FromArgb(51, 51, 55);
            cmbReportes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportes.FlatStyle = FlatStyle.Flat;
            cmbReportes.Font = new Font("Segoe UI", 10F);
            cmbReportes.ForeColor = Color.FromArgb(241, 241, 241);
            cmbReportes.FormattingEnabled = true;
            cmbReportes.Items.AddRange(new object[] { "Cuadre del día", "Ventas por cajero", "Inventario en stock", "Facturas por tipo de pago", "Top cinco clientes" });
            cmbReportes.Location = new Point(36, 162);
            cmbReportes.Margin = new Padding(4, 4, 4, 4);
            cmbReportes.Name = "cmbReportes";
            cmbReportes.Size = new Size(410, 36);
            cmbReportes.TabIndex = 3;
            // 
            // cmbTipoPago
            // 
            cmbTipoPago.AccessibleName = "Tipo de pago";
            cmbTipoPago.BackColor = Color.FromArgb(51, 51, 55);
            cmbTipoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPago.FlatStyle = FlatStyle.Flat;
            cmbTipoPago.Font = new Font("Segoe UI", 10F);
            cmbTipoPago.ForeColor = Color.FromArgb(241, 241, 241);
            cmbTipoPago.FormattingEnabled = true;
            cmbTipoPago.Items.AddRange(new object[] { "Contado", "Credito" });
            cmbTipoPago.Location = new Point(704, 162);
            cmbTipoPago.Margin = new Padding(4, 4, 4, 4);
            cmbTipoPago.Name = "cmbTipoPago";
            cmbTipoPago.Size = new Size(280, 36);
            cmbTipoPago.TabIndex = 4;
            // 
            // lblTituloReportes
            // 
            lblTituloReportes.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTituloReportes.ForeColor = Color.FromArgb(241, 241, 241);
            lblTituloReportes.Location = new Point(36, 30);
            lblTituloReportes.Margin = new Padding(4, 0, 4, 0);
            lblTituloReportes.Name = "lblTituloReportes";
            lblTituloReportes.Size = new Size(1248, 72);
            lblTituloReportes.TabIndex = 0;
            lblTituloReportes.Text = "Reportes";
            // 
            // lblReporteUI
            // 
            lblReporteUI.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblReporteUI.ForeColor = Color.FromArgb(190, 190, 198);
            lblReporteUI.Location = new Point(36, 120);
            lblReporteUI.Margin = new Padding(4, 0, 4, 0);
            lblReporteUI.Name = "lblReporteUI";
            lblReporteUI.Size = new Size(410, 36);
            lblReporteUI.TabIndex = 1;
            lblReporteUI.Text = "Reporte";
            // 
            // lblFechaUI
            // 
            lblFechaUI.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaUI.ForeColor = Color.FromArgb(190, 190, 198);
            lblFechaUI.Location = new Point(470, 120);
            lblFechaUI.Margin = new Padding(4, 0, 4, 0);
            lblFechaUI.Name = "lblFechaUI";
            lblFechaUI.Size = new Size(210, 36);
            lblFechaUI.TabIndex = 2;
            lblFechaUI.Text = "Fecha";
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1320, 800);
            Controls.Add(lblTituloReportes);
            Controls.Add(lblReporteUI);
            Controls.Add(lblFechaUI);
            Controls.Add(cmbTipoPago);
            Controls.Add(cmbReportes);
            Controls.Add(dgvReportes);
            Controls.Add(btnConslutar);
            Controls.Add(dtpFechas);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(241, 241, 241);
            Margin = new Padding(4, 4, 4, 4);
            MinimumSize = new Size(1342, 700);
            Name = "frmReportes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblFechaUI;

        private Label lblReporteUI;

        private Label lblTituloReportes;

        private DateTimePicker dtpFechas;
        private Button btnConslutar;
        private DataGridView dgvReportes;
        private ComboBox cmbReportes;
        private ComboBox cmbTipoPago;
    }
}
