using System;

namespace IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(number, 2);
            string hexa = Convert.ToString(number, 16).ToUpper();

            Console.WriteLine($"{hexa}");
            Console.WriteLine($"{binary}");
        }
    }
}
