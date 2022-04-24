using System;
using System.Linq;

namespace Problem_2_DocumentOne
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal budget = decimal.Parse(Console.ReadLine());
			decimal[] prices = new decimal[4];
			prices[0] = decimal.Parse(Console.ReadLine());

			prices[1] = prices[0] * (decimal)0.2;
			prices[2] = prices[1] * (decimal)0.7;
			prices[3] = prices[1] * (decimal)0.5;

			if (budget - prices.Sum() > 0)
			{
				Console.Write($"Yes! {(budget - prices.Sum()).ToString("F2")} leva left.");
			}
			else
			{
				Console.Write($"No! {(prices.Sum() - budget).ToString("F2")} leva needed.");
			}
		}
	}
}
