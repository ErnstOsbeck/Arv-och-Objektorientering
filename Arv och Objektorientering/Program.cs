using System;

namespace uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape S = null;

            Console.WriteLine("Vilken typ av form är det?");
            Console.WriteLine("1. Triangel");
            Console.WriteLine("2. Rektangel");
            Console.WriteLine("3. Cirkel");
            Console.WriteLine("4. Sfär");
            Console.WriteLine("5. Cylinder");

            int Typ = int.Parse(Console.ReadLine());
            switch (Typ)
            {
                case 1:
                {
                    Console.WriteLine("Vad är bredden?");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vad är höjden?");
                    int h = int.Parse(Console.ReadLine());
                    S = new Triangle(b, h);
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Vad är bredden?");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vad är höjden?");
                    int h = int.Parse(Console.ReadLine());
                    S = new Rectangle(b, h);
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Vad är diametern?");
                    int d = int.Parse(Console.ReadLine());
                    S = new Circle(d);
                    break;
                }
                case 4:
                {
                    Console.WriteLine("Vad är radien?");
                    int r = int.Parse(Console.ReadLine());
                    S = new Circle(r);
                    break;
                }
                case 5:
                {
                    Console.WriteLine("Vad är diametern?");
                    int d = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vad är höjden?");
                    int h = int.Parse(Console.ReadLine());
                    S = new Cylinder(d, h);
                    break;
                    
                }
            }
            S.Area();
            S.Circumference();
        }
    }
}
