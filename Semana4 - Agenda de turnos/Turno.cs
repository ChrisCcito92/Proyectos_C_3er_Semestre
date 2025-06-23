using System;

namespace AgendaClinica
{
    public class Turno
    {
        // Permite obtener y establecer el objeto Paciente del turno.
         public Paciente Paciente { get; set; }
        // Permite obtener y establecer la fecha y hora del turno.
        public DateTime FechaHora { get; set; }
        // Este método se llama automáticamente cuando se imprime el objeto.
        public override string ToString()
        {
            // Muestra los datos principales del turno
            return $"Fecha/Hora del agendamiento: {FechaHora}, Paciente: {Paciente.Nombre} - Cédula: {Paciente.Cedula} | Teléfono celular: {Paciente.Celular} | Especialidad: {Paciente.Especialidad}";
        }
    }
}