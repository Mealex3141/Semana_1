using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tSistema de registro de ventas de productos");

            int[] ventas = new int[12];

            ingresarventas(ventas);

            Console.WriteLine("\n\tVentas registradass:");
            mostrarventas(ventas);

            int totalVentas = CalcularTotalVentas(ventas);
            int ventaMayor = ObtenerVentaMayor(ventas);
            int posicionMayor = ObtenerPosicionMayorVenta(ventas);
            int productosMasDe20 = ContarProductosMasDe20(ventas);

            Console.WriteLine("\n--- REPORTE FINAL ---");
            Console.WriteLine("Total de productos vendidos: {0}", totalVentas);
            Console.WriteLine("Mayor cantidad vendida: {0}", ventaMayor);
            Console.WriteLine("El producto más vendido es el producto número: {0}",
                              posicionMayor + 1);
            Console.WriteLine("Cantidad de productos con más de 20 unidades vendidas: {0}",
                              productosMasDe20);

            Console.ReadKey();
        }
        static void ingresarventas(int[] ventas)
        {
            for (int i = 0; i < ventas.Length; i++)
            {
                Console.Write("Ingrese la cantidad de unidades vendidas del producto {0}: ", i + 1);
                ventas[i] = int.Parse(Console.ReadLine());
            }
        }
        static void mostrarventas(int[] ventas)
        {
            for (int i = 0; i < ventas.Length; i++)
            {
                Console.WriteLine("Producto {0}: {1} unidades", i + 1, ventas[i]);
            }
        }
        static int CalcularTotalVentas(int[] ventas)
        {
            int total = 0;
            for (int i = 0; i < ventas.Length; i++)
            {
                total += ventas[i];
            }
            return total;
        }
        static int ObtenerVentaMayor(int[] ventas)
        {
            int mayor = ventas[0];
            for (int i = 1; i < ventas.Length; i++)
            {
                if (ventas[i] > mayor)
                {
                    mayor = ventas[i];
                }
            }
            return mayor;
        }
        static int ObtenerPosicionMayorVenta(int[] ventas)
        {
            int posicion = 0;
            int mayor = ventas[0];
            for (int i = 1; i < ventas.Length; i++)
            {
                if (ventas[i] > mayor)
                {
                    mayor = ventas[i];
                    posicion = i;
                }
            }
            return posicion;
        }
        static int ContarProductosMasDe20(int[] ventas)
        {
            int contador = 0;
            for (int i = 0; i < ventas.Length; i++)
            {
                if (ventas[i] > 20)
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}
