using System;
using System.Collections.Generic;
using System.Linq;

namespace ThirdTask
{
    class ThirdTask
    {
        static void Main(string[] args)
        {
            //четем account-a
            List<string> games = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            while (true)
            {
                if (input == "Play!")
                {
                    break;
                }

                string[] currentLine = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = currentLine[0];
                string game = currentLine[1];

                switch (command)
                {

                    case "Install":
                        if (!games.Contains(game))
                        {
                            games.Add(game);
                        }
                        break;

                    case "Uninstall":
                        if (games.Contains(game))
                        {
                            games.Remove(game);
                        }
                        break;

                    case "Update":
                        if (games.Contains(game))
                        {
                            games.Remove(game);
                            games.Add(game);
                        }

                        break;

                    case "Expansion":
                        string[] gameExpansion = game
                                .Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                        string theGameName = gameExpansion[0];
                        string theExtension = gameExpansion[1];
                        if (games.Contains(theGameName))
                        {
                            int indexOfTheGame = games.IndexOf(theGameName);
                            games.Insert(indexOfTheGame + 1, theGameName + ":" + theExtension);

                        }

                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{string.Join(' ', games)}");
        }
    }
}
