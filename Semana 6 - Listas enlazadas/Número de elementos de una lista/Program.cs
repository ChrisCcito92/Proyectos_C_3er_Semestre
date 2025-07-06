using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Número_de_elementos_de_una_lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos una nueva lista enlazada
            ListaEnlazada lista = new ListaEnlazada();
            // Agregamos varios elementos a la lista
            lista.AgregarAlFinal(5);
            lista.AgregarAlFinal(10);
            lista.AgregarAlFinal(15);
            lista.AgregarAlFinal(20);
            lista.AgregarAlFinal(25);
            lista.AgregarAlFinal(30);
            lista.AgregarAlFinal(35);
            lista.AgregarAlFinal(40);
            lista.AgregarAlFinal(45);
            lista.AgregarAlFinal(50);
            // Imprimimos los valores de la lista
            Console.WriteLine("Lista enlazada:");
            lista.Imprimir();
            // Calculamos e imprimimos la longitud de la lista
            int longitud = lista.CalcularLongitud();
            Console.WriteLine($"Longitud de la lista: {longitud}");
        }
    }
}
