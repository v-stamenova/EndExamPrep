using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3_DocumentThree
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> namesPoints = new Dictionary<string, int>();

			string input = Console.ReadLine();
			while(input != "END OF GAME")
			{
				namesPoints.Add(input, GetPoints(input));

				input = Console.ReadLine();
			}

			KeyValuePair<string, int> winner = namesPoints.First(x => x.Value == namesPoints.Max(x => x.Value));
			Console.WriteLine($"Winner is name: {winner.Key}");
			Console.WriteLine($"Points: {winner.Value}");
		}

		static int GetPoints(string name)
		{
			int points = 0;

			if (name.EndsWith('a'))
			{
				points += 10;
			}
			else if (name.EndsWith('v'))
			{
				points += 13;
			}

			if(name.Length > 6)
			{
				points += 33;
			}
			else
			{
				points += 22;
			}

			return points;
		}
	}
}
