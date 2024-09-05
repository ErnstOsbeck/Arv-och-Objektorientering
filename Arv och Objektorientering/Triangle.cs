using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uppgift;

namespace uppgift
{
    class Triangle : Shape
    {
        public Triangle(double w, double h) : base(w, h)
        {
            
        }
        public override void Area()
        {
            double A = (width * height) / 2;
            Console.WriteLine("Arean är " + A);
        }
        public override void Circumference()
        {
            double C = Math.Sqrt(width * width + height * height) + height + width;
            Console.WriteLine("Omkretsen är " + C);
        }
    }
}
