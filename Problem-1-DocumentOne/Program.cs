using System;

namespace Problem_1_DocumentOne
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal laminatePrice = decimal.Parse(Console.ReadLine());
			double width = double.Parse(Console.ReadLine());
			double length = double.Parse(Console.ReadLine());
			decimal padPrice = decimal.Parse(Console.ReadLine());

			double area = width * length;
			decimal totalPrice = (decimal)area * (laminatePrice + padPrice);
			totalPrice *= (decimal)1.4;

			Console.WriteLine(totalPrice.ToString("F2"));
		}
	}
}
