using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador_de_números_en_lista
{
    internal class Nodo
    {
        public int Valor; // Almacena el dato del nodo
        public Nodo Siguiente; // Siguiente nodo de la lista
        // Constructor que inicializa el nodo y le asiga un valor
        public Nodo(int valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }
}
