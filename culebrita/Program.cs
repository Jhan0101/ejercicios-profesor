using System;
using System.ComponentModel;
using System.Drawing;
using JuegoSnake;

namespace JuegoSnake
{
    internal class Ventana
    {
        public string Titulo { get; set; }
        public int Ancho { get; set; }
        public int Altura { get; set; }
        public ConsoleColor ColorFondo { get; set; }
        public ConsoleColor ColorLetra { get; set; }
        public Point LimiteSuperior { get; set; }
        public Point LimiteInferior { get; set; }
        public int Area { get; set; }
        public Snake SnakeC { get; set; }

        public Ventana(string titulo, int ancho, int altura,
                ConsoleColor colorFondo, ConsoleColor colorLetra,
                Point limiteSuperior, Point limiteInferior)
        {
            Titulo = titulo;
            Ancho = ancho;
            Altura = altura;
            ColorFondo = colorFondo;
            ColorLetra = colorLetra;
            LimiteSuperior = limiteSuperior;
            LimiteInferior = limiteInferior;
            Area = ((LimiteSuperior.X - LimiteInferior.X - 1) * (LimiteSuperior.Y - LimiteInferior.Y) - 1);
            Init();
        }

        public void Init()
        {
            Console.SetWindowSize(Ancho, Altura);
            Console.Title = Titulo;
            Console.CursorVisible = false;
            Console.BackgroundColor = ColorFondo;
            Console.Clear();
            SnakeC = new Snake(new Point(LimiteInferior.X / 2, LimiteInferior.Y - 3),
                 ConsoleColor.Magenta, ConsoleColor.DarkMagenta, this, null);
            SnakeC.IniciarCuerpo(4);
        }
        public void DibujarMarco()
        {
            Console.ForegroundColor = ColorLetra;

            for (int i = LimiteSuperior.X; i < LimiteInferior.X; i++)
            {
                Console.SetCursorPosition(i, LimiteSuperior.Y);
                Console.Write("═");
                Console.SetCursorPosition(i, LimiteInferior.Y);
                Console.Write("═");
            }
            for (int i = LimiteSuperior.Y; i < LimiteInferior.Y; i++)
            {
                Console.SetCursorPosition(LimiteSuperior.X, i);
                Console.Write("║");
                Console.SetCursorPosition(LimiteInferior.X, i);
                Console.Write("║");
            }

            Console.SetCursorPosition(LimiteSuperior.X, LimiteSuperior.Y);
            Console.Write("╔");
            Console.SetCursorPosition(LimiteSuperior.X, LimiteInferior.Y);
            Console.Write("╚");
            Console.SetCursorPosition(LimiteInferior.X, LimiteSuperior.Y);
            Console.Write("╗");
            Console.SetCursorPosition(LimiteInferior.X, LimiteInferior.Y);
            Console.Write("╝");
        }
        public void Menu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(LimiteSuperior.X + (LimiteInferior.X / 2) - 12,
                LimiteSuperior.Y + (LimiteInferior.Y / 2) - 4);
            Console.Write("J U E G O   S N A K E");
            Console.SetCursorPosition(LimiteSuperior.X + (LimiteInferior.X / 2) - 8,
                LimiteSuperior.Y + (LimiteInferior.Y / 2) - 2);
            Console.Write("Enter - JUGAR");
            Console.SetCursorPosition(LimiteSuperior.X + (LimiteInferior.X / 2) - 8,
                LimiteSuperior.Y + (LimiteInferior.Y / 2) - 1);
            Console.Write("Esc - SALIR");

            SnakeC.MoverMenu();
        }

        public void Teclado(ref bool ejecucion, ref bool jugar, Snake snake)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.Enter)
                {
                    jugar = true;
                    Console.Clear();
                    DibujarMarco();
                    snake.Init();
                }
                if (tecla.Key == ConsoleKey.Escape)
                {
                    ejecucion = false;
                }
            }
        }
        public void GameOver(string text)
        {
            Console.Clear();
            DibujarMarco();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(LimiteSuperior.X + (LimiteInferior.X / 2) - 10,
                LimiteSuperior.Y + (LimiteInferior.Y / 2) - 2);
            Console.Write(text);
            Thread.Sleep(3000);
            Console.Clear();
            DibujarMarco();
        }
    }
    internal class Snake
    {
        enum Direccion
        {
            Arriba, Abajo, Derecha, Izquierda
        }
        public bool Vivo { get; set; }
        public ConsoleColor ColorCabeza { get; set; }
        public ConsoleColor ColorCuerpo { get; set; }
        public Ventana ventanaC { get; set; }
        public List<Point> Cuerpo { get; set; }
        public Point Cabeza { get; set; }
        private Direccion _direccion;
        public Comida ComidaC { get; set; }
        private bool _comiendo;
        public int Puntaje { get; set; }
        public int PuntajeMaximo { get; set; }
        public Point PosicionInicial { get; set; }

        public Snake(Point posicion, ConsoleColor colorCabeza, ConsoleColor colorCuerpo,
            Ventana ventana, Comida comida)
        {
            ColorCabeza = colorCabeza;
            ColorCuerpo = colorCuerpo;
            ventanaC = ventana;
            Cabeza = posicion;
            ComidaC = comida;
            Puntaje = 0;
            PuntajeMaximo = 0;
            PosicionInicial = posicion;
            Cuerpo = new List<Point>();

            _direccion = Direccion.Derecha;
        }

        public void Init()
        {
            Cuerpo.Clear();
            Cabeza = PosicionInicial;
            IniciarCuerpo(2);
            Vivo = true;
            _direccion = Direccion.Derecha;
            ComidaC.GenerarComida(this);
        }

        public void IniciarCuerpo(int numPartes)
        {
            int x = Cabeza.X - 1;
            for (int i = 0; i < numPartes; i++)
            {
                Console.SetCursorPosition(x, Cabeza.Y);
                Console.WriteLine("▓");
                Cuerpo.Add(new Point(x, Cabeza.Y));
                x--;
            }
        }

        public void Mover()
        {
            Teclado();
            Point cabezaAnterior = Cabeza;
            MoverCabeza();
            MoverCuerpo(cabezaAnterior);
            ColisionesComida();
            if (ColisionesCuerpo())
            {
                Muerte();
                ventanaC.GameOver("G A M E  O V E R");
            }
        }

        public void MoverCuerpo(Point cabezaAnterior)
        {
            Console.ForegroundColor = ColorCuerpo;
            Console.SetCursorPosition(cabezaAnterior.X, cabezaAnterior.Y);
            Console.WriteLine("▓");
            Cuerpo.Insert(0, cabezaAnterior);

            if (_comiendo)
            {
                _comiendo = false;
                return;
            }

            Console.SetCursorPosition(Cuerpo[Cuerpo.Count - 1].X, Cuerpo[Cuerpo.Count - 1].Y);
            Console.Write(" ");
            Cuerpo.Remove(Cuerpo[Cuerpo.Count - 1]);
        }
        public void MoverCabeza()
        {
            Console.ForegroundColor = ColorCabeza;
            Console.SetCursorPosition(Cabeza.X, Cabeza.Y);
            Console.Write(" ");

            switch (_direccion)
            {
                case Direccion.Derecha:
                    Cabeza = new Point(Cabeza.X + 1, Cabeza.Y);
                    break;
                case Direccion.Izquierda:
                    Cabeza = new Point(Cabeza.X - 1, Cabeza.Y);
                    break;
                case Direccion.Arriba:
                    Cabeza = new Point(Cabeza.X, Cabeza.Y - 1);
                    break;
                case Direccion.Abajo:
                    Cabeza = new Point(Cabeza.X, Cabeza.Y + 1);
                    break;
            }
            ColisionesMarco();
            Console.SetCursorPosition(Cabeza.X, Cabeza.Y);
            Console.WriteLine("█");
        }

        private void ColisionesComida()
        {
            if (Cabeza == ComidaC.Posicion)
            {
                if (!ComidaC.GenerarComida(this))
                {
                    Vivo = false;
                    ventanaC.GameOver("JUEGO COMPLETADO");
                }

                _comiendo = true;
                Puntaje++;
                if (Puntaje > PuntajeMaximo)
                    PuntajeMaximo = Puntaje;
            }
        }

        private void Teclado()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.RightArrow && (_direccion != Direccion.Izquierda))
                    _direccion = Direccion.Derecha;
                if (tecla.Key == ConsoleKey.LeftArrow && (_direccion != Direccion.Derecha))
                    _direccion = Direccion.Izquierda;
                if (tecla.Key == ConsoleKey.UpArrow && (_direccion != Direccion.Abajo))
                    _direccion = Direccion.Arriba;
                if (tecla.Key == ConsoleKey.DownArrow && (_direccion != Direccion.Arriba))
                    _direccion = Direccion.Abajo;
            }
        }

        private void ColisionesMarco()
        {
            if (Cabeza.X <= ventanaC.LimiteSuperior.X)
                Cabeza = new Point(ventanaC.LimiteInferior.X - 1, Cabeza.Y);
            if (Cabeza.X >= ventanaC.LimiteInferior.X)
                Cabeza = new Point(ventanaC.LimiteSuperior.X + 1, Cabeza.Y);

            if (Cabeza.Y <= ventanaC.LimiteSuperior.Y)
                Cabeza = new Point(Cabeza.X, ventanaC.LimiteInferior.Y - 1);
            if (Cabeza.Y >= ventanaC.LimiteInferior.Y)
                Cabeza = new Point(Cabeza.X, ventanaC.LimiteSuperior.Y + 1);
        }

        private bool ColisionesCuerpo()
        {
            foreach (Point item in Cuerpo)
            {
                if (Cabeza == item)
                {
                    Vivo = false;
                    return true;
                }
            }
            return false;
        }

        private void Muerte()
        {
            foreach (Point item in Cuerpo)
            {
                if (item == Cabeza)
                    continue;
                Console.SetCursorPosition(item.X, item.Y);
                Console.Write("░");
                Thread.Sleep(120);
            }
        }
        public void Infomacion(int distanciaX1, int distanciaX2)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(ventanaC.LimiteSuperior.X + distanciaX1, ventanaC.LimiteSuperior.Y - 1);
            Console.Write("Puntaje: " + Puntaje + "  ");
            Console.SetCursorPosition(ventanaC.LimiteSuperior.X + distanciaX2, ventanaC.LimiteSuperior.Y - 1);
            Console.Write("Puntaje Maximo: " + PuntajeMaximo + "  ");

        }
        public void MoverMenu()
        {
            _direccion = Direccion.Derecha;
            Point CabezaAnterior = Cabeza;
            MoverCabeza();
            MoverCuerpo(CabezaAnterior);
        }
    }
    internal class Comida
    {
        public Point Posicion { get; set; }
        public ConsoleColor Color { get; set; }
        public Ventana VentanaC { get; set; }

        public Comida(ConsoleColor color, Ventana ventana)
        {
            Color = color;
            VentanaC = ventana;
        }

        private void Dibujar()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(Posicion.X, Posicion.Y);
            Console.Write("█");
        }
        public bool GenerarComida(Snake snake)
        {
            int longSnake = snake.Cuerpo.Count + 1;
            if ((VentanaC.Area - longSnake) <= 0)
                return false;

            Random random = new Random();
            int x = random.Next(VentanaC.LimiteSuperior.X + 1, VentanaC.LimiteInferior.X);
            int y = random.Next(VentanaC.LimiteSuperior.Y + 1, VentanaC.LimiteInferior.Y);
            Posicion = new Point(x, y);

            foreach (Point item in snake.Cuerpo)
            {
                if ((x == item.X && y == item.Y) || (x == snake.Cabeza.X && y == snake.Cabeza.Y))
                {
                    if (GenerarComida(snake)) ;
                    return true;
                }
            }

            Dibujar();
            return true;
        }

    }
}

class Program
{
    public static void Main()
    {
        Ventana ventana;
        Snake snake;
        Comida comida;
        bool jugar = false;
        bool ejecucion = true;

        void Iniciar()
        {
            ventana = new Ventana("Culebrita", 65, 20, ConsoleColor.Black, ConsoleColor.White,
            new Point(5, 3), new Point(58, 18));
            ventana.DibujarMarco();
            comida = new Comida(ConsoleColor.Red, ventana);
            snake = new Snake(new Point(20, 9), ConsoleColor.Green, ConsoleColor.White, ventana, comida);

        }

        void Game()
        {
            while (ejecucion)
            {
                ventana.Menu();
                ventana.Teclado(ref ejecucion, ref jugar, snake);
                while (jugar)
                {
                    snake.Infomacion(0, 34);
                    snake.Mover();
                    if (!snake.Vivo)
                    {
                        jugar = false;
                        snake.Puntaje = 0;
                    }
                    Thread.Sleep(100);
                }
                Thread.Sleep(100);
            }

        }

        Iniciar();
        Game();
    }
}