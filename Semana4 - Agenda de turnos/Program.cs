using System;
using System.Collections.Generic;

namespace AgendaClinica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crea una nueva instancia de la clase Agenda para gestionar los turnos.
            Agenda agenda = new Agenda();
            // Mientras sea false, el programa seguirá ejecutándose.
            bool salir = false;
            // Bucle while infinito que se repite hasta que el usuario decida salir (salir == true)
            while (!salir)
            {
                // Muestra un mensaje de encabezado del sistema de agendamiento
                Console.WriteLine("***SISTEMA DE AGENDAMIENTO DE CITAS MÉDICAS***");
                // Muestra las opciones del menú principal
                Console.WriteLine("\n--- Menú ---");
                Console.WriteLine("1. Agregar Turno");
                Console.WriteLine("2. Mostrar Todos los Turnos");
                Console.WriteLine("3. Salir");
                // Solicita al usuario que seleccione una opción
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();
                // Inicia una estructura de decisión switch según la opción seleccionada
                switch (opcion)
                {
                    // Caso 1: El usuario quiere agregar un nuevo turno
                    case "1":
                        // Solicita y lee el nombre del paciente
                        Console.Write("Ingrese nombre del paciente: ");
                        string nombre = Console.ReadLine();
                        // Solicita y lee la cédula del paciente
                        Console.Write("Ingrese Cédula: ");
                        string cedula = Console.ReadLine();
                        // Solicita y lee la edad del paciente
                        Console.Write("Ingrese edad: ");
                        int edad = int.Parse(Console.ReadLine());
                        // Solicita y lee el número celular del paciente
                        Console.Write("Ingrese # celular: ");
                        string celular = Console.ReadLine();
                        // Solicita y lee la especialidad médica requerida
                        Console.Write("Ingrese especialidad requerida: ");
                        string especialidad = Console.ReadLine();
                        // Crea un nuevo objeto Paciente y asigna sus propiedades
                        Paciente p = new Paciente()
                        {
                            Nombre = nombre,
                            Cedula = cedula,
                            Edad = edad,
                            Celular = celular,
                            Especialidad = especialidad
                        };
                        // Solicita y lee la fecha y hora del turno
                        Console.Write("Ingrese fecha y hora del turno (dd/MM/yyyy HH:mm): ");
                        DateTime fechaHora = DateTime.Parse(Console.ReadLine());
                        // Crea un nuevo objeto Turno y lo asocia al paciente creado
                        Turno nuevoTurno = new Turno()
                        {
                            Paciente = p,
                            FechaHora = fechaHora
                        };
                        // Llama al método AgregarTurno de la agenda para guardar este nuevo turno
                        agenda.AgregarTurno(nuevoTurno);
                        // Confirma al usuario que el turno fue asignado correctamente
                        Console.WriteLine("Turno asignado correctamente");
                        break; // Sale del caso 1

                    // Caso 2: El usuario quiere ver todos los turnos registrados
                    case "2":
                        // Muestra un título para la lista de turnos
                        Console.WriteLine("\n--- Lista de Turnos ---");
                        // Llama al método MostrarTurnos() de la agenda para imprimir todos los turnos
                        agenda.MostrarTurnos();
                        break; // Sale del caso 2
                    // Caso 3: El usuario desea salir del programa
                    case "3":
                        // Cambia el valor de 'salir' a true, lo cual romperá el bucle while
                        salir = true;
                        // Muestra un mensaje indicando que el programa está terminando
                        Console.WriteLine("Saliendo...");
                        break; // Sale del caso 3
                    // Si el usuario ingresa una opción no válida
                    default:
                        // Muestra un mensaje de error
                        Console.WriteLine("Opción no válida");
                        break; // Sale del caso por defecto
                }
            }
        }
    }
}