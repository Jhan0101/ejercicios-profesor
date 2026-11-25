namespace GestionColegio;

public class Asignatura
{
    public string Codigo {get;}
    public string Nombre {get;}

    public Asignatura(string codigo, string nombre)
    {
        this.Codigo = codigo;
        this.Nombre = nombre;
    }
}