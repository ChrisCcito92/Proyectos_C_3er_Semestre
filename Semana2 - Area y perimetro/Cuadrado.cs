using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2___Area_y_perimetro
{
    public class Cuadrado // define la clase pública Cuadrado
    {
        private double lado, area, perimetro;// se establecen los tipos de atributos
        public Cuadrado(double lado)// constructor
        { 
            this.lado = lado; // asigna el valor recibido al atributo 'lado' usando 'this'
        }
        public double Getlado()  // método público para obtener el valor del lado del cuadrado
        {
            return lado;
        }
        public double CalcularArea() // método para calcular el área(encapsulados)
        {
            area = lado * lado; // fórmula del área de un cuadrado: lado × lado
            return area;
        }
        public double CalcularPerimetro() // método para calcular el perímetro(encapsulados)
        {
            perimetro = lado * 4; // fórmula del perímetro de un cuadrado: lado × 4
            return perimetro;
        }
    }
}
