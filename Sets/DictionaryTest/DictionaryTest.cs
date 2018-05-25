using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryTest
{
    class DictionaryTest
    {
        static void Main(string[] args)
        {
            //name  |  fruit  |  quantity
            Dictionary<string, Dictionary<string, int>> test = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (true)
            {
                if (input == "End")
                {
                    break;
                }

                string[] currentLine = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = currentLine[0];
                string fruit = currentLine[1];
                int quantity = int.Parse(currentLine[2]);

                if (!test.ContainsKey(name))
                {
                    Dictionary<string, int> current = new Dictionary<string, int>();
                    current.Add(fruit, quantity);
                    test.Add(name, current);
                }
                else
                {
                    if (!test[name].ContainsKey(fruit))
                    {
                        test[name].Add(fruit, quantity);
                    }
                    else
                    {
                        test[name][fruit] += quantity;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in test.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var item in kvp.Value.OrderBy(y => y.Key))
                {
                    Console.WriteLine($"=> {item.Key} => {item.Value}");
                }
            }
        }
    }
}
