using System;

namespace VirtualClasses
{
    class VirtualClass
    {
        static void Main(string[] args)
        {
            double x = 2;
            double y = 4.3;

            Square square = new Square(x, y);
            Circle circle = new Circle(x);

            Console.WriteLine($"{square.Area()}");
            Console.WriteLine($"{circle.Area()}");
        }
    }
}
