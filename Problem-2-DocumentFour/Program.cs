using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2_DocumentFour
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> guests = Console.ReadLine().Split(' ').ToList();

			string input = Console.ReadLine();
			while(input != "PARTY TIME!")
			{
				if(input == "Add guest")
				{
					guests.Add(Console.ReadLine());
				}
				else if(input == "Remove guest")
				{
					guests.Remove(Console.ReadLine());
				}
				else
				{
					guests.Clear();
				}

				input = Console.ReadLine();
			}

			Console.WriteLine(string.Join(", ", guests));
		}
	}
}
