using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {
            List<HashSet<int>> test = new List<HashSet<int>>();

            test.Add(new HashSet<int>());
            test.Add(new HashSet<int>());
            test.Add(new HashSet<int>());

            test[0].Add(1);
            test[0].Add(2);
            test[0].Add(111);
            test[0].Add(1);
            test[0].Add(5);
            test[1].Add(505);
            test[1].Add(15);
            test[1].Add(25);
            test[1].Add(15);

            for (int i = 0; i < test.Count; i++)
            {
                Console.WriteLine($"{string.Join("  ", test[i].Where(y => y > 20).OrderBy(x => x))}");
            }

            Console.WriteLine($"{test[0].Contains(1)}");  
            Console.WriteLine($"{test[0].Contains(55)}");  


        }
    }
}
