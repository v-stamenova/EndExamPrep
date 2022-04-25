using System;
using System.Collections.Generic;

namespace Problem_1_DocumentFour
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> amount = new List<int>();
			List<decimal> prices = new List<decimal>()
			{
				(decimal)3.2,
				(decimal)4.35,
				(decimal)5.40,
				(decimal)0.15
			};

			for (int i = 0; i < 3; i++)
			{
				amount.Add(int.Parse(Console.ReadLine()));
			}

			amount.Add(12 * amount[1]);

			decimal sum = 0;
			for (int i = 0; i < 4; i++)
			{
				sum += prices[i] * amount[i];
			}

			Console.WriteLine(sum.ToString("F2"));
		}
	}
}
