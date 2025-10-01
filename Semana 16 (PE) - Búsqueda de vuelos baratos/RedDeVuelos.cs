using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_16__PE____Búsqueda_de_vuelos_baratos
{
    public class RedDeVuelos
    {
        // Lista de adyacencia: cada aeropuerto tiene una lista de vuelos salientes
        private readonly Dictionary<Aeropuerto, List<Vuelo>> _grafo = new();
        // Agrega un vuelo a la red (crea nodos si no existen)
        public void AgregarVuelo(Aeropuerto origen, Aeropuerto destino, double costo)
        {
            var vuelo = new Vuelo(origen, destino, costo);
            // Asegurar que el origen esté en el grafo
            if (!_grafo.ContainsKey(origen))
                _grafo[origen] = new List<Vuelo>();
            _grafo[origen].Add(vuelo);
            // Asegurar que el destino esté en el grafo (aunque no tenga salidas)
            if (!_grafo.ContainsKey(destino))
                _grafo[destino] = new List<Vuelo>();
        }
        // Muestra todos los aeropuertos registrados
        public void MostrarAeropuertos()
        {
            Console.WriteLine("\n--- Aeropuertos en la red ---");
            foreach (var aeropuerto in _grafo.Keys.OrderBy(a => a.CodigoIATA))
            {
                Console.WriteLine(aeropuerto);
            }
        }
        // Muestra todos los vuelos disponibles
        public void MostrarVuelos()
        {
            Console.WriteLine("\n--- Vuelos disponibles ---");
            bool hayVuelos = false;
            foreach (var kvp in _grafo)
            {
                foreach (var vuelo in kvp.Value)
                {
                    Console.WriteLine(vuelo);
                    hayVuelos = true;
                }
            }
            if (!hayVuelos)
                Console.WriteLine("No hay vuelos registrados.");
        }
        // Encuentra la ruta más barata entre dos aeropuertos usando Dijkstra
        public (double costoTotal, List<Aeropuerto> ruta) EncontrarRutaMasBarata(Aeropuerto origen, Aeropuerto destino)
        {
            if (!_grafo.ContainsKey(origen) || !_grafo.ContainsKey(destino))
            {
                throw new ArgumentException("Origen o destino no existen en la red.");
            }
            // Distancia mínima conocida a cada aeropuerto
            var distancias = new Dictionary<Aeropuerto, double>();
            // Predecesor para reconstruir la ruta
            var predecesores = new Dictionary<Aeropuerto, Aeropuerto>();
            // Conjunto de aeropuertos ya procesados
            var visitados = new HashSet<Aeropuerto>();
            // Inicializar distancias
            foreach (var aeropuerto in _grafo.Keys)
            {
                distancias[aeropuerto] = double.PositiveInfinity;
                predecesores[aeropuerto] = null!;
            }
            distancias[origen] = 0;
            // Cola de prioridad (simulada con lista y ordenamiento)
            var cola = new List<Aeropuerto>(_grafo.Keys);
            while (cola.Count > 0)
            {
                // Seleccionar el aeropuerto no visitado con menor distancia
                var actual = cola
                    .Where(a => !visitados.Contains(a))
                    .OrderBy(a => distancias[a])
                    .FirstOrDefault();
                if (actual == null || distancias[actual] == double.PositiveInfinity)
                    break; // No hay más nodos alcanzables
                visitados.Add(actual);
                cola.Remove(actual);
                // Si llegamos al destino, podemos terminar temprano (opcional)
                if (actual.Equals(destino))
                    break;
                // Relajar las aristas salientes
                if (_grafo.TryGetValue(actual, out var vuelos))
                {
                    foreach (var vuelo in vuelos)
                    {
                        double nuevaDistancia = distancias[actual] + vuelo.Costo;
                        if (nuevaDistancia < distancias[vuelo.Destino])
                        {
                            distancias[vuelo.Destino] = nuevaDistancia;
                            predecesores[vuelo.Destino] = actual;
                        }
                    }
                }
            }
            // Reconstruir la ruta
            var ruta = new List<Aeropuerto>();
            if (distancias[destino] != double.PositiveInfinity)
            {
                var paso = destino;
                while (paso != null!)
                {
                    ruta.Insert(0, paso);
                    paso = predecesores[paso];
                }
            }
            double costo = distancias[destino] == double.PositiveInfinity ? -1 : distancias[destino];
            return (costo, ruta);
        }
    }
}