using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_8_PE____Asignación_de_asientos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicializamos la atracción con solo 30 asientos
            Atraccion montanaRusa = new Atraccion(30);
            // Creamos el gestor del parque
            GestionParque sistema = new GestionParque(montanaRusa);
            // Mostramos el menú de acciones para el usuario
            sistema.MostrarMenu();
        }
    }
}
