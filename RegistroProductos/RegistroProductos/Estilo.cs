using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroProductos
{
    public static class Estilo
    {
        public static readonly Color Primario = Color.FromArgb(0, 120, 215);
        public static readonly Color Fondo = Color.FromArgb(245, 245, 245);
        public static readonly Color Texto = Color.FromArgb(40, 40, 40);
        public static readonly Color Campo = Color.FromArgb(255, 255, 255);
        public static Font Fuente => new Font("Segoe UI", 10);
        public static void AplicarBoton(Button b)
        {
            b.BackColor = Primario;
            b.ForeColor = Color.White;
            b.FlatStyle = FlatStyle.Flat;
        }

        public static void AplicarTextBox(TextBox t)
        {
            t.BackColor = Campo;
            t.ForeColor = Texto;
            t.Font = Fuente;
            t.BorderStyle = BorderStyle.FixedSingle;
        }

        public static void AplicarTabla(DataGridView d)
        {
            d.EnableHeadersVisualStyles = false;
            d.ColumnHeadersDefaultCellStyle.BackColor = Campo;
            d.ColumnHeadersDefaultCellStyle.ForeColor = Texto;
            d.DefaultCellStyle.BackColor = Campo;
            d.DefaultCellStyle.ForeColor = Texto;
            d.RowHeadersVisible = false;
        }

        public static void Aplicar(Form f)
        {
            f.BackColor = Fondo;

            foreach (Control c in f.Controls)
            {
                switch (c)
                {
                    case Button b:
                        AplicarBoton(b);
                        break;
                    case Label l:
                        l.ForeColor = Texto;
                        l.Font = Fuente;
                        break;
                    case TextBox t:
                        AplicarTextBox(t);
                        break;
                    case DataGridView d:
                        AplicarTabla(d);
                        break;

                }
            }
        }
    }
}
