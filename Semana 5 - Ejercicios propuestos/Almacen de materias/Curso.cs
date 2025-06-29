using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen_de_materias
{
    public class Curso
    {
        public List<string> Materias { get; set; }
        // Constructor de la clase que inicializa la lista con las asignaturas predeterminadas
        public Curso()
        {
            // Agrega las asignaturas a la lista de materias
            Materias = new List<string>
            {
                "Matemáticas",
                "Lenguaje y Comunicación",
                "Ciencias Naturales",
                "Ciencias Sociales",
                "Educación Física",
                "Inglés"
            };
        }
        // Método que muestra las asignaturas por pantalla
        public void MostrarMaterias()
        {
            Console.WriteLine("Materias del curso:");
            // Recorre cada asignatura en la lista y la imprime en consola
            foreach (var materia in Materias)
            {
                Console.WriteLine($"- {materia}");
            }
        }
    }
}
