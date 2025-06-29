using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbecedarioMultiplos3
{
    internal class Abecedario
    {
        private List<char> letras;
        // Constructor: llena la lista con las letras del abecedario
        public Abecedario()
        {
            letras = new List<char>();

            // Letras del abecedario en minúscula: 'a' a 'z'
            for (char letra = 'a'; letra <= 'z'; letra++)
            {
                letras.Add(letra);
            }
        }
        // Elimina las letras que están en posiciones múltiplos de 3 partiendo de 1
        public void EliminarMultiplosDeTres()
        {
            // Creamos una nueva lista con las letras filtradas
            List<char> filtradas = new List<char>();
            for (int i = 0; i < letras.Count; i++)
            {
                // Iniciamos en 1 y comprobamos si la posición (i + 1) no es múltiplo de 3
                if ((i + 1) % 3 != 0)
                {
                    filtradas.Add(letras[i]);
                }
            }
            letras = filtradas;
        }
        // Muestra la lista resultante por pantalla
        public void MostrarLetras()
        {
            Console.WriteLine("Letras restantes en el abecedario (sin múltiplos de 3):");
            Console.WriteLine(string.Join(", ", letras));
        }
    }
}
