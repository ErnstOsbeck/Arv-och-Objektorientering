using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uppgift;

namespace uppgift
{
    internal class Rectangle : Shape
    {
        public Rectangle(double w, double h) : base(w, h)
        {
            
        }
        public override void Area()
        {
            double A = width * height;
            Console.WriteLine("Arean är " + A);
        }
        public override void Circumference()
        {
            double C = width * 2 + height * 2;
            Console.WriteLine("Omkretsen är " + C);
        }
    }
}
