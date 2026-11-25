using GestionColegio;

public class Administrativo : Persona
{
    public string Cargo {get; private set;}

    public Administrativo(int id, string nombre, string apellido, string cargo)
        : base (id, nombre, apellido)
    {
        Cargo = cargo;
    }

    public void CambiarCargo(string nuevoCargo)
    {
        Cargo = nuevoCargo;
    }
}