using System;

namespace JessysCombinations
{
    class JessysMagic
    {
        static void Main(string[] args)
        {
            int startInterval = int.Parse(Console.ReadLine());
            int endInterval = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int count = 0;

            for (int firstNum = startInterval; firstNum <= endInterval; firstNum++)
            {
                
                for (int secondNum = startInterval; secondNum <= endInterval; secondNum++)
                {
                    count++;
                    if (firstNum + secondNum == magicNumber )
                    {
                        Console.WriteLine($"Combination N:{count} ({firstNum} + {secondNum} = {magicNumber})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
        }
    }
}
