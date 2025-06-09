using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2___Area_y_perimetro // método principal donde se ejecuta el programa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuadrado miCuadrado = new Cuadrado(3.5); // crea una instancia de la clase Cuadrado con lado 3.5
            double valorLado = miCuadrado.Getlado(); // obtiene el valor del lado del cuadrado
            double area = miCuadrado.CalcularArea(); // calcula el área del cuadrado
            double perimetro = miCuadrado.CalcularPerimetro(); // calcula el perímetro del cuadrado
            Rectangulo miRectangulo = new Rectangulo(4, 7); // crea una instancia de la clase Rectángulo con ancho 4 y alto 7
            double valorAlto = miRectangulo.Getaltoo(); // obtiene el valor del alto del rectángulo
            double valorAncho = miRectangulo.Getancho(); // obtiene el valor del ancho del rectángulo
            double arear = miRectangulo.CalcularAreaR(); // calcula el área del rectángulo
            double perimetror = miRectangulo.CalcularPerimetroR(); // calcula el perímetro del rectángulo
            Console.WriteLine("Área del cuadrado"); // muestra los resultados en consola
            Console.WriteLine("El lado del cuadrado es de:" + valorLado);
            Console.WriteLine("El área del cuadrado es de:" + area);
            Console.WriteLine("El perímetro del cuadrado es de:" + perimetro);
            Console.WriteLine("\n\nÁrea del rectángulo");
            Console.WriteLine("El ancho del rectángulo es de:" + valorAncho);
            Console.WriteLine("El Alto del rectángulo es de:" + valorAlto);
            Console.WriteLine("El área del rectángulo es de:" + arear);
            Console.WriteLine("El perímetro del rectángulo es de:" + perimetror);
            Console.Read(); // espera que el usuario presione una tecla antes de cerrar

        }
    }
}
