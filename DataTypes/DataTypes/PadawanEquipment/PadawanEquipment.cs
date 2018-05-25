using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal allChoesMoney = decimal.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            decimal sabresPrice = decimal.Parse(Console.ReadLine());
            decimal robesPrice = decimal.Parse(Console.ReadLine());
            decimal beltsPrice = decimal.Parse(Console.ReadLine());

            int freeBelts = studentsCount / 6;
            //Console.WriteLine($"freebelts -> {freeBelts}");

            decimal moneyNeeded = sabresPrice * Math.Ceiling((decimal)(studentsCount * 110 / 100))
                + robesPrice * studentsCount + beltsPrice * (studentsCount - freeBelts);

            Console.WriteLine($"all sabres --> {Math.Ceiling((decimal)(studentsCount * 110 / 100))}");

            Console.WriteLine($"moneyneeded -> {moneyNeeded}");
        }
    }
}
