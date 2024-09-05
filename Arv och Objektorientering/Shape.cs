using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift
{
    internal class Shape
    {
        protected double width;

        protected double height;

        public Shape(double w, double h)
        {
            width = w;

            height = h;
        }
        public virtual void Circumference()
        {

        }
        public virtual void Area()
        {

        }
    }
}
