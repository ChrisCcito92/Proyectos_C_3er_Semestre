using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_12__PE____Torneo_futbol
{
    public class Torneo
    {
        // Diccionario para almacenar equipos: clave = nombre del equipo
        private Dictionary<string, Equipo> equipos;
        // Constructor
        public Torneo()
        {
            equipos = new Dictionary<string, Equipo>(StringComparer.OrdinalIgnoreCase);
        }
        // Registra un nuevo equipo
        public void RegistrarEquipo(string nombreEquipo)
        {
            // Valida que se llene el nombre del equipo
            if (string.IsNullOrWhiteSpace(nombreEquipo))
                throw new ArgumentException("El nombre del equipo no puede estar vacío.");
            // Verifica si el equipo ya existe
            if (equipos.ContainsKey(nombreEquipo))
            {
                Console.WriteLine($"El equipo '{nombreEquipo}' ya está registrado.");
                return;
            }
            // Agrega el nuevo equipo
            equipos[nombreEquipo] = new Equipo(nombreEquipo);
            Console.WriteLine($"Equipo '{nombreEquipo}' registrado con éxito.");
        }
        // Agrega un jugador a un equipo
        public void AgregarJugadorAEquipo(string nombreEquipo, Jugador jugador)
        {
            // Valida que se llene el nombre del equipo
            if (!equipos.ContainsKey(nombreEquipo))
            {
                Console.WriteLine($"El equipo '{nombreEquipo}' no existe.");
                return;
            }
            var equipo = equipos[nombreEquipo];
            // Intenta agregar el jugador
            if (equipo.AgregarJugador(jugador))
            {
                Console.WriteLine($"Jugador {jugador.Nombre} agregado al equipo {nombreEquipo}.");
            }
            else
            {
                Console.WriteLine($"El jugador {jugador.Nombre} ya está en el equipo {nombreEquipo}.");
            }
        }
        // Reportería: Listar todos los equipos
        public void MostrarEquipos()
        {
            Console.WriteLine("\n=== LISTADO DE EQUIPOS ===");
            // Verifica si hay equipos registrados
            if (!equipos.Any())
            {
                Console.WriteLine("No hay equipos registrados.");
                return;
            }
            // Muestra cada equipo
            foreach (var equipo in equipos.Values)
            {
                Console.WriteLine(equipo);
            }
        }
        // Reportería: Mostrar detalles de un equipo
        public void MostrarDetallesEquipo(string nombreEquipo)
        {
            // Valida que se llene el nombre del equipo
            if (!equipos.TryGetValue(nombreEquipo, out var equipo))
            {
                Console.WriteLine($"Equipo '{nombreEquipo}' no encontrado.");
                return;
            }
            Console.WriteLine($"\n=== DETALLES DEL EQUIPO: {equipo.Nombre} ===");
            var jugadores = equipo.ObtenerJugadores().OrderBy(j => j.NumeroCamiseta).ToList();
            // Verifica si el equipo tiene jugadores
            if (!jugadores.Any())
            {
                Console.WriteLine("No tiene jugadores registrados.");
            }
            else
            {
                foreach (var jugador in jugadores)
                {
                    Console.WriteLine($"  - {jugador}");
                }
            }
        }
        // Reportería: Buscar jugador en todo el torneo
        public void BuscarJugador(string nombre)
        {
            Console.WriteLine($"\nBuscando jugador: {nombre}");
            var resultados = new List<(string Equipo, Jugador Jugador)>();
            // Busca al jugador en todos los equipos
            foreach (var par in equipos)
            {
                if (par.Value.ContieneJugador(nombre))
                {
                    var jugador = par.Value.ObtenerJugadores()
                        .FirstOrDefault(j => j.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
                    resultados.Add((par.Key, jugador));
                }
            }
            // Muestra los resultados
            if (resultados.Any())
            {
                Console.WriteLine("Jugador encontrado en los siguientes equipos:");
                foreach (var (equipo, jugador) in resultados)
                {
                    Console.WriteLine($"  - Equipo: {equipo} | {jugador}");
                }
            }
            else
            {
                Console.WriteLine("Jugador no encontrado en ningún equipo.");
            }
        }
    }
}