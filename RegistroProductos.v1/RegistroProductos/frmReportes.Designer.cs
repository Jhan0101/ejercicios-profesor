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
            dtpFechas = new DateTimePicker();
            btnConslutar = new Button();
            dgvReportes = new DataGridView();
            cmbReportes = new ComboBox();
            cmbTipoPago = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            lblTituloReportes = new Label();
            lblReporteUI = new Label();
            lblFechaUI = new Label();
            SuspendLayout();
            //
            // dtpFechas
            //
            dtpFechas.CalendarTrailingForeColor = Color.FromArgb(190, 190, 198);
            dtpFechas.CalendarTitleForeColor = Color.FromArgb(241, 241, 241);
            dtpFechas.CalendarTitleBackColor = Color.FromArgb(37, 37, 38);
            dtpFechas.CalendarForeColor = Color.FromArgb(241, 241, 241);
            dtpFechas.CalendarMonthBackground = Color.FromArgb(51, 51, 55);
            dtpFechas.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            dtpFechas.Format = DateTimePickerFormat.Short;
            dtpFechas.Location = new Point(388, 108);
            dtpFechas.Name = "dtpFechas";
            dtpFechas.Size = new Size(160, 32);
            dtpFechas.TabIndex = 0;
            //
            // btnConslutar
            //
            btnConslutar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConslutar.Cursor = Cursors.Hand;
            btnConslutar.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 118, 210);
            btnConslutar.FlatAppearance.MouseOverBackColor = Color.FromArgb(66, 165, 245);
            btnConslutar.FlatAppearance.BorderSize = 0;
            btnConslutar.FlatStyle = FlatStyle.Flat;
            btnConslutar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConslutar.ForeColor = Color.White;
            btnConslutar.BackColor = Color.FromArgb(33, 150, 243);
            btnConslutar.Location = new Point(832, 104);
            btnConslutar.Name = "btnConslutar";
            btnConslutar.Size = new Size(184, 40);
            btnConslutar.TabIndex = 1;
            btnConslutar.Text = "Consultar";
            btnConslutar.UseVisualStyleBackColor = false;
            btnConslutar.Click += btnConslutar_Click;
            //
            // dgvReportes
            //
            dgvReportes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReportes.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 4, 8, 4);
            dgvReportes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvReportes.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(241, 241, 241);
            dgvReportes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 55);
            dgvReportes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgvReportes.DefaultCellStyle.Padding = new Padding(8, 4, 8, 4);
            dgvReportes.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvReportes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(36, 80, 115);
            dgvReportes.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            dgvReportes.DefaultCellStyle.ForeColor = Color.FromArgb(241, 241, 241);
            dgvReportes.DefaultCellStyle.BackColor = Color.FromArgb(51, 51, 55);
            dgvReportes.RowTemplate.Height = 36;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportes.RowHeadersVisible = false;
            dgvReportes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReportes.ColumnHeadersHeight = 42;
            dgvReportes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReportes.EnableHeadersVisualStyles = false;
            dgvReportes.GridColor = Color.FromArgb(63, 63, 70);
            dgvReportes.BorderStyle = BorderStyle.None;
            dgvReportes.BackgroundColor = Color.FromArgb(37, 37, 38);
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvReportes.Location = new Point(24, 176);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.RowHeadersWidth = 62;
            dgvReportes.Size = new Size(992, 440);
            dgvReportes.TabIndex = 2;
            //
            // cmbReportes
            //
            cmbReportes.FlatStyle = FlatStyle.Flat;
            cmbReportes.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            cmbReportes.ForeColor = Color.FromArgb(241, 241, 241);
            cmbReportes.BackColor = Color.FromArgb(51, 51, 55);
            cmbReportes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportes.FormattingEnabled = true;
            cmbReportes.Items.AddRange(new object[] { "Cuadre del día", "Ventas por cajero", "Inventario en stock", "Facturas por tipo de pago", "Top cinco clientes" });
            cmbReportes.Location = new Point(24, 108);
            cmbReportes.Name = "cmbReportes";
            cmbReportes.Size = new Size(340, 32);
            cmbReportes.TabIndex = 3;
            //
            // cmbTipoPago
            //
            cmbTipoPago.AccessibleName = "Tipo de pago";
            cmbTipoPago.FlatStyle = FlatStyle.Flat;
            cmbTipoPago.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            cmbTipoPago.ForeColor = Color.FromArgb(241, 241, 241);
            cmbTipoPago.BackColor = Color.FromArgb(51, 51, 55);
            cmbTipoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPago.FormattingEnabled = true;
            cmbTipoPago.Items.AddRange(new object[] { "Contado", "Credito" });
            cmbTipoPago.Location = new Point(572, 108);
            cmbTipoPago.Name = "cmbTipoPago";
            cmbTipoPago.Size = new Size(236, 32);
            cmbTipoPago.TabIndex = 4;
            //
            // lblTituloReportes
            //
            lblTituloReportes.Name = "lblTituloReportes";
            lblTituloReportes.Text = "Reportes";
            lblTituloReportes.Location = new Point(24, 20);
            lblTituloReportes.Size = new Size(800, 48);
            lblTituloReportes.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTituloReportes.ForeColor = Color.FromArgb(241, 241, 241);
            Controls.Add(lblTituloReportes);
            //
            // lblReporteUI
            //
            lblReporteUI.Name = "lblReporteUI";
            lblReporteUI.Text = "Reporte";
            lblReporteUI.Location = new Point(24, 80);
            lblReporteUI.Size = new Size(340, 24);
            lblReporteUI.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblReporteUI.ForeColor = Color.FromArgb(190, 190, 198);
            Controls.Add(lblReporteUI);
            //
            // lblFechaUI
            //
            lblFechaUI.Name = "lblFechaUI";
            lblFechaUI.Text = "Fecha";
            lblFechaUI.Location = new Point(388, 80);
            lblFechaUI.Size = new Size(160, 24);
            lblFechaUI.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaUI.ForeColor = Color.FromArgb(190, 190, 198);
            Controls.Add(lblFechaUI);
            //
            // frmReportes
            //
            StartPosition = FormStartPosition.CenterParent;
            MinimumSize = new Size(1064, 580);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            ForeColor = Color.FromArgb(241, 241, 241);
            BackColor = Color.FromArgb(30, 30, 30);
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1040, 640);
            Controls.Add(cmbTipoPago);
            Controls.Add(cmbReportes);
            Controls.Add(dgvReportes);
            Controls.Add(btnConslutar);
            Controls.Add(dtpFechas);
            Name = "frmReportes";
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
