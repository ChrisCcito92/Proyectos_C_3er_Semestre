using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_8_PE____Asignación_de_asientos
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        // Constructor para ingresar los datos de la persona
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
        // Método que muestra la información de la persona
        public override string ToString()
        {
            return $"{Nombre} ({Edad} años)";
        }
    }
}
