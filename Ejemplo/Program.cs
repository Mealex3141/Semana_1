using System;

namespace Ejemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una contraseña: ");
            string clave = Console.ReadLine();
            bool valido = EsValido(clave);
            MostrarResultado(clave, valido);
            Console.ReadKey();
        }

        static bool TieneNumero(string texto)
        {
            foreach (char c in texto)
            {
                if (char.IsDigit(c))
                    return true;
            }
            return false;
        }

        static bool TieneMayuscula(string texto)
        {
            foreach (char c in texto)
            {
                if (char.IsUpper(c))
                    return true;
            }
            return false;
        }

        static bool EsValido(string clave)
        {
            bool cumple = clave.Length >= 8 && TieneNumero(clave) && TieneMayuscula(clave);
            return cumple;
        }

        static void MostrarResultado(string clave, bool valido)
        {
            Console.WriteLine();
            Console.WriteLine("Resultado:");
            if (valido)
            {
                Console.WriteLine("La contraseña ingresada es válida.");
            }
            else
            {
                Console.WriteLine("La contraseña ingresada no es válida.");
            }
        }
    }
}
