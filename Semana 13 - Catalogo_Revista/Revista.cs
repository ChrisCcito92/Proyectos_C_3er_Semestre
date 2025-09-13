using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_13___Catalogo_Revista
{
    public class Revista
    {
        // Propiedad que almacena el título de la revista
        public string Titulo { get; private set; }
        // Constructor de la clase Revista
        public Revista(string titulo)
        {
            Titulo = titulo ?? throw new ArgumentNullException(nameof(titulo));
        }
        // Sobrescribe el método ToString para mostrar el título de la revista
        public override string ToString()
        {
            return Titulo;
        }
    }
}