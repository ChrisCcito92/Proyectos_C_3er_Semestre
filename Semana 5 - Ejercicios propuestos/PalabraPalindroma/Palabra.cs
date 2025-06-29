using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalabraPalindroma
{
    public class Palabra
    {
        private string palabra;
        // Constructor que recibe la palabra
        public Palabra(string palabra)
        {
            // Normalizamos: convertimos a minúscula y quitamos espacios
            this.palabra = palabra.ToLower().Replace(" ", "");
        }
        // Método que verifica si la palabra es un palíndromo
        public bool EsPalindromo()
        {
            // Comparamos la palabra con su reverso
            char[] caracteres = palabra.ToCharArray();
            Array.Reverse(caracteres);
            string reverso = new string(caracteres);

            return palabra == reverso;
        }
    }
}
