using System;

public class Program
{
    public static void Main()
    {
        Producto cuaderno = new Producto(
            "Cuaderno", Categoria.Papeleria, 150m, new Cantidad(1));

        Producto lapices = new Producto(
            "Lápiz", Categoria.Papeleria, 20m, new Cantidad(2));

        ProductoEnOferta oferta = new ProductoEnOferta(lapices);

        IConPrecio[] compra = { cuaderno, oferta };

        Caja caja = new Caja();

        Console.WriteLine($"{cuaderno.Nombre} ({cuaderno.Categoria}): RD$ {cuaderno.CalcularSubtotal():F2}");
        Console.WriteLine($"{lapices.Nombre} en oferta: RD$ {oferta.CalcularSubtotal():F2}");
        Console.WriteLine($"Total: RD$ {caja.CalcularTotal(compra):F2}");
    }
}