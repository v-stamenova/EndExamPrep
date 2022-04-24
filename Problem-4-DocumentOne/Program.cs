using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4_DocumentOne
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<double, string> earthquakes = new Dictionary<double, string>();
			double amount = double.Parse(Console.ReadLine());

			for(int i = 0; i < amount; i++)
			{
				double measure = double.Parse(Console.ReadLine());
				earthquakes.Add(measure, DetermineType(measure));
			}

			Console.WriteLine($"Light: {((earthquakes.Where(x => x.Value == "Light").Count() / amount) * 100).ToString("F2")}%");
			Console.WriteLine($"Moderate: {((earthquakes.Where(x => x.Value == "Moderate").Count() / amount) * 100).ToString("F2")}%");
			Console.WriteLine($"Strong: {((earthquakes.Where(x => x.Value == "Strong").Count() / amount) * 100).ToString("F2")}%");
			Console.WriteLine($"Very strong: {((earthquakes.Where(x => x.Value == "Very strong").Count() / amount) * 100).ToString("F2")}%");
		}

		static string DetermineType(double measure)
		{
			if(measure <= 4)
			{
				return "Light";
			}
			else if(measure <= 6)
			{
				return "Moderate";
			}
			else if(measure <= 7)
			{
				return "Strong";
			}
			else
			{
				return "Very strong";
			}
		}
	}
}
