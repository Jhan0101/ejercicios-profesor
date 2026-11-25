namespace GestionColegio;

public class Calificacion
{
    public Estudiante estudiante {get;}
    public Asignatura asignatura {get;}
    public string Evaluacion {get;}
    public decimal Nota {get;}

    public Calificacion(Estudiante estudiante, Asignatura asignatura, string evaluacion, decimal nota)
    {

        if (nota < 0 || nota > 100)
        {
            throw new ArgumentOutOfRangeException(nameof (nota), "La nota tiene que estar entre 0 y 100.");
        }
        this.estudiante = estudiante;
        this.asignatura = asignatura;
        this.Evaluacion = evaluacion;
        this.Nota = nota;
    }
}