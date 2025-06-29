using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen_de_materias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Se crea una instancia de la clase Curso
            Curso curso = new Curso();
            // Se llama al método para mostrar las asignaturas
            curso.MostrarMaterias();
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
