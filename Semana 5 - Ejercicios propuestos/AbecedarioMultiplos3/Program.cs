using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbecedarioMultiplos3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear instancia del abecedario
            Abecedario abecedario = new Abecedario();

            // Eliminar posiciones múltiplos de 3
            abecedario.EliminarMultiplosDeTres();

            // Mostrar el resultado
            abecedario.MostrarLetras();

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
