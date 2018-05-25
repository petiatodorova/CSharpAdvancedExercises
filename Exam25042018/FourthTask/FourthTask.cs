using System;
using System.Collections.Generic;
using System.Linq;

namespace FourthTask
{
    class FourthTask
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> playerPositionSkill = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (true)
            {
                if (input == "Season end")
                {
                    break;
                }

                if (input.Contains(" -> "))
                {
                    string[] thisInput = input
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                    string name = thisInput[0];
                    string position = thisInput[1];
                    int skill = int.Parse(thisInput[2]);

                    if (!playerPositionSkill.ContainsKey(name))

                    {
                        Dictionary<string, int> current = new Dictionary<string, int>();
                        current.Add(position, skill);
                        playerPositionSkill.Add(name, current);
                    }
                    else
                    {
                        if (!playerPositionSkill[name].ContainsKey(position))
                        {
                            playerPositionSkill[name].Add(position, skill);
                        }
                        else
                        {
                            if (playerPositionSkill[name][position] < skill)
                            {
                                playerPositionSkill[name][position] = skill;
                            }

                        }
                    }

                }

                if (input.Contains(" vs "))
                {
                    string[] thisInput = input
                   .Split(" vs ", StringSplitOptions.RemoveEmptyEntries);

                    string player1 = thisInput[0];
                    string player2 = thisInput[1];

                    if (playerPositionSkill.ContainsKey(player1) && playerPositionSkill.ContainsKey(player2))
                    {
                        List<string> firstPlayerPositions = new List<string>();
                        List<string> secondPlayerPositions = new List<string>();
                        foreach (var position in playerPositionSkill[player1].Keys)
                        {
                            firstPlayerPositions.Add(position);
                        }
                        foreach (var position in playerPositionSkill[player2].Keys)
                        {
                            secondPlayerPositions.Add(position);
                        }
                        if (firstPlayerPositions.Intersect(secondPlayerPositions).Any())
                        {
                            int firstTotalPoints = playerPositionSkill[player1].Values.Sum();
                            int secondTotalPoints = playerPositionSkill[player2].Values.Sum();

                            if (firstTotalPoints > secondTotalPoints)
                            {
                                playerPositionSkill.Remove(player2);
                            }
                            if (secondTotalPoints > firstTotalPoints)
                            {
                                playerPositionSkill.Remove(player1);
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var currPlayer in playerPositionSkill.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(z => z.Key))
            {
                Console.WriteLine($"{currPlayer.Key}: {currPlayer.Value.Values.Sum()} skill");

                foreach (var keyPair in currPlayer.Value.OrderByDescending(y => y.Value))
                {
                    Console.WriteLine($"- {keyPair.Key} <::> {keyPair.Value}");
                }
            }
        }
    }
}
