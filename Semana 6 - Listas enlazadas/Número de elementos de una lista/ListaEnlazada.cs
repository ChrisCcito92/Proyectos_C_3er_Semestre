using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Número_de_elementos_de_una_lista
{
    public class ListaEnlazada
    {
        // Se toma en cuenta este nodo como la cabeza de la lista
        private Nodos cabeza;
        // Este método sirve para agregar un nuevo nodo al final de la lista
        public void AgregarAlFinal(int valor)
        {
            Nodos nuevo = new Nodos(valor); // Crea un nuevo nodo
            if (cabeza == null)
            {
                // En caso de que la lista esté vacía, el nuevo nodo será en la cabeza
                cabeza = nuevo;
            }
            else
            {
                // Caso contrario se recorre la lista hasta el final
                Nodos actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                // Agrega al nuevo nodo al final de la lista
                actual.Siguiente = nuevo;
            }
        }
        // Este método cuenta la cantidad de nodos que hay en la lista
        public int CalcularLongitud()
        {
            int contador = 0;
            Nodos actual = cabeza;
            // Recorre la lista hasta llegar al final (null)
            while (actual != null)
            {
                contador++; // Cuenta el nodo actual
                actual = actual.Siguiente; // Se salta al siguiente nodo
            }
            return contador; // Da el total de nodos contados
        }
        // Método para imprimir la lista en la pantalla
        public void Imprimir()
        {
            Nodos actual = cabeza;
            // Recorre la lista y muestra en pantalla los valores
            while (actual != null)
            {
                Console.Write(actual.Valor + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null"); // Muestra el final de la lista
        }
    }
}
