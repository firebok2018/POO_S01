using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ejercicio_01
{
    public class Rectangulo
    {
        //atributos
        private double b, h;
        //propiedades
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double H
        {
            get { return h; }
            set { h = value; }
        }
        //contructor
        public Rectangulo()
        {
            b = 0;
            h = 0;
        }
        //metodso
        public double calcPerimetro()
        {
            return 2+(b + h);
        }
        public double calcArea()
        {
            return b * h;
        }
        public double calcDiagonal()
        {
            return Math.Sqrt(b*b+h*h);
        }
        
    }
}
