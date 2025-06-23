using System;
using System.Security.Permissions;

namespace AgendaClinica
{
    public class Paciente
    {
        // Permite obtener (get) y establecer (set) el valor desde otras clases.
        public string Nombre { get; set; }

        // Propiedad pública para almacenar la cédula del paciente.
        public string Cedula { get; set; }

        // Propiedad pública para almacenar la edad del paciente.
        public int Edad { get; set; }

        // Propiedad pública para almacenar el número de teléfono celular del paciente.
        public string Celular { get; set; }

        // Propiedad pública para almacenar la especialidad médica a la que asistirá el paciente.
        public string Especialidad { get; set; }
        public override string ToString()
        {
            // Devuelve una cadena con los datos principales del paciente.
            return $"Nombre: {Nombre}, Cedula: {Cedula}, Edad: {Edad}, Celular: {Celular}, Especialidad: {Especialidad}";
        }
    }
}