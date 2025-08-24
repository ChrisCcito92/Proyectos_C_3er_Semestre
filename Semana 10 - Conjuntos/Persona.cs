using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_10___Conjuntos
{
    public class Persona
    {
        // Propiedad para guardar el número único de la persona
        public int Id { get; set; }
        // Propiedad para guardar el nombre
        public string Nombre { get; set; }
        // Constructor: cuando creamos una persona, se le asigna su Id y Nombre
        public Persona(int id)
        {
            Id = id;
            Nombre = $"Persona {id}"; // Se crea el nombre de manera automática: Persona 1, Persona 2, etc.
        }
        // Este método ayuda a mostrar el nombre cuando imprimimos la persona
        public override string ToString()
        {
            return Nombre;
        }
        // Estos dos métodos son importantes para que los conjuntos puedan comparar si dos personas son iguales por su Id
        public override bool Equals(object obj)
        {
            if (obj is Persona otra)
                return Id == otra.Id; // Si tienen el mismo Id, son la misma persona
            return false;
        }
        // Este método ayuda a que los conjuntos funcionen bien
        public override int GetHashCode()
        {
            return Id.GetHashCode(); // Usamos el Id para identificar a la persona
        }
    }
}