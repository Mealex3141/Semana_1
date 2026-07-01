using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static string[] jugadores = new string[100];
        static int[] experienciaJugadores = new int[100];
        static int cantidadJugadores = 0;

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("\t\tSistema de videojuegos");
                Console.WriteLine("\n1. Registrar jugador");
                Console.WriteLine("2. Mostrar ranking");
                Console.WriteLine("3. Salir");
                Console.Write("\nSeleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        RegistrarJugador();
                        break;

                    case 2:
                        MostrarRanking();
                        break;

                    case 3:
                        Console.WriteLine("\nSaliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("\nOpción no válida.");
                        break;
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 3);
        }

        // Procedimiento para registrar un jugador
        static void RegistrarJugador()
        {
            Console.Clear();
            Console.Write("\nNombre del jugador: ");
            string jugador = Console.ReadLine();

            int[] misiones = new int[10];

            Console.WriteLine("\nIngrese la XP obtenida en las últimas 10 misiones:");

            for (int i = 0; i < misiones.Length; i++)
            {
                Console.Write("XP de la misión {0}: ", i + 1);
                misiones[i] = int.Parse(Console.ReadLine());
            }

            int totalXP = CalcularExperienciaTotal(misiones);
            string nivel = DeterminarNivel(totalXP);
            int posicionMayor = ObtenerMisionMayorXP(misiones);

            MostrarResumen(jugador, totalXP, nivel, posicionMayor, misiones);

            jugadores[cantidadJugadores] = jugador;
            experienciaJugadores[cantidadJugadores] = totalXP;
            cantidadJugadores++;
        }

        // Función para calcular la experiencia total
        static int CalcularExperienciaTotal(int[] misiones)
        {
            int totalXP = 0;

            for (int i = 0; i < misiones.Length; i++)
            {
                totalXP += misiones[i];
            }

            return totalXP;
        }

        // Función para determinar el nivel
        static string DeterminarNivel(int experiencia)
        {
            if (experiencia < 100 && experiencia >= 0)
                return "Novato";
            else if (experiencia < 300 && experiencia >= 100)
                return "Aventurero";
            else if (experiencia < 600 && experiencia >= 300)
                return "Experto";
            else if (experiencia >= 600)
                return "Maestro";
            else
                return "Ingreso de valores XP negativos";
        }

        // Función para obtener la misión con mayor XP
        static int ObtenerMisionMayorXP(int[] misiones)
        {
            int posicion = 0;

            for (int i = 1; i < misiones.Length; i++)
            {
                if (misiones[i] > misiones[posicion])
                {
                    posicion = i;
                }
            }

            return posicion;
        }

        // Procedimiento para mostrar el resumen del jugador
        static void MostrarResumen(string jugador, int experiencia,
                                   string nivel, int posicionMayor,
                                   int[] misiones)
        {
            Console.WriteLine("\n--- RESUMEN DEL JUGADOR ---");
            Console.WriteLine("Jugador: {0}", jugador);
            Console.WriteLine("Experiencia total: {0}", experiencia);
            Console.WriteLine("Nivel alcanzado: {0}", nivel);
            Console.WriteLine("La misión con mayor experiencia fue la misión número: {0}",
                              posicionMayor + 1);
            Console.WriteLine("XP obtenida en esa misión: {0}",
                              misiones[posicionMayor]);
        }

        // Procedimiento para mostrar el ranking
        static void MostrarRanking()
        {
            Console.Clear();

            if (cantidadJugadores == 0)
            {
                Console.WriteLine("\nNo hay jugadores registrados.");
                return;
            }

            Console.WriteLine("\n--- RANKING DE JUGADORES ---");

            for (int i = 0; i < cantidadJugadores - 1; i++)
            {
                for (int j = i + 1; j < cantidadJugadores; j++)
                {
                    if (experienciaJugadores[j] > experienciaJugadores[i])
                    {
                        int auxXP = experienciaJugadores[i];
                        experienciaJugadores[i] = experienciaJugadores[j];
                        experienciaJugadores[j] = auxXP;

                        string auxJugador = jugadores[i];
                        jugadores[i] = jugadores[j];
                        jugadores[j] = auxJugador;
                    }
                }
            }

            for (int i = 0; i < cantidadJugadores; i++)
            {
                Console.WriteLine("{0}. {1} - {2} XP",
                                  i + 1,
                                  jugadores[i],
                                  experienciaJugadores[i]);
            }
        }
    }
}
