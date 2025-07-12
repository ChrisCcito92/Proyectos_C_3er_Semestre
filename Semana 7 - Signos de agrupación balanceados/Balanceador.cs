using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_7___Signos_de_agrupación_balanceados
{
    public class Balanceador
    {
        // Método que verifica si la expresión está balanceada
        public bool EstaBalanceada(string expresion)
        {
            // Se utiliza una pila para controlar los símbolos de apertura
            Stack<char> pila = new Stack<char>();

            // Recorremos cada caracter de la expresión
            foreach (char caracter in expresion)
            {
                // Si es un símbolo de apertura, se agrega a la pila
                if (EsApertura(caracter))
                {
                    pila.Push(caracter);
                }
                // Si es un símbolo de cierre
                else if (EsCierre(caracter))
                {
                    // Si la pila está vacía, significa que hay un cierre sin apertura
                    if (pila.Count == 0)
                    {
                        return false;
                    }

                    // Extrae el último símbolo abierto
                    char apertura = pila.Pop();

                    // Verificamos si la apertura y el cierre son del mismo tipo
                    if (!EsPareja(apertura, caracter))
                    {
                        return false;
                    }
                }
            }

            // Al final, si la pila está vacía, la expresión está balanceada
            return pila.Count == 0;
        }

        // Verifica si el carácter es un símbolo de apertura: (, {, [
        private bool EsApertura(char c)
        {
            return c == '(' || c == '{' || c == '[';
        }

        // Verifica si el carácter es un símbolo de cierre: ), }, ]
        private bool EsCierre(char c)
        {
            return c == ')' || c == '}' || c == ']';
        }

        // Verifica si un símbolo de apertura y uno de cierre forman una pareja válida
        private bool EsPareja(char apertura, char cierre)
        {
            return (apertura == '(' && cierre == ')') ||
                   (apertura == '{' && cierre == '}') ||
                   (apertura == '[' && cierre == ']');
        }
    }
}
