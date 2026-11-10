using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroProductos
{
    public class Factura
    {
        public int UsuarioId { get; set; }
        public string TipoPago { get; set; }
        public decimal MontoPagado { get; set; }
        public decimal Devuelta { get; set; }
        public List<ItemFactura> Items { get; set; }
        public int? ClienteID { get; set; }
    }
}
