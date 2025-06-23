using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_estudiante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // muestra un mensaje de inicio
            Console.WriteLine("=== Registro de Estudiante ===");
            // solicita el ID del estudiante
            Console.Write("Ingrese el ID del estudiante: ");
            int id = int.Parse(Console.ReadLine());
            // solicita los nombres
            Console.Write("Ingrese los nombres del estudiante: ");
            string nombres = Console.ReadLine();
            // solicita los apellidos
            Console.Write("Ingrese los apellidos del estudiante: ");
            string apellidos = Console.ReadLine();
            // solicita la dirección
            Console.Write("Ingrese la dirección del estudiante: ");
            string direccion = Console.ReadLine();
            // crea un arreglo para almacenar tres teléfonos
            string[] telefonos = new string[3];
            // ciclo para ingresar los tres teléfonos
            for (int i = 0; i < telefonos.Length; i++)
            {
                Console.Write($"Ingrese el teléfono {i + 1}: ");
                telefonos[i] = Console.ReadLine();
            }
            // crea una instancia del objeto Estudiante
            Estudiante estudiante = new Estudiante(id, nombres, apellidos, direccion, telefonos);
            // llama al método que muestra los datos del estudiante
            estudiante.MostrarDatos();
            Console.ReadLine();
        }
    }
}