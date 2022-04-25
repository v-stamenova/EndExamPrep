using System;

namespace Problem_1_DocumentTwo
{
	class Program
	{
		static void Main(string[] args)
		{
			int neons = int.Parse(Console.ReadLine());
			int molensies = int.Parse(Console.ReadLine());
			int helers = int.Parse(Console.ReadLine());

			Console.WriteLine(neons * 4 + helers * 8 + molensies * 8);
		}
	}
}
