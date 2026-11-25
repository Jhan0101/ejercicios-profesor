namespace GestionColegio;

public class Curso
{
    private readonly List<Estudiante> estudiantes = new List<Estudiante>();

    public string Periodo {get;}
    public string Nombre {get;}

    public IReadOnlyList<Estudiante> Estudiantes
    {
        get {return this.estudiantes.AsReadOnly();}
    }
    public Curso(string nombre, string periodo)
    {
        this.Nombre = nombre;
        this.Periodo = periodo;
    }

    public void InscribirEstudiante(Estudiante estudiante)
    {
        ArgumentNullException.ThrowIfNull(estudiante);

        foreach(Estudiante inscrito in estudiantes)
        {
            if (inscrito.Matricula == estudiante.Matricula)
            {
                return;
            }
        }

        this.estudiantes.Add(estudiante);
    }
}