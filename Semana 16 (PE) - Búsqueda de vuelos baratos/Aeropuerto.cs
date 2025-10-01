using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_16__PE____Búsqueda_de_vuelos_baratos
{
    public class Aeropuerto
    {
        public string CodigoIATA { get; }
        public string Ciudad { get; }
        public string Pais { get; }
        // Constructor
        public Aeropuerto(string codigoIATA, string ciudad, string pais)
        {
            CodigoIATA = codigoIATA?.ToUpper() ?? throw new ArgumentNullException(nameof(codigoIATA));
            Ciudad = ciudad ?? throw new ArgumentNullException(nameof(ciudad));
            Pais = pais ?? throw new ArgumentNullException(nameof(pais));
        }
        // Sobrescritura de Equals para comparar por código IATA
        public override bool Equals(object? obj)
        {
            if (obj is Aeropuerto otro)
                return CodigoIATA == otro.CodigoIATA;
            return false;
        }
        // Sobrescritura de GetHashCode para uso en diccionarios y conjuntos
        public override int GetHashCode()
        {
            return CodigoIATA.GetHashCode();
        }
        // Representación legible del aeropuerto
        public override string ToString()
        {
            return $"{CodigoIATA} ({Ciudad}, {Pais})";
        }
    }
}