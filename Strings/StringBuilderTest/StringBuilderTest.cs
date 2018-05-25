using System;
using System.Text;

namespace StringBuilderTest
{
    class StringBuilderTest
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder reversedString = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedString.Append(input[i]);
            }

            Console.WriteLine($"Reversed Input is {reversedString}");

            int keyNumber = 1;
            StringBuilder changedInput = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                changedInput.Append((char)(input[i] + keyNumber));
            }

            Console.WriteLine($"The changed string from input {input} with number {keyNumber} is {changedInput}");

        }
    }
}
