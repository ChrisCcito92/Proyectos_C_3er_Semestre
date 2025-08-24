using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_10___Conjuntos
{
    public class ServicioVacunacion
    {
        // Conjunto con todas las personas (500 en total)
        private HashSet<Persona> todasLasPersonas;
        // Conjunto con personas vacunadas con Pfizer (75)
        private HashSet<Persona> vacunadosPfizer;
        // Conjunto con personas vacunadas con AstraZeneca (75)
        private HashSet<Persona> vacunadosAstraZeneca;
        // Constructor: cuando se crea el servicio, se generan los datos
        public ServicioVacunacion()
        {
            GenerarDatosFicticios();
        }
        // Método para crear los 500 ciudadanos y elegir 75 aleatorios para cada vacuna
        private void GenerarDatosFicticios()
        {
            // Paso 1: Creamos 500 personas (Persona 1 hasta Persona 500)
            todasLasPersonas = new HashSet<Persona>();
            for (int i = 1; i <= 500; i++)
            {
                todasLasPersonas.Add(new Persona(i));
            }
            // Paso 2: Elegimos 75 personas al azar para Pfizer
            var random = new Random();
            var idsPfizer = new HashSet<int>(); // Usamos un conjunto para evitar repetidos
            while (idsPfizer.Count < 75)
            {
                int numero = random.Next(1, 501); // Número entre 1 y 500
                idsPfizer.Add(numero); // HashSet evita duplicados automáticamente
            }
            // Creamos el conjunto de personas vacunadas con Pfizer
            vacunadosPfizer = new HashSet<Persona>();
            foreach (int id in idsPfizer)
            {
                vacunadosPfizer.Add(new Persona(id));
            }
            // Paso 3: Elegimos 75 personas al azar para AstraZeneca
            var idsAstra = new HashSet<int>();
            while (idsAstra.Count < 75)
            {
                int numero = random.Next(1, 501);
                idsAstra.Add(numero);
            }
            // Creamos el conjunto de personas vacunadas con AstraZeneca
            vacunadosAstraZeneca = new HashSet<Persona>();
            foreach (int id in idsAstra)
            {
                vacunadosAstraZeneca.Add(new Persona(id));
            }
        }
        // 1. Devuelve las personas que NO se han vacunado con ninguna vacuna
        public HashSet<Persona> ObtenerNoVacunados()
        {
            // Primero unimos todos los vacunados (Pfizer + AstraZeneca)
            var vacunadosTotales = Conjuntos.Union(vacunadosPfizer, vacunadosAstraZeneca);

            // Luego, quitamos a los vacunados del conjunto total
            // Lo que queda son los que no se vacunaron
            return Conjuntos.Diferencia(todasLasPersonas, vacunadosTotales);
        }
        // 2. Devuelve las personas que recibieron AMBAS vacunas
        public HashSet<Persona> ObtenerAmbasDosis()
        {
            // Buscamos las personas que están en Pfizer Y en AstraZeneca
            return Conjuntos.Interseccion(vacunadosPfizer, vacunadosAstraZeneca);
        }
        // 3. Devuelve las personas que solo se vacunaron con Pfizer
        public HashSet<Persona> ObtenerSoloPfizer()
        {
            // Personas en Pfizer menos las que también están en AstraZeneca
            return Conjuntos.Diferencia(vacunadosPfizer, vacunadosAstraZeneca);
        }
        // 4. Devuelve las personas que solo se vacunaron con AstraZeneca
        public HashSet<Persona> ObtenerSoloAstraZeneca()
        {
            // Personas en AstraZeneca menos las que también están en Pfizer
            return Conjuntos.Diferencia(vacunadosAstraZeneca, vacunadosPfizer);
        }
        // Muestra los resultados en pantalla
        public void MostrarReporte()
        {
            // Obtenemos todos los resultados
            var noVacunados = ObtenerNoVacunados();
            var ambas = ObtenerAmbasDosis();
            var soloPfizer = ObtenerSoloPfizer();
            var soloAstra = ObtenerSoloAstraZeneca();
            // Mostramos encabezado
            Console.WriteLine("=== REPORTE DE VACUNACIÓN CONTRA EL COVID-19 ===\n");
            // Información general
            Console.WriteLine($"Total de personas: {todasLasPersonas.Count}");
            Console.WriteLine($"Vacunados con Pfizer: {vacunadosPfizer.Count}");
            Console.WriteLine($"Vacunados con AstraZeneca: {vacunadosAstraZeneca.Count}\n");
            // 1. No vacunados
            Console.WriteLine($"1. Personas que NO se han vacunado: {noVacunados.Count}");
            ImprimirEjemplos(noVacunados);
            // 2. Ambas vacunas
            Console.WriteLine($"\n2. Personas con ambas dosis: {ambas.Count}");
            ImprimirEjemplos(ambas);
            // 3. Solo Pfizer
            Console.WriteLine($"\n3. Solo Pfizer: {soloPfizer.Count}");
            ImprimirEjemplos(soloPfizer);
            // 4. Solo AstraZeneca
            Console.WriteLine($"\n4. Solo AstraZeneca: {soloAstra.Count}");
            ImprimirEjemplos(soloAstra);
        }
        // Método auxiliar para mostrar hasta 10 ejemplos de un conjunto
        private void ImprimirEjemplos(HashSet<Persona> lista)
        {
            int contador = 0;
            foreach (var persona in lista)
            {
                if (contador >= 10) break; // Mostramos máximo 10
                Console.Write($"{persona}, ");
                contador++;
            }
            // Si no hay nadie, decimos "Ninguno"
            if (contador == 0)
            {
                Console.Write("Ninguno");
            }
            else
            {
                Console.Write("\b\b "); // Borra la última coma y espacio
            }
        }
    }
}