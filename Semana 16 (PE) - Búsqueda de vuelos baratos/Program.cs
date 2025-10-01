using System;
using System.Collections.Generic;
using Semana_16__PE____Búsqueda_de_vuelos_baratos;

namespace Semana_16__PE____Búsqueda_de_vuelos_baratos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=======================================");
            Console.WriteLine("=Sistema de Búsqueda de Vuelos Baratos=");
            Console.WriteLine("=======================================");
            // Crear la red de vuelos
            var red = new RedDeVuelos();
            // Crear aeropuertos
            var mad = new Aeropuerto("MAD", "Madrid", "España");
            var cdg = new Aeropuerto("CDG", "París", "Francia");
            var lhr = new Aeropuerto("LHR", "Londres", "Reino Unido");
            var fco = new Aeropuerto("FCO", "Roma", "Italia");
            var jfk = new Aeropuerto("JFK", "Nueva York", "EE.UU.");
            var lax = new Aeropuerto("LAX", "Los Ángeles", "EE.UU.");
            var nrt = new Aeropuerto("NRT", "Tokio", "Japón");
            var dub = new Aeropuerto("DUB", "Dublín", "Irlanda");
            // Agregar vuelos ficticios (red dispersa con múltiples rutas)
            red.AgregarVuelo(mad, cdg, 80);
            red.AgregarVuelo(mad, lhr, 100);
            red.AgregarVuelo(mad, fco, 90);
            red.AgregarVuelo(cdg, nrt, 600);
            red.AgregarVuelo(lhr, jfk, 400);
            red.AgregarVuelo(jfk, lax, 200);
            red.AgregarVuelo(lax, nrt, 500);
            red.AgregarVuelo(fco, cdg, 70);
            red.AgregarVuelo(cdg, dub, 120);
            red.AgregarVuelo(dub, jfk, 450);
            // Menú interactivo
            while (true)
            {
                Console.WriteLine("\n--- Menú ---");
                Console.WriteLine("1. Ver aeropuertos");
                Console.WriteLine("2. Ver vuelos");
                Console.WriteLine("3. Buscar ruta más barata");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                string? opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        red.MostrarAeropuertos();
                        break;
                    case "2":
                        red.MostrarVuelos();
                        break;
                    case "3":
                        BuscarRuta(red, mad, cdg, lhr, fco, jfk, lax, nrt, dub);
                        break;
                    case "4":
                        Console.WriteLine("¡Gracias por usar el sistema de vuelos!");
                        return;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
        // Método auxiliar para buscar una ruta específica (simplificado para demostración)
        static void BuscarRuta(RedDeVuelos red, params Aeropuerto[] aeropuertos)
        {
            Console.Write("\nIngrese código IATA de origen: ");
            string origenStr = Console.ReadLine()?.ToUpper() ?? "";
            Console.Write("Ingrese código IATA de destino: ");
            string destinoStr = Console.ReadLine()?.ToUpper() ?? "";
            var origen = Array.Find(aeropuertos, a => a.CodigoIATA == origenStr);
            var destino = Array.Find(aeropuertos, a => a.CodigoIATA == destinoStr);
            if (origen == null || destino == null)
            {
                Console.WriteLine("Aeropuerto no encontrado.");
                return;
            }
            try
            {
                var (costo, ruta) = red.EncontrarRutaMasBarata(origen, destino);
                if (costo == -1)
                {
                    Console.WriteLine($"\nNo existe ruta entre {origen} y {destino}.");
                }
                else
                {
                    Console.WriteLine($"\nRuta más barata encontrada:");
                    Console.WriteLine($"Costo total: ${costo:F2}");
                    Console.WriteLine("Ruta: " + string.Join(" -> ", ruta.ConvertAll(a => a.CodigoIATA)));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}