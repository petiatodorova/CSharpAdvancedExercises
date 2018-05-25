using System;

namespace VariableInHexadecimalFormat
{
    class VariableInHexadecimalFormat
    {
        static void Main(string[] args)
        {
            string hexaNumber = Console.ReadLine();
            int theDecimalNumber = Convert.ToInt32(hexaNumber, 16);
            Console.WriteLine($"{theDecimalNumber}");
        }
    }
}
