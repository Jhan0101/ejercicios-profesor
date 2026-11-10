using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RegistroProductos
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void btnConslutar_Click(object sender, EventArgs e)
        {
            ReporteDAO dao = new ReporteDAO();
           if (cmbReportes.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un reporte.");
                return;
            }

            switch (cmbReportes.SelectedIndex)
            {
                case 0:
                    dgvReportes.DataSource = dao.ObtenerCuadreDia(dtpFechas.Value);
                    break;
                case 1:
                    dgvReportes.DataSource = dao.ObtenerVentaPorCajero(dtpFechas.Value);
                    break;
                case 2:
                    dgvReportes.DataSource = dao.ObtenerInventarioStock();
                    break;
                case 3:
                    if (cmbTipoPago.SelectedIndex < 0)
                    {
                        MessageBox.Show("Seleccione un metodo de pago.");
                        return;
                    }
                    dgvReportes.DataSource = dao.ObtenerFacturasPorTipoPago(dtpFechas.Value, cmbTipoPago.Text);
                    break;
                case 4:
                    dgvReportes.DataSource = dao.ObtenerTopClientes();
                    break;

            }
        }
    }
}
