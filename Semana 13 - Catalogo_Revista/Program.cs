using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Semana_13___Catalogo_Revista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crea la instancia del catálogo
            var catalogo = new CatalogoRevistas();
            // Inicializa con al menos 10 títulos de revistas
            InicializarCatalogo(catalogo);
            Console.WriteLine("--Bienvenido al Catálogo de Revistas--\n");
            bool ejecutando = true;
            // Bucle principal del menú
            while (ejecutando)
            {
                MostrarMenu();
                string opcion = Console.ReadLine();
                switch (opcion?.Trim())
                {
                    case "1":
                        Console.WriteLine("-Búsqueda Iterativa-\r\n" +
                        "La búsqueda iterativa utiliza bucles(como for, while, foreach) para recorrer los elementos de una colección uno por uno, hasta encontrar el que coincide con lo que estamos buscando(o hasta terminar la lista).\n\n");
                        BuscarPorIteracion(catalogo);
                        break;
                    case "2":
                        Console.WriteLine("-Búsqueda Recursiva-\r\n" +
                        "La búsqueda recursiva es aquella en la que una función se llama a sí misma para resolver un problema más pequeño, hasta llegar a un caso base que detiene la recursión.\n\n");
                        BuscarPorRecursion(catalogo);
                        break;
                    case "3":
                        MostrarCatalogo(catalogo);
                        break;
                    case "4":
                        Console.WriteLine("¡Gracias por usar el catálogo! Hasta luego.");
                        ejecutando = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 4.");
                        break;
                }
                // Pausa antes de mostrar el menú nuevamente
                if (ejecutando)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        // Muestra el menú de opciones al usuario
        private static void MostrarMenu()
        {
            Console.WriteLine("=== Menú Principal ===");
            Console.WriteLine("1. Buscar revista (método iterativo)");
            Console.WriteLine("2. Buscar revista (método recursivo)");
            Console.WriteLine("3. Mostrar todas las revistas");
            Console.WriteLine("4. Salir");
            Console.Write("\nSeleccione una opción: ");
        }
        // Inicializa el catálogo con 10 revistas de ejemplo
        private static void InicializarCatalogo(CatalogoRevistas catalogo)
        {
            var titulos = new[]
            {
            "Cosas",
            "Vanidades",
            "Diners",
            "Vistazo",
            "Lideres",
            "Forbes",
            "Hogar",
            "Familia",
            "National Geographic",
            "Estadio"
        };
            foreach (var titulo in titulos)
            {
                catalogo.AgregarRevista(new Revista(titulo));
            }
            Console.WriteLine($"Catálogo inicializado con {titulos.Length} revistas.\n");
        }
        // Realiza una búsqueda iterativa según el título ingresado por el usuario
        private static void BuscarPorIteracion(CatalogoRevistas catalogo)
        {
            Console.Write("Ingrese el título a buscar (iterativo): ");
            string titulo = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(titulo))
            {
                Console.WriteLine("El título no puede estar vacío.");
                return;
            }
            bool encontrado = catalogo.BuscarIterativo(titulo);
            if (encontrado)
                Console.WriteLine("Encontrado");
            else
                Console.WriteLine("No encontrado");
        }
        // Realiza una búsqueda recursiva según el título ingresado por el usuario
        private static void BuscarPorRecursion(CatalogoRevistas catalogo)
        {
            Console.Write("Ingrese el título a buscar (recursivo): ");
            string titulo = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(titulo))
            {
                Console.WriteLine("El título no puede estar vacío.");
                return;
            }
            bool encontrado = catalogo.BuscarRecursivo(titulo);

            if (encontrado)
                Console.WriteLine("Encontrado");
            else
                Console.WriteLine("No encontrado");
        }
        // Muestra todas las revistas en el catálogo
        private static void MostrarCatalogo(CatalogoRevistas catalogo)
        {
            var revistas = catalogo.ObtenerTodas();
            Console.WriteLine("\n=== Catálogo de Revistas ===");
            for (int i = 0; i < revistas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {revistas[i]}");
            }
            if (revistas.Count == 0)
            {
                Console.WriteLine("El catálogo está vacío.");
            }
        }
    }
}