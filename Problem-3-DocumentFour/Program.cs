using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3_DocumentFour
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> wordsPoints = new Dictionary<string, int>();

			string input = Console.ReadLine();
			while(input != "END")
			{
				wordsPoints.Add(input, GetPoints(input));

				input = Console.ReadLine();
			}

			Console.WriteLine($"The winner word is {wordsPoints.First(x => x.Value == wordsPoints.Min(x => x.Value)).Key}");
		}

		static int GetPoints(string word)
		{
			int points = 0;
			List<char> chars = new List<char>() { 'a', 'e', 'i', 'o', 'u' };

			if(word.Length >= 10)
			{
				points -= 10;
			}
			else
			{
				points += 13;
			}

			if(word.ToCharArray().Where(x => chars.Contains(x)).Count() >= 3)
			{
				points -= 5;
			}

			if(word.ToUpper()[0] == word[0])
			{
				points -= 7;
			}

			return points;
		}
	}
}
