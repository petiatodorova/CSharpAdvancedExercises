using System;
using System.Linq;
using System.Collections.Generic;

namespace MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] helper = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int length = 1;
                for (int j = i + 1; j < helper.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        length++;
                    }
                }
                helper[i] = length;
            }

            int maxLength = -1;
            int index = 0;

            for (int m = 0; m < helper.Length; m++)
            {
                if (helper[m] > maxLength)
                {
                    maxLength = helper[m];
                    index = m;
                }
            }
            Console.WriteLine($"{nums[index]}"); 
        }
    }
}
