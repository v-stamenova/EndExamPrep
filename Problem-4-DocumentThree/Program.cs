using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4_DocumentThree
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> players = new Dictionary<string, int>();

			List<string> input = Console.ReadLine().Split(' ').ToList();
			while(input[0] != "End" && input[1] != "of")
			{
				if (players.ContainsKey(input[0]))
				{
					players[input[0]] += int.Parse(input[2]);
				}
				else
				{
					players.Add(input[0], int.Parse(input[2]));
				}

				input = Console.ReadLine().Split(' ').ToList();
			}

			foreach(var pair in players.OrderBy(x => x.Key))
			{
				Console.WriteLine($"{pair.Key} has passed {pair.Value} passes.");
			}
		}
	}
}
