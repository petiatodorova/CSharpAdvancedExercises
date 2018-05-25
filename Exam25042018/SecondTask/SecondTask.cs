using System;
using System.Linq;
using System.Text;

namespace SecondTask
{
    class SecondTask
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder totalInput = new StringBuilder();

            while (true)
            {
                if (input == "Visual Studio crash")
                {
                    break;
                }
                totalInput.Append(' ');
                totalInput.Append(input);

                input = Console.ReadLine();
            }

            string theInputString = totalInput.ToString();

            //Console.WriteLine($"{theInputString}");

            string splittingString = "32656 19759 32763 0 ";

            string[] result = theInputString.Split(new[] { splittingString }, StringSplitOptions.RemoveEmptyEntries);

            int ind = 0;

            if (result[0] == " ")
            {
                ind = 1;
            }

            for (int i = ind; i < result.Length; i++)
            {
                int[] currentWord = result[i]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int wordCount = currentWord[0];
                StringBuilder thisWord = new StringBuilder();
                for (int j = 2; j < wordCount + 2; j++)
                {
                    thisWord.Append(AsciiToChar(currentWord[j]));
                }
                Console.WriteLine($"{thisWord}");
            }
        }

        static char AsciiToChar(int theAscii)
        {
            char asciiToChar = (char)theAscii;
            return asciiToChar;
        }
    }
}
