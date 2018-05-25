using System;

namespace PrintRepeatingCharacter
{
    class PrintRepeatingCharacter
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            string stars = new String(symbol, 22);
            Console.WriteLine($"{stars}");
        }
    }
}
