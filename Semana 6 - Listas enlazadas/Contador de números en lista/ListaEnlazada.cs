using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador_de_números_en_lista
{
    public class ListaEnlazada
    {
        private Nodo cabeza; // Representa el primer nodo de la lista
        // Método para agregar un nuevo nodo al final de la lista
        public void AgregarAlFinal(int valor)
        {
            Nodo nuevo = new Nodo(valor); // Crea un nuevo nodo
            if (cabeza == null)
            {
                // En caso de que la lista esté vacía, el nuevo nodo se convierte en la cabeza
                cabeza = nuevo;
            }
            else
            {
                // Caso contrario recorre hasta el último nodo
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                // Enlaza el nuevo nodo al final
                actual.Siguiente = nuevo;
            }
        }
        // Este médtodo muestra en pantalla la lista enlazada
        public void Imprimir()
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.Valor + " -> "); // Muestra el valor del nodo
                actual = actual.Siguiente; // Va al siguiente nodo
            }
            Console.WriteLine("null"); // Fin de la lista
        }
        // Método que cuenta las veces que el valor dado aparece en la lista
        public void Buscar(int valorBuscado)
        {
            int contador = 0;
            Nodo actual = cabeza;
            // Recorre la lista
            while (actual != null)
            {
                if (actual.Valor == valorBuscado)
                {
                    contador++; // Contador que incrementa si el valor coincide
                }
                actual = actual.Siguiente; // Dirige al siguiente nodo
            }
            // Muestra en pantalla el resultado si encontro el valor buscado o no
            if (contador > 0)
            {
                Console.WriteLine($"El valor {valorBuscado} se encontró {contador} vez/veces en la lista.");
            }
            else
            {
                Console.WriteLine($"El valor {valorBuscado} no fue encontrado en la lista.");
            }
        }
    }
}
