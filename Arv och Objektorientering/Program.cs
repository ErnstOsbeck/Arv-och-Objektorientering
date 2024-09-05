using System;

namespace uppgift
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in bredden för formen");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Skriv in höjden");
            double height = double.Parse(Console.ReadLine());

            Shape S = new Shape(width, height);

            Console.WriteLine("Är formen en Triangel (t) eller en Rektangel (r)?");
            string Typ = Console.ReadLine();

            if (Typ.ToLower() == "t")
            {
                S = new Triangle(width, height);
            }
            else if (Typ.ToLower() == "r")
            {
                S = new Rectangle(width, height);
            }
            S.Area();
            S.Circumference();
        }
    }
}
