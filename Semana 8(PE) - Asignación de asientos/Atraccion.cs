using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_8_PE____Asignación_de_asientos
{
    public class Atraccion
    {
        private Queue<Persona> colaEspera; // Cola FIFO para la gestionón del orden de llegada
        private int capacidadMaxima; // Número máximo de asientos
        // Constructor que inicializa la cola y establece la capacidad máxima
        public Atraccion(int capacidadMaxima)
        {
            this.capacidadMaxima = capacidadMaxima; // Asignación de la capacidad máxima
            colaEspera = new Queue<Persona>();
        }
        // Agrega una persona a la cola si esta no está llena
        public bool AgregarPersona(Persona persona)
        {
            if (colaEspera.Count < capacidadMaxima) // SE usa "capacidadMaxima" aquí
            {
                colaEspera.Enqueue(persona);
                return true;
            }
            else
            {
                Console.WriteLine("La atracción está completa. La persona no puede ser agregada en este momento.");
                return false;
            }
        }
        // Inicia la atracción, mostrando a las personas que suben
        public void IniciarAtraccion()
        {
            if (colaEspera.Count == 0)
            {
                Console.WriteLine("No hay personas en la cola.");
                return;
            }
            Console.WriteLine("\n+++ La atracción inició +++");
            while (colaEspera.Count > 0)
            {
                Persona persona = colaEspera.Dequeue();
                Console.WriteLine($"{persona.Nombre} ha subido a la atracción.");
            }
            Console.WriteLine("+++ La atracción ha terminado +++\n");
        }
        // Muestra el estado actual de la cola
        public void MostrarCola()
        {
            if (colaEspera.Count == 0)
            {
                Console.WriteLine("La cola está vacía.");
                return;
            }
            Console.WriteLine("\nEstado actual de la cola:");
            foreach (Persona persona in colaEspera)
            {
                Console.WriteLine($"- {persona}");
            }
        }
    }
}