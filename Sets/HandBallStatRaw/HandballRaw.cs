using System;
using System.Collections.Generic;
using System.Linq;

namespace HandBallStatRaw
{
    class HandballRaw
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> rechnik = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> current = new Dictionary<string, int>();
            current.Add("key5", 2);
            rechnik.Add("textKey71", current);

            Dictionary<string, int> current2 = new Dictionary<string, int>();
            current2.Add("key23", 3);
            rechnik.Add("textKey6", current2);
            rechnik["textKey6"].Add("key21", 5);
            rechnik["textKey6"].Add("key22", 76);

            Dictionary<string, int> current3 = new Dictionary<string, int>();
            current3.Add("key1", 73);
            rechnik.Add("textKey3", current3);

            foreach (var kvp in rechnik.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(y => y.Key))
            {
                string key = kvp.Key;
                int valuesSum = kvp.Value.Values.Sum();
                Console.WriteLine($"{key} --> {valuesSum}");
                List<string> thisValues = new List<string>();
                foreach (var item in kvp.Value)
                {
                    thisValues.Add(item.Key);
                }
                Console.WriteLine($"{string.Join("  |  ", thisValues.OrderBy(z => z))}");
            }
        }
    }
}
