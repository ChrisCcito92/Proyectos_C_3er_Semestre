using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_13___Catalogo_Revista
{
    public class CatalogoRevistas
    {
        // Lista interna que almacena las revistas del catálogo
        private readonly List<Revista> _revistas;
        // Constructor que inicializa el catálogo con una lista vacía
        public CatalogoRevistas()
        {
            _revistas = new List<Revista>();
        }
        // Agrega una revista al catálogo
        public void AgregarRevista(Revista revista)
        {
            if (revista == null) throw new ArgumentNullException(nameof(revista));
            _revistas.Add(revista);
        }
        // Busca una revista por título usando el método iterativo
        public bool BuscarIterativo(string titulo)
        {
            return Busqueda.BuscarIterativo(_revistas, titulo);
        }
        // Busca una revista por título usando el método recursivo
        public bool BuscarRecursivo(string titulo)
        {
            return Busqueda.BuscarRecursivo(_revistas, titulo);
        }
        // Obtiene todas las revistas en el catálogo
        public IReadOnlyList<Revista> ObtenerTodas()
        {
            return _revistas.AsReadOnly();
        }
    }
}