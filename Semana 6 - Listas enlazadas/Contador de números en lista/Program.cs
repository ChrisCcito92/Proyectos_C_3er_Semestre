using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador_de_números_en_lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crea una nueva lista enlazada
            ListaEnlazada lista = new ListaEnlazada();
            // Agrega elementos a la lista
            lista.AgregarAlFinal(5);
            lista.AgregarAlFinal(10);
            lista.AgregarAlFinal(5);
            lista.AgregarAlFinal(20);
            lista.AgregarAlFinal(10);
            lista.AgregarAlFinal(5);
            lista.AgregarAlFinal(20);
            lista.AgregarAlFinal(10);
            // Mostramos la lista creada
            Console.WriteLine("Lista enlazada:");
            lista.Imprimir();
            Console.WriteLine("\n\nLos núnermos a buscar en la lista son: 5, 10 y 30");
            // Realiza las búsquedas de los números especificados
            Console.WriteLine("\n\nBúsqueda del número 10:");
            lista.Buscar(10);
            Console.WriteLine("Búsqueda del número 5:");
            lista.Buscar(5);
            Console.WriteLine("Búsqueda del número 30:");
            lista.Buscar(30);
        }
    }
}
