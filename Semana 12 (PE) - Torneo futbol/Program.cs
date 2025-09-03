using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_12__PE____Torneo_futbol
{
    public class Program
    {
        static void Main(string[] args)
        {
            var torneo = new Torneo();
            // Registrar equipos
            torneo.RegistrarEquipo("LDU");
            torneo.RegistrarEquipo("Aucas");
            // Crear jugadores
            var jugador1 = new Jugador("Juan Pérez", "Delantero", 9);
            var jugador2 = new Jugador("Carlos Gómez", "Mediocampista", 8);
            var jugador3 = new Jugador("Ana López", "Defensor", 3);
            var jugador4 = new Jugador("Juan Pérez", "Delantero", 9); // Duplicado
            // Agregar jugadores
            torneo.AgregarJugadorAEquipo("LDU", jugador1);
            torneo.AgregarJugadorAEquipo("LDU", jugador2);
            torneo.AgregarJugadorAEquipo("Aucas", jugador3);
            torneo.AgregarJugadorAEquipo("Aucas", jugador4); // No se agrega (duplicado)
            // Reportería
            torneo.MostrarEquipos();
            torneo.MostrarDetallesEquipo("LDU");
            torneo.MostrarDetallesEquipo("Aucas");
            torneo.BuscarJugador("Juan Pérez");
            torneo.BuscarJugador("Roberto Cruz"); // No existe
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}