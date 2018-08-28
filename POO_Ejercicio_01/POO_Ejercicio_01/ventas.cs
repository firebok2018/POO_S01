using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ejercicio_01
{
    class ventas
    {
        private double precio;
        private double des;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public double Des
        {
            get { return des; }
            set { des = value; }
        }
        public ventas()
        {
            precio = 0;
            des = 0;
        }
        
        public double calDesc()
        {
            
            if (precio>=500)
            {
                return des = precio * 0.02;
            }
            else
            {
                return des = precio * 0.10;
            }
           
        }
        public double calPreventa()
        {
        
            return precio- calDesc();
        }
    }
}
