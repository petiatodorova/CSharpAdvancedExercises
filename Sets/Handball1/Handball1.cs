using System;
using System.Linq;
using System.Collections.Generic;
class Handball1
{
    static void Main()
    {
        string input = Console.ReadLine();

        Dictionary<string, Dictionary<string, int>> teamOpponentsWinOrNo = new Dictionary<string, Dictionary<string, int>>();

        while (true)
        {
            if (input == "stop")
            {
                break;
            }

            string[] line = input
                .Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int[] team1Team2Points = line[2]
                .Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] team2Team1Points = line[3]
                .Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string team1 = line[0];
            string team2 = line[1];

            int team1Home = team1Team2Points[0];
            int team2Guest = team1Team2Points[1];
            int team2Home = team2Team1Points[0];
            int team1Guest = team2Team1Points[1];

            int team1WinOrNo = 0;
            int team2WinOrNo = 0;

            int team1Points = team1Home + team1Guest;
            int team2Points = team2Home + team2Guest;

            if (team1Points > team2Points || ((team1Points == team2Points) && team1Guest > team2Guest))
            {
                team1WinOrNo = 1;
            }
            else
            {
                team2WinOrNo = 1;
            }

            if (!teamOpponentsWinOrNo.ContainsKey(team1))
            {
                Dictionary<string, int> current = new Dictionary<string, int>
                {
                    { team2, team1WinOrNo }
                };
                teamOpponentsWinOrNo.Add(team1, current);
            }
            else
            {
                teamOpponentsWinOrNo[team1].Add(team2, team1WinOrNo);
            }

            if (!teamOpponentsWinOrNo.ContainsKey(team2))
            {
                Dictionary<string, int> current1 = new Dictionary<string, int>
                {
                    { team1, team2WinOrNo }
                };
                teamOpponentsWinOrNo.Add(team2, current1);
            }
            else
            {
                teamOpponentsWinOrNo[team2].Add(team1, team2WinOrNo);
            }

            input = Console.ReadLine();
        }

        foreach (var kvp in teamOpponentsWinOrNo.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(y => y.Key))
        {
            Console.WriteLine($"{kvp.Key}");
            Console.WriteLine($"- Wins: {kvp.Value.Values.Sum()}");

            List<string> opponents = new List<string>();
            foreach (var item in kvp.Value)
            {
                opponents.Add(item.Key);
            }

            Console.Write($"- Opponents: ");
            Console.WriteLine($"{string.Join(", ", opponents.OrderBy(z => z))}");
        }
    }
}
