﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uppgift;

namespace uppgift
{
    internal class Rectangle : IShape
    {
        double width;
        double height;
        public Rectangle(double w, double h)
        {
            double width = w;

            double height = h;
        }
        public void Area()
        {
            double A = width * height;
            Console.WriteLine("Arean är " + A);
        }
        public void Circumference()
        {
            double C = width * 2 + height * 2;
            Console.WriteLine("Omkretsen är " + C);
        }
    }
}
