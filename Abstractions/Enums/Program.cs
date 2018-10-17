using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color = Color.Red;
            Console.WriteLine($"{color}");

            // compare
            bool areTheSame = color == Color.Red;
            Console.WriteLine($"{areTheSame}");

            // get current value
            Console.WriteLine($"{color.GetHashCode()}");

            // get enum values
            var values = Enum.GetValues(typeof(Color));

            foreach (var value in values)
            {
                Console.WriteLine($"{value}");
                Console.WriteLine($"{(int)value}");
            }

            // try parse
            Color color1;
            Enum.TryParse("Green", out color1);
            Console.WriteLine($"color1 is --> {color1}");
            
        }
    }
}
