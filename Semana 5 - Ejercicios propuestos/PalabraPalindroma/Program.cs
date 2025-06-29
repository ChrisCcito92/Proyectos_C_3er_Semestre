using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalabraPalindroma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita una palabra al usuario
            Console.Write("Ingrese una palabra: ");
            string entrada = Console.ReadLine();
            // Crea un objeto Palindromo y verifica
            Palabra validador = new Palabra(entrada);
            // Muestra el resultado
            if (validador.EsPalindromo())
            {
                Console.WriteLine($"'{entrada}' es un palíndromo.");
            }
            else
            {
                Console.WriteLine($"'{entrada}' no es un palíndromo.");
            }
            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
