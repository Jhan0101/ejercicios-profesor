public class Alimento : Producto
{
    public string FechaVencimiento {get; set;}

    public Alimento(string nombre, decimal precio, string fechaVencimiento) : base(nombre, precio)
    {
        this.FechaVencimiento = fechaVencimiento;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Fecha de vencimiento: {FechaVencimiento}");
    }
}