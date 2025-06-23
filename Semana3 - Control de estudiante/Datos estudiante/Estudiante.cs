using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_estudiante
{
    // esta clase define los datos personales del estudiante
    internal class Estudiante
    {
        // propiedades del estudiante
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        // arreglo para almacenar tres teléfonos
        public string[] Telefonos { get; set; }
        // constructor que inicializa los datos del estudiante
        public Estudiante (int id, string nombres, string apellidos, string direccion, string[] telefonos   )
        {
            // se asignan los valores a las propiedades
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            // inicializa el arreglo de teléfonos para que se ingresen tres
            Telefonos = new string[3];
            Array.Copy(telefonos, Telefonos, 3);
        }
        // método para mostrar los datos del estudiante
        public void MostrarDatos()
        {
            Console.WriteLine($"\n--- Datos del estudiante ---");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombres: {Nombres}");
            Console.WriteLine($"Apellidos: {Apellidos}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine("Teléfonos:");
            // recorre y muestra cada uno de los tres teléfonos
            for (int i = 0; i < Telefonos.Length; i++)
            {
                Console.WriteLine($"  - Teléfono {i + 1}: {Telefonos[i]}");
            }
        }
    }
}