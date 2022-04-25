using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4_DocumentFour
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> peopleEggs = new Dictionary<string, int>();

			List<string> input = Console.ReadLine().Split(' ').ToList();
			while(input[0] != "Оut" && input[1] != "of")
			{
				if (peopleEggs.ContainsKey(input[0]))
				{
					peopleEggs[input[0]] += int.Parse(input[2]);
				}
				else
				{
					peopleEggs.Add(input[0], int.Parse(input[2]));
				}

				input = Console.ReadLine().Split(' ').ToList();
			}

			foreach(var pair in peopleEggs.OrderBy(x => x.Key))
			{
				Console.WriteLine($"{pair.Key} has beaten {pair.Value} eggs");
			}
		}
	}
}
