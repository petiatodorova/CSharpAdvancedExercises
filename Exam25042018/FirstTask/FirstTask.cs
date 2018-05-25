using System;

namespace FirstTask
{
    class FirstTask
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int countGames = 0;
            int headsetTrashesCount = 0;
            int mouseTrashesCount = 0;
            int keybardTrashesCount = 0;
            int displayTrashesCount = 0;

            while (true)
            {
                if (countGames > lostGamesCount)
                {
                    break;
                }

                if (countGames % 2 == 0 && countGames != 0)
                {
                    headsetTrashesCount++;
                }

                if (countGames % 3 == 0 && countGames != 0)
                {
                    mouseTrashesCount++;
                }

                if (countGames % 2 == 0 && countGames % 3 == 0 && countGames != 0)
                {
                    keybardTrashesCount++;
                    if (keybardTrashesCount % 2 == 0)
                    {
                        displayTrashesCount++;
                    }
                }

                countGames++;
            }

            double totalSum = headsetTrashesCount * headsetPrice
                + mouseTrashesCount * mousePrice
                + keybardTrashesCount * keyboardPrice
                + displayTrashesCount * displayPrice;

            Console.WriteLine($"Rage expenses: {totalSum:F2} lv.");

        }
    }
}
