using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_13___Catalogo_Revista
{
    public class Busqueda
    {
        // Realiza una búsqueda iterativa de una revista por título en una lista
        public static bool BuscarIterativo(List<Revista> revistas, string titulo)
        {
            if (revistas == null) throw new ArgumentNullException(nameof(revistas));
            if (string.IsNullOrWhiteSpace(titulo)) throw new ArgumentException("El título no puede estar vacío.", nameof(titulo));

            foreach (var revista in revistas)
            {
                if (string.Equals(revista.Titulo, titulo, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }
        // Realiza una búsqueda recursiva de una revista por título en una lista
        public static bool BuscarRecursivo(List<Revista> revistas, string titulo, int indice = 0)
        {
            if (revistas == null) throw new ArgumentNullException(nameof(revistas));
            if (string.IsNullOrWhiteSpace(titulo)) throw new ArgumentException("El título no puede estar vacío.", nameof(titulo));
            // Si el índice supera el tamaño de la lista, no se encontró
            if (indice >= revistas.Count)
                return false;
            // Si el título coincide, se encontró
            if (string.Equals(revistas[indice].Titulo, titulo, StringComparison.OrdinalIgnoreCase))
                return true;
            // Llamada recursiva al siguiente elemento
            return BuscarRecursivo(revistas, titulo, indice + 1);
        }
    }
}
