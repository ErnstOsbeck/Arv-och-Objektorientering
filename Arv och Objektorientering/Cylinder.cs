using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift
{
    internal class Cylinder : IShape
    {
        double diameter;
        double height;
        public Cylinder(double d, double h)
        {
            diameter = d;
            height = h;
        }
        public void Area()
        {
            double A = ((diameter/2)*(diameter/2)*Math.PI)*2 + (diameter*Math.PI)*height;
            Console.WriteLine("Arean är " + A);
        }

        public void Circumference()
        {
            double C = diameter * Math.PI;
            Console.WriteLine("Omkretsen är " + C);
        }
    }
}
