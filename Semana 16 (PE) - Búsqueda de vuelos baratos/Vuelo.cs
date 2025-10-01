using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_16__PE____Búsqueda_de_vuelos_baratos
{
    public class Vuelo
    {
        public Aeropuerto Origen { get; }
        public Aeropuerto Destino { get; }
        public double Costo { get; }
        // Constructor
        public Vuelo(Aeropuerto origen, Aeropuerto destino, double costo)
        {
            Origen = origen ?? throw new ArgumentNullException(nameof(origen));
            Destino = destino ?? throw new ArgumentNullException(nameof(destino));
            if (costo < 0) throw new ArgumentException("El costo no puede ser negativo.", nameof(costo));
            Costo = costo;
        }
        // Representación legible del vuelo
        public override string ToString()
        {
            return $"{Origen.CodigoIATA} -> {Destino.CodigoIATA} | Costo: ${Costo:F2}";
        }
    }
}