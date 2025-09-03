using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_12__PE____Torneo_futbol
{
    public class Jugador
    {
        // Propiedades autoimplementadas
        public string Nombre { get; private set; }
        public string Posicion { get; private set; }
        public int NumeroCamiseta { get; private set; }
        // Constructor para inicializar un jugador
        public Jugador(string nombre, string posicion, int numeroCamiseta)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del jugador no puede estar vacío.");
            Nombre = nombre;
            Posicion = posicion;
            NumeroCamiseta = numeroCamiseta;
        }
        // Sobrescribir ToString para mostrar información del jugador
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Posición: {Posicion}, N°: {NumeroCamiseta}";
        }
    }
}