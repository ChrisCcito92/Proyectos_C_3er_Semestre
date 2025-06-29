using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorVocales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita la palabra al usuario
            Console.Write("Ingrese una palabra: ");
            string entrada = Console.ReadLine();
            // Crea instancia del analizador
            PalabraVocales analizador = new PalabraVocales(entrada);
            // Realiza el conteo
            analizador.ContarVocales();
            // Muestra el resultado
            analizador.MostrarConteo();
            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
