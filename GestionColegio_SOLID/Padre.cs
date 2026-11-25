using System.Runtime.CompilerServices;
namespace GestionColegio;

public class Padre : Persona
{
    private readonly List<Estudiante> hijos = new List<Estudiante>();

    public IReadOnlyList<Estudiante> Hijos
    {
        get {return this.hijos.AsReadOnly();}
    }

    public Padre (int id , string nombre, string apellido)
        : base (id, nombre, apellido)
    {
    }

    public void AgregarHijo(Estudiante estudiante)
    {
        this.hijos.Add(estudiante);
    }
}