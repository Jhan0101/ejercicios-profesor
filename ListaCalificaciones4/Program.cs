using System;
using System.ComponentModel;

class Estudiante
{
    public string nombre;
    public string apellido;
    public int nota1;
    public int nota2;
    public int nota3;
    public int nota4;

    public double promedio;
    public char literal;
    public int matricula;
    public string curso;



    public static void GuardarArchivo(List<Estudiante> lista)
    {
        List<string> lineas = new List<string>();

        foreach (Estudiante e in lista)
        {
            lineas.Add($"{e.nombre};{e.apellido};{e.matricula};{e.curso};{e.nota1};{e.nota2};{e.nota3};{e.nota4}");
        }

        File.WriteAllLines("Estudiantes.txt", lineas);
    }

    public static List<Estudiante> CargarArchivo()
    {
        List<Estudiante> lista = new List<Estudiante>();

        if (!File.Exists("Estudiantes.txt")) return lista;

        foreach (string lineas in File.ReadAllLines("Estudiantes.txt"))
        {
            string[] partes = lineas.Split(';');

            Estudiante e = new Estudiante();
            e.nombre = partes[0];
            e.apellido = partes[1];
            e.matricula = int.Parse(partes[2]);
            e.curso = partes[3];
            e.nota1 = int.Parse(partes[4]);
            e.nota2 = int.Parse(partes[5]);
            e.nota3 = int.Parse(partes[6]);
            e.nota4 = int.Parse(partes[7]);
            e.SacarPromedio();
            e.SacarLiteral();

            lista.Add(e);
        }
        return lista;
    }
    public static void MostrarMenu(List<Estudiante> lista)
    {
        int opc;
        do
        {
            Console.Clear();
            Console.WriteLine(".:MENU:.");
            Console.WriteLine("1. Agregar Alumno.");
            Console.WriteLine("2. Quitar Alumno.");
            Console.WriteLine("3. Buscar Alumno.");
            Console.WriteLine("4. Mostrar Reporte.");
            Console.WriteLine("5. Salir");
            while (!int.TryParse(Console.ReadLine(), out opc))
            {
                Console.WriteLine("Tipo de dato invalido.");
            }

            Console.WriteLine();

            EjecutarMenu(opc, lista);
            if (opc != 5)
            {
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }


        } while (opc != 5);
    }

    public static void EjecutarMenu(int opc, List<Estudiante> lista)
    {
        switch (opc)
        {
            case 1:
                lista.Add(LeerEstudiante(lista));
                GuardarArchivo(lista);
                break;
            case 2:
                QuitarAlumno(lista);
                break;
            case 3:
                BuscarAlumno(lista);
                break;
            case 4:
                lista.Sort((a, b) => a.apellido.CompareTo(b.apellido));
                MostrarTabla(lista);
                Contador(lista);
                break;
            case 5:
                Console.WriteLine("Saliendo...");
                break;
            default:
                Console.WriteLine("Opcion invalida");
                break;

        }



    }
    static string LeerCurso()
    {
        string curso;
        Console.WriteLine("Ingrese el curso del estudiante");
        curso = Console.ReadLine();

        return curso;
    }


    public static void QuitarAlumno(List<Estudiante> lista)
    {
        Console.WriteLine("Igrese la matricula: ");
        if (!int.TryParse(Console.ReadLine(), out int matricula))
        {
            Console.WriteLine("Dato Invalido.");
            return;
        }

        Estudiante c = lista.Find(e => e.matricula == matricula);
        if (c != null)
        {
            Console.WriteLine("Seguro? (s/n)");
            string respuesta = Console.ReadLine();
            respuesta = respuesta.Trim().ToLower();

            if (respuesta == "s")
            {
                Console.WriteLine($"Quitando al alumno {c.nombre} {c.apellido} de matricula: {c.matricula}");
                lista.Remove(c);
                GuardarArchivo(lista);
            }
            else
            {
                Console.WriteLine("No se removio a ningun alumno.");
            }
        }
        else
        {
            Console.WriteLine("Matricula no encotrada.");
        }

    }

    public static void BuscarAlumno(List<Estudiante> lista)
    {
        string linea = new string('=', 36);
        Console.WriteLine("Igrese la matricula: ");
        if (!int.TryParse(Console.ReadLine(), out int matricula))
        {
            Console.WriteLine("Dato Invalido.");
            return;
        }

        Estudiante c = lista.Find(e => e.matricula == matricula);

        if (c == null)
        {
            Console.WriteLine("No se econtro la matricula");
        }
        else
        {
            Console.WriteLine(linea);
            Console.WriteLine($"{"Nombre",-12}{"Apellido",-12}{"Curso",12}");
            Console.WriteLine(linea);
            Console.WriteLine($"{c.nombre,-12}{c.apellido,-12}{c.curso,12}");
        }

    }
    static int LeerMatricula(List<Estudiante> lista)
    {
        int matricula;
        Console.WriteLine("Ingrese el numero de matricula del estudiante: ");
        while (!int.TryParse(Console.ReadLine(), out matricula) || matricula < 1000 || matricula > 9999 || lista.Exists(e => e.matricula == matricula))
        {
            Console.WriteLine($"Esta matricula le pertenece a un estudiante o la esta ingresando mal. \nLa matricula tiene que empezar por un numero distinto de 0 y tiene que ser de 4 digitos.");
        }

        return matricula;
    }



    public double SacarPromedio()
    {
        promedio = (nota1 + nota2 + nota3 + nota4) / 4.0;
        return promedio;
    }



    public char SacarLiteral()
    {
        if (promedio >= 90 && promedio <= 100) return literal = 'A';
        else if (promedio >= 80 && promedio < 90) return literal = 'B';
        else if (promedio >= 70 && promedio < 80) return literal = 'C';
        else return literal = 'D';
    }


    public static Estudiante LeerEstudiante(List<Estudiante> lista)
    {

        Estudiante estudiante = new Estudiante();


        estudiante.matricula = LeerMatricula(lista);
        estudiante.curso = LeerCurso();

        Console.WriteLine("Ingrese el nombre del estudiante: ");
        estudiante.nombre = Console.ReadLine();

        Console.WriteLine("Ingrese el apellido del estudiante: ");
        estudiante.apellido = Console.ReadLine();


        estudiante.nota1 = LeerNota(1);
        estudiante.nota2 = LeerNota(2);
        estudiante.nota3 = LeerNota(3);
        estudiante.nota4 = LeerNota(4);

        estudiante.SacarPromedio();
        estudiante.SacarLiteral();

        return estudiante;

    }

    static int LeerNota(int num)
    {
        int nota;
        Console.WriteLine($"Ingrese la nota {num}: ");
        while (!int.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 100)
        {
            Console.WriteLine("La nota tiene que ser un numero entre 0 y 100.");
        }

        return nota;
    }




    public static List<Estudiante> LeerTodo()
    {
        List<Estudiante> lista = new List<Estudiante>();
        string respuesta;

        do
        {
            lista.Add(LeerEstudiante(lista));
            Console.WriteLine("Desea agregar otro estudiante? (s/n) ");
            respuesta = Console.ReadLine();
            respuesta = respuesta.Trim().ToLower();

        } while (respuesta == "s");

        return lista;
    }




    public static void MostrarTabla(List<Estudiante> lista)
    {

        string linea = new string('=', 94);
        Console.WriteLine(linea);
        Console.WriteLine($"{"Curso",-12}{"Nombre",-12}{"Apellido",-12}{"Matricula",-12}" +
                          $"{"Nota1",7}{"Nota2",7}{"Nota3",7}{"Nota4",7}" +
                          $"{"Promedio",9}{"Literal",9}");
        Console.WriteLine(linea);

        foreach (Estudiante estudiante in lista)
        {
            Console.WriteLine($"{estudiante.curso,-12}{estudiante.nombre,-12}{estudiante.apellido,-12}{estudiante.matricula,-12}{estudiante.nota1,7}{estudiante.nota2,7}{estudiante.nota3,7}{estudiante.nota4,7}{estudiante.promedio,9:F2}{estudiante.literal,9}");
        }

    }



    public static void Contador(List<Estudiante> lista)
    {
        int cont1 = 0, cont2 = 0, cont3 = 0, cont4 = 0;

        foreach (Estudiante estudiante in lista)
        {
            if (estudiante.literal == 'A') cont1++;
            else if (estudiante.literal == 'B') cont2++;
            else if (estudiante.literal == 'C') cont3++;
            else cont4++;
        }

        Console.WriteLine();
        Console.WriteLine($"Cantidad alumnos que pasaron en A: {cont1}");
        Console.WriteLine($"Cantidad alumnos que pasaron en B: {cont2}");
        Console.WriteLine($"Cantidad alumnos que pasaron en C: {cont3}");
        Console.WriteLine($"Cantidad alumnos que reprobaron: {cont4}");

    }
}



class Program
{
    public static void Main()
    {
        List<Estudiante> estudiantes = Estudiante.CargarArchivo();
        Estudiante.MostrarMenu(estudiantes);
    }
}