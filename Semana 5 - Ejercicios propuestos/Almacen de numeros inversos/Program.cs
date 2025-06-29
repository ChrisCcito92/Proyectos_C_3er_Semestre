using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen_de_numeros_inversos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos la clase ListaNumeros
            ListaNumeros lista = new ListaNumeros();

            // Mostramos los números en orden inverso
            lista.MostrarEnOrdenInverso();

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
