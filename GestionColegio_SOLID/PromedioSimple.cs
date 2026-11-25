namespace GestionColegio;

public class PromedioSimple : ICalculoFinal
{
    public decimal Calcular(decimal primeraNota, decimal segundaNota)
    {
        return (primeraNota + segundaNota) / 2;
    }
}