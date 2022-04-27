using System;
using System.Linq;

namespace Problem_1_StringProblems
{
	class Program
	{
		static void Main(string[] args)
		{
			string number = Console.ReadLine();

			int mostCommon = 0;
			for (int i = 0; i < 10; i++)
			{
				if (number.Contains(i.ToString()))
				{
					Console.WriteLine($"{i} - {number.Count(x => x.ToString() == i.ToString())} пъти;");

					if(number.ToCharArray().Count(x => x.ToString() == i.ToString()) > number.Count(x => x.ToString() == mostCommon.ToString()))
					{
						mostCommon = i;
					}
				}
			}

			Console.WriteLine("--------");
			Console.WriteLine($"Най-често се среща: {mostCommon} -> {number.Count(x => x.ToString() == mostCommon.ToString())} пъти");
		}
	}
}
