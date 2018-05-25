using System;
using System.Collections.Generic;

namespace _03DecimalToBinaryConverter
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            Stack<int> binaryDigits = new Stack<int>();
            if (number == 0)
            {
                Console.WriteLine($"0");
            }

            while (number / 2 > 0)
            {
                int binDigit = number % 2;
                binaryDigits.Push(binDigit);
                number = number / 2;
            }

            if (number % 2 == 1)
            {
                binaryDigits.Push(1);
            }

            Console.WriteLine($"{string.Join("", binaryDigits)}");
        }
    }
}
