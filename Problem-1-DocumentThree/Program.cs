using System;
using System.Collections.Generic;

namespace Problem_1_DocumentThree
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, decimal> prices = new Dictionary<string, decimal>()
			{
				{"computer", 5899 },
				{"chair", 1699},
				{"desk", 1789 }
			};
			decimal totalPrice = 0;

			int amount = int.Parse(Console.ReadLine());

			while(amount != 0)
			{
				totalPrice += prices[Console.ReadLine()];
				amount--;
			}

			Console.WriteLine(totalPrice.ToString("F2"));
		}
	}
}
