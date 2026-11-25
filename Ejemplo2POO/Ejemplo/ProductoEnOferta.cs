public class ProductoEnOferta : IConPrecio
{
    private readonly Producto producto;

    public ProductoEnOferta(Producto producto)
    {
        this.producto = producto;
    }

    public decimal CalcularSubtotal()
    {
        // Cobrar el 90 % equivale a aplicar un 10 % de descuento.
        return producto.CalcularSubtotal() * 0.90m;
    }
}