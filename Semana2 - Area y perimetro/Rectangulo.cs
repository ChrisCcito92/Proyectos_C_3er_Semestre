using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2___Area_y_perimetro
{
    public class Rectangulo
    {
        private double arear, ancho, alto, perimetror; // se establecen los tipos de atributos
        public Rectangulo(double alto, double ancho) // constructor
        {
            this.alto = alto; // asigna el valor recibido al atributo 'alto'
            this.ancho = ancho; // asigna el valor recibido al atributo 'ancho'
        }
        public double Getancho() // método público para obtener el valor del ancho del rectángulo
        {
            return ancho;
        }
        public double Getaltoo() // método público para obtener el valor del alto del rectángulo
        {
            return alto;
        }
        public double CalcularAreaR() // método para calcular el área(encapsulados)
        {
            arear = ancho * alto; // fórmula del área de un rectángulo: base × altura
            return arear;
        }
        public double CalcularPerimetroR() // método para calcular el perímetro(encapsulados)
        {
            perimetror = (2*ancho)+(2*alto); // fórmula: 2×ancho + 2×alto
            return perimetror;
        }
    }
}
