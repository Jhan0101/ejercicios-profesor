using GestionColegio;

public class Profesor : Persona
{
    public string Materia { get; }

    public Profesor(int id, string nombre, string apellido, string materia)
        : base(id, nombre, apellido)
    {
        Materia = materia;
    }
}