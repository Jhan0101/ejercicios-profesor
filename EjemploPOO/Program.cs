public class Program
{
    public static void Main()
    {
        Console.WriteLine("\n--- 1. Crear un producto ---");

        Producto producto = new Producto("Libro", 150m);
        producto.MostrarInformacion();

        Console.WriteLine("\n--- 2. Dos referencias al mismo objeto ---");

        Producto otroProducto = producto;
        otroProducto.CambiarPrecio(300m);

        producto.MostrarInformacion();

        Console.WriteLine("\n--- 3. Crear una copia independiente ---");

        Producto copia = new Producto(producto);
        copia.CambiarPrecio(500m);

        producto.MostrarInformacion("Producto original");
        producto.MostrarInformacion();
        copia.MostrarInformacion("Copia del producto");
        copia.MostrarInformacion();

        Console.WriteLine("\n--- 4. Herencia ---");

        Alimento leche = new Alimento("Leche", 75m, "10/12/2026");
        leche.MostrarInformacion();

        Console.WriteLine("\n--- 5. Polimorfismo y sobrecarga ---");

        Producto articulo = new Alimento("Pan", 50m, "15/12/2026");
        articulo.MostrarInformacion("Información del alimento");

        Console.WriteLine("\n--- 6. Contador estático ---");

        Console.WriteLine($"Productos creados: {Producto.TotalProductos}");
    }
}