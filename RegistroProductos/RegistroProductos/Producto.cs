using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroProductos
{
    public class Producto
    {
       public int ID { get; set; }
       public string Nombre { get; set; }
       public string Categoria { get; set; }
       public decimal Precio { get; set; }
       public int Stock { get; set; }
       public DateTime FechaRegistro { get; set; }

    }
}
