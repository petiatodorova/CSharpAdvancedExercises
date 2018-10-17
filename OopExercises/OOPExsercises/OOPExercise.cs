using System;
using System.Collections.Generic;

namespace OOPExsercises
{
    class OOPExercise
    {
        static void Main(string[] args)
        {
            CatOK firstCat = new CatOK("Mimi", "blue");
            CatOK secondCat = new CatOK("Kotyo", "white", new List<int>());
            Console.WriteLine($"{secondCat.Name}");
            Console.WriteLine($"{secondCat.Color}");

            secondCat.Days.Add(3);
            secondCat.Days.Add(88);
            Console.WriteLine($"{string.Join(" ", secondCat.Days)}");

            secondCat.Wins++;
            secondCat.Wins++;

            Console.WriteLine($"{secondCat.Wins}");
        }
    }
}
