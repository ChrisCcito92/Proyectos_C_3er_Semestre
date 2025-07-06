using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Número_de_elementos_de_una_lista
{
    public class Nodos
    {
        // Almacena el valor del nodo
        public int Valor;
        // Almacena una referencia al siguiente nodo
        public Nodos Siguiente;

        // El constructor del nodo que incializa el valor y define a Siguiente como null
        public Nodos(int valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }
}
