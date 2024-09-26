using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift
{
    internal class Circle : IShape
    {
        double diameter;
        
        public Circle(double d) 
        {
            diameter = d;
        }
        public void Area()
        {
            double A = (diameter/2)*(diameter/2)*Math.PI;
            Console.WriteLine("Arean är " + A);
        }

        public void Circumference()
        {
            double C = diameter * Math.PI;
            Console.WriteLine("Omkretsen är " + C);
        }
    }
}
