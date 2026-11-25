using GestionColegio;

public class ServicioCalificaciones
{
    private readonly ICalculoFinal calculo;

    public ServicioCalificaciones(ICalculoFinal calculo)
    {
        ArgumentNullException.ThrowIfNull(calculo);
        this.calculo = calculo;
    }

    public decimal CalcularNotaFinal(Calificacion primera, Calificacion segunda)
    {
        if (primera.estudiante != primera.estudiante || segunda.estudiante != segunda.estudiante)
        {
            throw new ArgumentException("Las notas deben corresponder al mismo estudiante.");
        }

        return this.calculo.Calcular(primera.Nota, segunda.Nota);
    }
}