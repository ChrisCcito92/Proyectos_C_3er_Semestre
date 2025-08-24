using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_10___Conjuntos
{
    public static class Conjuntos
    {
        // Devuelve los elementos que están en el primer conjunto pero NO en el segundo
        // Ejemplo: Personas en A pero no en B
        public static HashSet<Persona> Diferencia(HashSet<Persona> conjuntoA, HashSet<Persona> conjuntoB)
        {
            // Crea un nuevo conjunto para guardar el resultado
            var resultado = new HashSet<Persona>();
            // Recorre cada persona del primer conjunto
            foreach (var persona in conjuntoA)
            {
                // Si la persona NO está en el segundo conjunto, la agregamos
                if (!conjuntoB.Contains(persona))
                {
                    resultado.Add(persona);
                }
            }
            return resultado; // Devolvemos el conjunto resultante
        }
        // Devuelve solo las personas que están en AMBOS conjuntos
        // Ejemplo: Personas vacunadas con Pfizer Y con AstraZeneca
        public static HashSet<Persona> Interseccion(HashSet<Persona> conjuntoA, HashSet<Persona> conjuntoB)
        {
            var resultado = new HashSet<Persona>();
            // Recorre cada persona del primer conjunto
            foreach (var persona in conjuntoA)
            {
                // Si también está en el segundo conjunto, la agrega
                if (conjuntoB.Contains(persona))
                {
                    resultado.Add(persona);
                }
            }
            return resultado;
        }
        // Devuelve todas las personas de ambos conjuntos (sin repetirlas)
        public static HashSet<Persona> Union(HashSet<Persona> conjuntoA, HashSet<Persona> conjuntoB)
        {
            var resultado = new HashSet<Persona>();
            // Agrega todas las del primer conjunto
            foreach (var persona in conjuntoA)
            {
                resultado.Add(persona);
            }
            // Agrega todas las del segundo conjunto
            // HashSet no permite duplicados, así que si ya está, no se repite
            foreach (var persona in conjuntoB)
            {
                resultado.Add(persona);
            }
            return resultado;
        }
    }
}