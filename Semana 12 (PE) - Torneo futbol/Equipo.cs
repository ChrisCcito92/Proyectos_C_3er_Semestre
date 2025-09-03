using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_12__PE____Torneo_futbol
{
    public class Equipo
    {
        public string Nombre { get; private set; }
        private HashSet<Jugador> jugadores; // Evita duplicados
        // Constructor
        public Equipo(string nombre)
        {
            // Valida que se llene el nombre del equipo
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del equipo no puede estar vacío.");
            Nombre = nombre;
            jugadores = new HashSet<Jugador>(new JugadorComparer());
        }
        // Método para agregar un jugador (evita duplicados por nombre y número)
        public bool AgregarJugador(Jugador jugador)
        {
            if (jugador == null)
                throw new ArgumentNullException(nameof(jugador));

            return jugadores.Add(jugador);
        }
        // Método para obtener la lista de jugadores
        public IEnumerable<Jugador> ObtenerJugadores()
        {
            return jugadores.ToList(); // Devuelve una copia para proteger la integridad
        }
        // Método para verificar si un jugador está en el equipo
        public bool ContieneJugador(string nombre)
        {
            return jugadores.Any(j => j.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }
        // Sobrescritura de ToString
        public override string ToString()
        {
            return $"Equipo: {Nombre} ({jugadores.Count} jugadores)";
        }
    }
    // Comparador personalizado para Jugador (evita duplicados por nombre y número)
    public class JugadorComparer : IEqualityComparer<Jugador>
    {
        // Dos jugadores son iguales si tienen el mismo nombre y número de camiseta
        public bool Equals(Jugador x, Jugador y)
        {
            if (x == null || y == null) return false;
            return x.Nombre.Equals(y.Nombre, StringComparison.OrdinalIgnoreCase) &&
                   x.NumeroCamiseta == y.NumeroCamiseta;
        }
        // Genera un hash code basado en el nombre y número de camiseta
        public int GetHashCode(Jugador obj)
        {
            if (obj == null) return 0;
            int hash = 17;
            hash = hash * 23 + (obj.Nombre?.ToLower().GetHashCode() ?? 0);
            hash = hash * 23 + obj.NumeroCamiseta.GetHashCode();
            return hash;
        }
    }
}