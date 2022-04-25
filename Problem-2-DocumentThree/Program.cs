using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2_DocumentThree
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> patients = Console.ReadLine().Split(", ").ToList();

			string input = Console.ReadLine();
			while(input != "END OF PATIENTS")
			{
				switch (input)
				{
					case "Add patient":
						patients.Add(Console.ReadLine());
						break;
					case "Add patient on position":
						string name = Console.ReadLine();
						int position = int.Parse(Console.ReadLine());
						patients.Insert(position, name);
						break;
					case "Remove patient on position":
						int index = int.Parse(Console.ReadLine());
						patients.RemoveAt(index);
						break;
					case "Remove last patient":
						patients.RemoveAt(patients.Count - 1);
						break;
					case "Remove first patient":
						patients.RemoveAt(0);
						break;
				}

				input = Console.ReadLine();
			}

			Console.WriteLine(string.Join(" ", patients));
		}
	}
}
