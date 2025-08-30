using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_11___Diccionarios
{
    public class Menu
    {
        private Traductor traductor;
        private DiccionarioIngles diccionario;
        /// Constructor del menú que inicializa el diccionario y el traductor
        public Menu()
        {
            diccionario = new DiccionarioIngles();
            traductor = new Traductor(diccionario);
        }
        /// Muestra el menú principal en bucle hasta que el usuario elija salir
        public void Mostrar()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("***** MENÚ *****");
                Console.WriteLine();
                Console.WriteLine("1. Traducir una frase");
                Console.WriteLine("2. Agrega una nueva palabra al diccionario");
                Console.WriteLine("0. Salir");
                Console.WriteLine();
                Console.Write("Seleccione una opción: ");
                // Valida que el valor ingresado sea un número
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = -1; // Opción inválida
                }
                // Procesamos la opción elegida
                switch (opcion)
                {
                    case 1:
                        OpcionTraducirFrase();
                        break;
                    case 2:
                        OpcionAgregarPalabra();
                        break;
                    case 0:
                        Console.WriteLine("\n¡Gracias por usar el traductor! Hasta luego.");
                        break;
                    default:
                        Console.WriteLine("\nOpción no válida. Por favor, elija 0, 1 o 2.");
                        break;
                }
                // Pausa antes de volver al menú (excepto al salir)
                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            } while (opcion != 0);
        }
        /// Este submenú permite al usuario ingresar una frase y ver su traducción parcial
        private void OpcionTraducirFrase()
        {
            Console.WriteLine("\n--- TRADUCIR FRASE ---");
            Console.Write("Ingrese una frase (en inglés o mixta): ");
            string frase = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(frase))
            {
                Console.WriteLine("No se ingresó ninguna frase.");
                return;
            }
            string traduccion = traductor.TraducirFrase(frase);
            Console.WriteLine($"\nTraducción (parcial): {traduccion}");
        }
        /// Submenú: permite al usuario agregar una nueva palabra al diccionario
        private void OpcionAgregarPalabra()
        {
            Console.WriteLine("\n--- AGREGAR PALABRA AL DICCIONARIO ---");
            Console.Write("Palabra en español: ");
            string espanol = Console.ReadLine();
            Console.Write("Traducción en inglés: ");
            string ingles = Console.ReadLine();
            // Validación básica
            if (string.IsNullOrWhiteSpace(ingles) || string.IsNullOrWhiteSpace(espanol))
            {
                Console.WriteLine("Error: Ambos campos son obligatorios.");
                return;
            }
            // Verificamos si ya existe
            if (diccionario.ContienePalabra(espanol))
            {
                Console.WriteLine($"Advertencia: La palabra '{espanol}' ya existe. Se actualizará.");
            }
            // Agregamos o actualizamos
            diccionario.AgregarPalabra(espanol, ingles);
            Console.WriteLine($"✅ Palabra '{espanol} — {ingles}' agregada/actualizada con éxito.");
        }
    }
}