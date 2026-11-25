using GestionColegio;

public class Estudiante : Persona
{
    public string Matricula { get; }

    public Estudiante(int id, string nombre, string apellido, string matricula)
        : base(id, nombre, apellido)
    {
        Matricula = matricula;
    }
}

