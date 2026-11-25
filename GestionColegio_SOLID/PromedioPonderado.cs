namespace GestionColegio;

public class PromedioPonderado : ICalculoFinal
{
    public decimal Calcular(decimal primeraNota, decimal segundaNota)
    {
        return (primeraNota * 0.40m) + (segundaNota * 0.60m);
    }
}