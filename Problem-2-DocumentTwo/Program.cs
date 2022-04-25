using System;

namespace Problem_2_DocumentTwo
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal budget = decimal.Parse(Console.ReadLine());
			decimal bookPrice = decimal.Parse(Console.ReadLine());

			if (budget - (bookPrice + bookPrice * (decimal)0.2 + bookPrice * (decimal)0.12 + bookPrice * (decimal)0.05) >= 0)
			{
				Console.WriteLine($"Yes! {(budget - (bookPrice + bookPrice * (decimal)0.2 + bookPrice * (decimal)0.12 + bookPrice * (decimal)0.05)).ToString("F2")} leva left.");
			}
			else
			{
				Console.WriteLine($"No! {((bookPrice + bookPrice * (decimal)0.2 + bookPrice * (decimal)0.12 + bookPrice * (decimal)0.05) - budget).ToString("F2")} leva needed.");
			}
		}
	}
}
