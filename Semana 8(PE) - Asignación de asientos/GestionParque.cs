using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_8_PE____Asignación_de_asientos
{
    public class GestionParque
    {
        private Atraccion atraccion;
        // Constructor: recibe la capacidad máxima de la atracción
        public GestionParque(Atraccion atraccion)
        {
            this.atraccion = atraccion;
        }
        // Menú para mostrar al usuario
        public void MostrarMenu()
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("\n+++ Reserva de entradas - Parque de Diversiones +++");
                Console.WriteLine("\n1. Agregar una persona a la cola");
                Console.WriteLine("2. Iniciar atracción");
                Console.WriteLine("3. Mostrar cola actual");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        AgregarPersonaManual();
                        break;
                    case "2":
                        atraccion.IniciarAtraccion();
                        break;
                    case "3":
                        atraccion.MostrarCola();
                        break;
                    case "4":
                        salir = true;
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            }
        }
        // Método para ingresar una persona de forma manual
        private void AgregarPersonaManual()
        {
            Console.Write("Ingrese el nombre de la persona: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la edad de la persona: ");
            if (int.TryParse(Console.ReadLine(), out int edad))
            {
                Persona persona = new Persona(nombre, edad);
                if (atraccion.AgregarPersona(persona))
                {
                    Console.WriteLine($"{nombre} ha sido agregado(a) a la cola.");
                }
            }
            else
            {
                Console.WriteLine("Edad inválida. No se puede agregar a la persona.");
            }
        }
    }
}
