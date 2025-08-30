using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_11___Diccionarios
{
    public class DiccionarioIngles
    {
        private Dictionary<string, string> diccionario;
        /// Inicializa el diccionario y carga un conjunto inicial de palabras
        public DiccionarioIngles()
        {
            diccionario = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            CargarPalabrasIniciales();
        }
        /// Estas palabras se añaden al diccionario
        private void CargarPalabrasIniciales()
        {
            var palabrasBase = new Dictionary<string, string>
            {
                { "Tiempo", "Time" },
                { "Persona", "Person" },
                { "Año", "Year" },
                { "Camino", "Way" },
                { "Forma", "Way" },
                { "Día", "Day" },
                { "Cosa", "Thing" },
                { "Hombre", "Man" },
                { "Mundo", "World" },
                { "Vida", "Life" },
                { "Mano", "Hand" },
                { "Parte", "Part" },
                { "Niño", "Child" },
                { "Niña", "Child" },
                { "Ojo", "Eye" },
                { "Mujer", "Woman" },
                { "Lugar", "Place" },
                { "Trabajo", "Work" },
                { "Semana", "Week" },
                { "Caso", "Case" },
                { "Punto", "Point" },
                { "Tema", "Point" },
                { "Gobierno", "Government" },
                { "Empresa", "Company" },
                { "Compañía", "Company" }
            };
            // Añadimos cada palabra solo si no existe aún
            foreach (var par in palabrasBase)
            {
                if (!diccionario.ContainsKey(par.Key))
                {
                    diccionario[par.Key] = par.Value;
                }
            }
        }
        /// Verifica si ´la palabra en inglés ya está registrada en el diccionario
        public bool ContienePalabra(string palabra)
        {
            return diccionario.ContainsKey(palabra);
        }
        /// Agrega una nueva palabra al diccionario o actualiza su traducción si ya existe
        public void AgregarPalabra(string ingles, string espanol)
        {
            if (string.IsNullOrWhiteSpace(ingles) || string.IsNullOrWhiteSpace(espanol))
            {
                return; // No se permite palabras vacías
            }
            string clave = ingles.Trim();
            string valor = espanol.Trim();
            diccionario[clave] = valor; // Si ya existe, se actualiza la palabra
        }
        /// Traduce una palabra individual del inglés al español
        public string TraducirPalabra(string palabra)
        {
            if (diccionario.TryGetValue(palabra, out string traduccion))
            {
                return traduccion;
            }
            return null; // No se encontró la palabra
        }
        /// Devuelve una lista de todas las palabras almacenadas en formato "Español — Inglés"
        public IEnumerable<string> ObtenerTodasLasPalabras()
        {
            foreach (var kvp in diccionario)
            {
                yield return $"{kvp.Key} — {kvp.Value}";
            }
        }
    }
}