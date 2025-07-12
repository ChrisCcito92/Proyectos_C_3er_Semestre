using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_7___Signos_de_agrupación_balanceados
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Se crea una instancia del verificador
            Balanceador checker = new Balanceador();
            // Pide al usuario que ingrese una expresión matemática
            Console.WriteLine("Ingrese una expresión matemática:");
            string expresion = Console.ReadLine();
            // Llama al método para verificar
            if (checker.EstaBalanceada(expresion))
            {
                Console.WriteLine("Fórmula balanceada.");
            }
            else
            {
                Console.WriteLine("Fórmula no balanceada.");
            }
        }
    }
}
