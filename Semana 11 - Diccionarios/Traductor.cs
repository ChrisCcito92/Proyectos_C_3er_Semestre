using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_11___Diccionarios
{
    public class Traductor
    {
        private DiccionarioIngles diccionario;
        public Traductor(DiccionarioIngles diccionario)
        {
            this.diccionario = diccionario ?? throw new ArgumentNullException(nameof(diccionario));
        }
        /// Solo traduce palabras que están en el diccionario
        /// Mantiene puntuación, mayúsculas y formato original
        public string TraducirFrase(string frase)
        {
            // Si la frase está vacía, devolvemos cadena vacía
            if (string.IsNullOrWhiteSpace(frase))
                return "";
            // Dividimos por espacios, tabuladores, saltos de línea
            string[] palabras = frase.Split(' ', '\t', '\n', '\r');
            StringBuilder resultado = new StringBuilder();
            foreach (string palabra in palabras)
            {
                if (string.IsNullOrEmpty(palabra))
                {
                    resultado.Append(" ");
                    continue;
                }
                // Separamos puntuación del inicio y fin de la palabra
                var (basePalabra, inicio, fin) = SepararPuntuacion(palabra);
                // Si la palabra base es vacía (solo signos), no se traduce
                if (string.IsNullOrEmpty(basePalabra))
                {
                    resultado.Append(palabra);
                }
                else
                {
                    // Buscamos la traducción en el diccionario
                    string traduccion = diccionario.TraducirPalabra(basePalabra);
                    string palabraFinal = traduccion ?? basePalabra; // Si no hay traducción, no realiza ningún cambio

                    // Reconstruye con puntuación
                    resultado.Append(inicio)
                              .Append(palabraFinal)
                              .Append(fin);
                }
                resultado.Append(" "); // Espacio entre palabras
            }
            return resultado.ToString().Trim(); // Elimina el espacio final
        }
        /// Separa una palabra en tres partes: puntuación inicial, palabra base y puntuación final
        private (string basePalabra, string inicio, string fin) SepararPuntuacion(string palabra)
        {
            char[] caracteres = palabra.ToCharArray();
            List<char> inicio = new List<char>();
            List<char> medio = new List<char>();
            List<char> fin = new List<char>();
            int i = 0;
            // Puntuación inicial (no letras)
            while (i < caracteres.Length && !char.IsLetter(caracteres[i]))
            {
                inicio.Add(caracteres[i]);
                i++;
            }
            // Parte principal (solo letras)
            while (i < caracteres.Length && char.IsLetter(caracteres[i]))
            {
                medio.Add(caracteres[i]);
                i++;
            }
            // Puntuación final
            while (i < caracteres.Length)
            {
                fin.Add(caracteres[i]);
                i++;
            }
            string basePalabra = new string(medio.ToArray());
            return (basePalabra, new string(inicio.ToArray()), new string(fin.ToArray()));
        }
    }
}