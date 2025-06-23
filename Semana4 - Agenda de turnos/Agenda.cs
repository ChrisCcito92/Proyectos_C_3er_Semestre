using System;
using System.Collections.Generic;

namespace AgendaClinica
{
    public class Agenda
    {
        // Se inicializa una nueva lista vacía.
        private List<Turno> turnos = new List<Turno>();

        // Método  que permite agregar un nuevo turno a la lista.
        public void AgregarTurno(Turno turno)
        {
            // Agrega el turno recibido como parámetro a la lista interna de turnos.
            turnos.Add(turno);
        }
        // Muestra todos los turnos almacenados en consola.
        public void MostrarTurnos()
        {
            // Verifica si la lista está vacía.
            if (turnos.Count == 0)
            {
                // Si no hay turnos, muestra un mensaje.
                Console.WriteLine("No hay turnos programados");
                return; // Sale del método.
            }

            // Recorre cada elemento de la lista de turnos usando un bucle foreach.
            foreach (var t in turnos)
            {
                // Muestra el turno en consola que normalmente devuelve los datos del turno.
                Console.WriteLine(t);
            }
        }
    }
}