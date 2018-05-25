using System;
using System.Linq;
using System.Collections.Generic;

namespace TheWall
{
    class Wall
    {
        static void Main(string[] args)
        {
            int[] sections = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> iceDaily = new List<int>();

            long totalIce = 0;
            long totalSum = 0;
            int count = sections.Length;

            while (true)
            {   
                int currentIceTourMeters = 0;
                for (int i = 0; i < count; i++)
                {
                    if (sections[i] == 30)
                    {
                        continue;
                    }
                    else
                    {
                        sections[i]++;
                        currentIceTourMeters++;
                    }
                }
                int currentElement = currentIceTourMeters * 195;

                if (currentElement == 0)
                {
                    break;
                }
                else
                {
                    iceDaily.Add(currentElement);
                    totalIce += currentElement;
                }
            }

            totalSum = totalIce * 1900;

            Console.WriteLine($"{string.Join(", ", iceDaily)}");
            Console.WriteLine($"{totalSum} coins");
        }
    }
}
