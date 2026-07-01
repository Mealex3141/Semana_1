using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tConversor de temperatura");

            char opcion;
            double grados;

            Console.Write("\n\tingrese la temperatura: ");
            grados = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n\tSeleccione la temperatura ingresada: ");
            Console.WriteLine("\n\tC) Celsius");
            Console.WriteLine("\n\tF) Fahrenheit");
            Console.WriteLine("\n\tK) Kelvin");
            Console.Write("\n\tIngrese su opción: ");
            opcion = char.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 'C':
                case 'c':
                    Desdecelcius(grados);
                    break;

                case 'F':
                case 'f':
                    DesdeFahrenheit(grados);
                    break;

                case 'K':
                case 'k':
                    DesdeKelvin(grados);
                    break;

                default:
                    Console.WriteLine("\n\tOpción no válida");
                    break;

            }
            Console.ReadKey();

        }
        static void Desdecelcius(double grados)
        { 
            double kelvin, fahrenheit;
            fahrenheit = (grados * 9 / 5) + 32;
            kelvin = grados + 273.15;
            Console.WriteLine($"\n\t{grados}°C son {fahrenheit}°F y {kelvin}K");
        }
        static void DesdeFahrenheit(double grados)
        {
            double celsius, kelvin;
            celsius = (grados - 32) * 5 / 9;
            kelvin = (grados - 32) * 5 / 9 + 273.15;
            Console.WriteLine($"\n\t{grados}°F son {celsius}°C y {kelvin}K");
        }
        static void DesdeKelvin(double grados)
        {
            double celsius, fahrenheit;
            celsius = grados - 273.15;
            fahrenheit = (grados - 273.15) * 9 / 5 + 32;
            Console.WriteLine($"\n\t{grados}K son {celsius}°C y {fahrenheit}°F");
        }
    }
}
