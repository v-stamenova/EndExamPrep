using System;
using System.Linq;

namespace Problem_10_Fraction
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] firstFrac = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			char op = char.Parse(Console.ReadLine());
			int[] secondFrac = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			Fraction firstFraction = new Fraction(firstFrac[0], firstFrac[1]);
			Fraction secondFraction = new Fraction(secondFrac[0], secondFrac[1]);

			switch (op)
			{
				case '+':
					Console.WriteLine(firstFraction.Add(secondFraction));
					break;
				case '-':
					Console.WriteLine(firstFraction.Subtract(secondFraction));
					break;
				case '*':
					Console.Write(firstFraction.Multiply(secondFraction));
					break;
				case '/':
					Console.WriteLine(firstFraction.Divide(secondFraction));
					break;
			}
		}
	}
}
