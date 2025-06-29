using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorVocales
{
    internal class PalabraVocales
    {
        private string palabra;
        private Dictionary<char, int> conteoVocales;
        public PalabraVocales(string palabra)
        {
            // Convierte a minúsculas y elimina espacios
            this.palabra = palabra.ToLower();
            conteoVocales = new Dictionary<char, int>
            {
                {'a', 0},
                {'e', 0},
                {'i', 0},
                {'o', 0},
                {'u', 0}
            };
        }
        // Cuenta cuántas veces aparece cada vocal
        public void ContarVocales()
        {
            foreach (char c in palabra)
            {
                if (conteoVocales.ContainsKey(c))
                {
                    conteoVocales[c]++;
                }
            }
        }
        // Muestra el resultado por pantalla
        public void MostrarConteo()
        {
            Console.WriteLine("Cantidad de cada vocal en la palabra:");
            foreach (var vocal in conteoVocales)
            {
                Console.WriteLine($"{vocal.Key}: {vocal.Value}");
            }
        }
    }
}
