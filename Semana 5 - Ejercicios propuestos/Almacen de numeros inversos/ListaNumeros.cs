using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen_de_numeros_inversos
{
    public class ListaNumeros
    {
        private List<int> numeros;

        // Constructor: llena la lista con los números del 1 al 10
        public ListaNumeros()
        {
            numeros = new List<int>();
            // Llenamos la lista con los números del 1 al 10
            for (int i = 1; i <= 10; i++)
            {
                numeros.Add(i);
            }
        }

        // Método para mostrar los números en orden inverso separados por comas
        public void MostrarEnOrdenInverso()
        {
            var numerosInvertidos = numeros.AsEnumerable().Reverse();
            string resultado = string.Join(", ", numerosInvertidos);
            Console.WriteLine("Números en orden inverso:");
            Console.WriteLine(resultado);
        }
    }
}
