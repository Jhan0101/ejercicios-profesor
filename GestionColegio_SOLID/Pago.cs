namespace GestionColegio;

public class Pago
{
    public Estudiante estudiante {get;}
    public Padre Responsable {get;}
    public decimal Monto {get;}
    public DateOnly fecha {get;}
    public string Concepto {get;}

    public Pago(Estudiante estudiante, Padre responsable, decimal monto, DateOnly fecha, string concepto)
    {
        if (monto <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof (monto), "El monto debe ser positivo");
        }
        this.estudiante = estudiante;
        this.Responsable = responsable;
        this.Monto = monto;
        this.fecha = fecha;
        this.Concepto = concepto;
    }
}