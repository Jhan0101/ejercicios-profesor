using System;

class Listado
{
    private string[] nombre;
    private string[] apellido;
    private int[,] notas;
    private double[] promedio;
    private char[] literal;

    public Listado(int num)
    {
        nombre = new string[num];
        apellido = new string[num];
        notas = new int[num, 4];
        promedio = new double[num];
        literal = new char[num];
    }

    public void GuardarNombres(int num)
    {
        for (int i = 0; i < num; i++)
        {
            Console.WriteLine($"Ingrese el nombre del estudiante {i + 1}");
            nombre[i] = Console.ReadLine();
        }
    }

    public void GuardarApellido(int num)
    {
        for (int i = 0; i < num; i++)
        {
            Console.WriteLine($"Ingrese el apellido de {nombre[i]}");
            apellido[i] = Console.ReadLine();
        }
    }

    public void GuardarNotas(int num)
    {

        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine($"{nombre[i]}: Notas del periodo {j+1}");
                while (!int.TryParse(Console.ReadLine(), out notas[i, j]) || notas[i, j] < 0 || notas[i,j]>100)
                {
                    Console.WriteLine("Nota invalida. La nota tiene que ser un numero entre 0 y 100");
                }
                
            }

        }
    }

    public void SacarPromedio(int num)
    {
        for (int i = 0; i < num; i++)
        {
            double suma = 0;
            for (int j = 0; j < 4; j++)
            {
                suma += notas[i, j];
            }
            promedio[i] = suma / 4;
        }
    }

    public void SacarLiteral(int num)
    {

        for (int i = 0; i < num; i++)
        {
            if (promedio[i] >= 90 && promedio[i] <= 100)
            {
                literal[i] = 'A';
            }
            else if (promedio[i] >= 80 && promedio[i] < 90)
            {
                literal[i] = 'B';
            }
            else if (promedio[i] >= 70 && promedio[i] < 80)
            {
                literal[i] = 'C';
            }
            else
            {
                literal[i] = 'D';
            }
        }
    }

    public void MostrarResultados(int num)
    {
        string linea = new string('=', 70);

        Console.WriteLine(linea);
        Console.WriteLine($"{"Nombre",-12}{"Apellido",-12}" +
                          $"{"Nota1",7}{"Nota2",7}{"Nota3",7}{"Nota4",7}" +
                          $"{"Promedio",9}{"Literal",9}");
        Console.WriteLine(linea);


        for (int i = 0; i < num; i++)
        {
            Console.Write($"{nombre[i],-12}{apellido[i],-12}");

            for (int j = 0; j < 4; j++)
            {
                Console.Write($"{notas[i, j],7}");
            }

            Console.WriteLine($"{promedio[i],9:F1}{literal[i],9}");
        }
    }
}

class Program
{
    public static void Main()
    {
        int num;

        Console.WriteLine("Digite la cantidad de alumnos con la que va a trabajar");
        while (!int.TryParse(Console.ReadLine(), out num) || num <= 0)
        {
            Console.WriteLine("Dato invalido. Ingrese un numero mayor a 0");
        }

        Listado listado = new Listado(num);
        listado.GuardarNombres(num);
        listado.GuardarApellido(num);
        listado.GuardarNotas(num);
        listado.SacarPromedio(num);
        listado.SacarLiteral(num);
        listado.MostrarResultados(num);
    } 
}



