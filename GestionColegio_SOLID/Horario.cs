namespace GestionColegio;

public class Horario
{
    public Curso Curso {get;}
    public Asignatura Asignatura {get;}
    public Profesor Profesor {get;}
    public Aula Aula {get;}

    public DayOfWeek Dia {get;}
    public TimeOnly Inicio {get;}
    public TimeOnly Fin {get;}


public Horario(Curso curso, Asignatura asignatura, Profesor profesor, Aula aula,
                DayOfWeek dia, TimeOnly inicio, TimeOnly fin)
    {
        if (fin <= inicio)
        {
            throw new ArgumentException("La hora de fin debe de ser posterior a la de inicio.", nameof(fin));
        }
        this.Curso = curso;
        this.Asignatura = asignatura;
        this.Profesor = profesor;
        this.Aula = aula;

        this.Dia = dia;
        this.Inicio = inicio;
        this.Fin = fin;

    }
}