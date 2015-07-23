using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, SortedDictionary<string, SortedSet<string>>> clubsInfo =
            new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

        string command = String.Empty;
        while (command != "END")
        {
            string[] input = Console.ReadLine().Split(';');
            if (input[0] == "END")
            {
                command = "END";
            }
            else
            {
                if (!clubsInfo.ContainsKey(input[0]))
                {
                    clubsInfo[input[0]] = new SortedDictionary<string, SortedSet<string>>();
                    clubsInfo[input[0]].Add(input[1], new SortedSet<string>());
                    clubsInfo[input[0]][input[1]].Add(input[2]);
                }
                else
                {
                    if (!clubsInfo[input[0]].ContainsKey(input[1]))
                    {
                        clubsInfo[input[0]].Add(input[1], new SortedSet<string>());
                        clubsInfo[input[0]][input[1]].Add(input[2]);
                    }
                    else
                    {
                        clubsInfo[input[0]][input[1]].Add(input[2]);
                    }
                }
            }

        }

        Print(clubsInfo);
    }

    private static void Print(Dictionary<string, SortedDictionary<string, SortedSet<string>>> info)
    {
        foreach (var city in info)
        {
            Console.WriteLine(city.Key);
            foreach (var venue in city.Value)
            {
                Console.Write("->{0}: ", venue.Key);
                string performers = "";
                foreach (var perf in venue.Value)
                {
                    performers += perf + ", ";
                }

                Console.WriteLine(performers.TrimEnd(new char[] { ' ', ',' }));
            }
        }
    }
}

