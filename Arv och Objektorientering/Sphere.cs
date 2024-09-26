using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift
{
    internal class Sphere : IShape
    {
        double radius;
        public Sphere(double r)
        {
            radius = r;
        }
        public void Area()
        {
            double A = 4*Math.PI*(radius*radius);
            Console.WriteLine("Arean är " + A);
        }

        public void Circumference()
        {
            double C = (radius*2) * Math.PI;
            Console.WriteLine("Omkretsen är " + C);
        }
    }
}
