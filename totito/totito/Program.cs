using System;

namespace totito
{
    class Program
    {
        const char disponible = '_';
        char[,] tablero =
        {
          { disponible, disponible, disponible },
          { disponible, disponible, disponible },
          { disponible, disponible, disponible }
        };

        static void Main(string[] args)
        {
            Program p = new Program();
            bool fin = false;
            char jugadoryo = 'X';
            jugadoryo = jugadoryo == 'X' ? '0' : 'x';
            fin = p.tablerodisponible();

            do
            {
                p.MostrarTablero(); 
                p.realizarjugada(jugadoryo);
                fin = p.tablerodisponible();

                if (p.verificarGanador(jugadoryo))
                {
                    Console.WriteLine("¡El jugador " + jugadoryo + " ha ganado!");
                    fin = true;
                }

                
                jugadoryo = jugadoryo == 'X' ? 'O' : 'X';

            } while (!fin);

            Console.ReadKey();
        }

        private bool tablerodisponible()
        {
            bool esdisponible = true;
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (tablero[f, c] != disponible)
                    {
                        esdisponible = false;
                        return esdisponible;
                    }
                }
            }
            return esdisponible;
        }

        private void realizarjugada(char jugadoryo)
        {
            Console.WriteLine("Es el turno de " + jugadoryo);
            bool valida = false;

            do
            {
                Console.WriteLine("Elige una fila");
                int fila = int.Parse(Console.ReadLine());
                Console.WriteLine("Elige una columna");
                int col = int.Parse(Console.ReadLine());

                if (tablero[fila, col] == disponible)
                {
                    tablero[fila, col] = jugadoryo;
                    valida = true; 
                }
                else
                {
                    Console.WriteLine("Posición inválida");
                }
            } while (!valida); 
        }

        private bool verificarGanador(char jugador)
        {
            
            for (int i = 0; i < 3; i++)
            {
                if ((tablero[i, 0] == jugador && tablero[i, 1] == jugador && tablero[i, 2] == jugador) ||
                    (tablero[0, i] == jugador && tablero[1, i] == jugador && tablero[2, i] == jugador))
                {
                    return true;
                }
            }

           
            if ((tablero[0, 0] == jugador && tablero[1, 1] == jugador && tablero[2, 2] == jugador) ||
                (tablero[0, 2] == jugador && tablero[1, 1] == jugador && tablero[2, 0] == jugador))
            {
                return true;
            }

            return false;
        }

        public void MostrarTablero()
        {
            Console.Clear();

            for (int fila = 0; fila < 3; fila++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(tablero[fila, col] + " "); 
                }
                Console.WriteLine();
            }
        }
    }
}