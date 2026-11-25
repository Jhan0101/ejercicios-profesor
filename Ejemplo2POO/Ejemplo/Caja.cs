public class Caja
{
    public decimal CalcularTotal(IConPrecio[] articulos)
    {
        decimal total = 0m;

        foreach (IConPrecio articulo in articulos)
        {
            total += articulo.CalcularSubtotal();
        }

        return total;
    }
}
