using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_10___Conjuntos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos el servicio de vacunación (se generan los datos automáticamente)
            var servicio = new ServicioVacunacion();
            // Mostramos el reporte con todos los listados
            servicio.MostrarReporte();
            // Mensaje para que no se cierre la consola inmediatamente
            Console.WriteLine("\n\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}