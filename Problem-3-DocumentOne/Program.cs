using System;
using System.Collections.Generic;

namespace Problem_3_DocumentOne
{
	class Program
	{
		static List<Company> companies = new List<Company>();

		static void Main(string[] args)
		{
			DataFill();

			double width = double.Parse(Console.ReadLine());
			double length = double.Parse(Console.ReadLine());
			int cameraCount = int.Parse(Console.ReadLine());
			string companyName = Console.ReadLine();

			Company company = companies.Find(x => x.Name == companyName);
			decimal totalPrice = (decimal)(width * length) * company.TypePrices[cameraCount];

			Console.WriteLine($"Goshko has to spend {totalPrice.ToString("F2")} leva.");
		}

		static void DataFill()
		{
			companies.Add(new Company("Dogramichka4You", new Dictionary<int, decimal>() { {3, 12 }, {4, 15 }, {5, 20 } }));
			companies.Add(new Company("TihoToplo", new Dictionary<int, decimal>() { {3, 15 }, {4, 14 }, {5, 18 } }));
			companies.Add(new Company("ChukChuk", new Dictionary<int, decimal>() { {3, 14 }, {4, 20 }, {5, 22 } }));
		}
	}
}
