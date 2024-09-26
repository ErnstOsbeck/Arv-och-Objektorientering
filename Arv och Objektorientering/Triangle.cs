using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uppgift;

namespace uppgift
{
    class Triangle : IShape
    {
        double width;
        double height;
        public Triangle(double w, double h)
        {
            width = w;

            height = h;
        }
        public void Area()
        {
            double A = (width * height) / 2;
            Console.WriteLine("Arean är " + A);
        }

        public void Circumference()
        {
            double C = Math.Sqrt(width * width + height * height) + height + width;
            Console.WriteLine("Omkretsen är " + C);
        }
    }
}
