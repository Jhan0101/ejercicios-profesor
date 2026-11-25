namespace GestionColegio;

    public abstract class Persona
    {
        public int Id { get; }
        public string Nombre { get; }
        public string Apellido { get; }

        protected Persona(int id, string nombre, string apellido)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
        }
    }

