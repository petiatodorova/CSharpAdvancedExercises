using System;

namespace ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float allSeconds = seconds + 60 * minutes + 3600 * hours;

            float speedMetersPerSecond = distance / allSeconds;
            float speedKmPerHour = (distance / 1000) / (allSeconds / 3600);
            float speedMilesPerHour = (distance / 1609) / (allSeconds / 3600);

            Console.WriteLine($"{speedMetersPerSecond:0.#######}");
            Console.WriteLine($"{speedKmPerHour:0.#######}");
            Console.WriteLine($"{speedMilesPerHour:0.#######}");
        }
    }
}
