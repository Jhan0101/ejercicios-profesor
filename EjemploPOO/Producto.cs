public class Producto
{
    public string Nombre {get; set;}
    public decimal Precio {get; private set;}
    public static int TotalProductos {get; set;}

    static Producto()
    {
        TotalProductos = 0;
        Console.WriteLine("Contador de libros preparado");
    }

    public Producto(string nombre, decimal precio)
    {
        this.Nombre = nombre;
        this.Precio = precio;
        TotalProductos++;
    }
    public Producto(string nombre) : this(nombre, 0m)
    {
    }

    public Producto(Producto producto)
    {
        Nombre = producto.Nombre;
        Precio = producto.Precio;
        TotalProductos++;
    }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"El nombre del producto: {Nombre}");
        Console.WriteLine($"El precio del producto: {Precio}");
    }

    public void CambiarPrecio(decimal nuevoPrecio)
    {
        if (nuevoPrecio > 0)
        {
            Precio = nuevoPrecio;
        }
    }

    public void MostrarInformacion(string mensaje)
    {
        Console.WriteLine(mensaje);
    }
}