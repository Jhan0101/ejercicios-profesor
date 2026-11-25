public class Producto : IConPrecio
{
    public string Nombre { get; }
    public Categoria Categoria { get; }

    private readonly decimal precioUnitario;
    private readonly Cantidad cantidad;

    public Producto(string nombre, Categoria categoria, decimal precioUnitario,
                    Cantidad cantidad)
    {
        Nombre = nombre;
        Categoria = categoria;
        this.precioUnitario = precioUnitario;
        this.cantidad = cantidad;
    }

    public decimal CalcularSubtotal()
    {
        return precioUnitario * cantidad.Unidades;
    }
}