using System;
using System.Linq;
using System.Collections.Generic;

namespace HandballWithClass
{
    class Handball
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            // Dictionary<string, Dictionary<string, int>> teamOpponentsWinOrNo = new Dictionary<string, Dictionary<string, int>>();
            List<Team> teams = new List<Team>();

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

                // creating the objects
                Team firstTeam = new Team(team1, team2, team1WinOrNo);
                Team secondTeam = new Team(team2, team1, team2WinOrNo);

                teams.Add(firstTeam);
                teams.Add(secondTeam);

                input = Console.ReadLine();
            }


            //foreach (var item in teams)
            //{

            //}
        }


        class Team
        {
            public string Name { get; set; }
            public string Opponent { get; set; }
            public int Wins { get; set; }

            public Team(string name, string opponent, int wins)
            {
                Name = name;
                Opponent = opponent;
                Wins = wins;
            }
        }
    }
}
