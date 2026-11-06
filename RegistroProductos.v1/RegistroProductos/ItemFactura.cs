using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroProductos
{
    public class ItemFactura
    {
        public int ProductoID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal => Cantidad * Precio;
        public bool LlevaItbis { get; set; }
        public decimal Itbis => LlevaItbis ? SubTotal * 0.18m : 0m;
    }
}
