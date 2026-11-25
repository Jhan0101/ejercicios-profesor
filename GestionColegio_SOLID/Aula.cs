using GestionColegio;

public class Aula
{
    public int Capacidad {get;}
    public string Codigo {get;} 

    public Aula( string codigo, int capacidad)
    {
        if (capacidad <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof (capacidad), "La capacidad debe ser mayor a 0.");
        }

        this.Codigo = codigo;
        this.Capacidad = capacidad;
    }
}