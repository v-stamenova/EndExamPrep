using System;
using System.Collections.Generic;

namespace Problem_3_DocumentTwo
{
	class Program
	{
		static List<TeaShop> shops = new List<TeaShop>();

		static void Main(string[] args)
		{
			DataFill();

			int count = int.Parse(Console.ReadLine());
			string type = Console.ReadLine();
			string name = Console.ReadLine();

			TeaShop shop = shops.Find(x => x.Name == name);
			Console.WriteLine((count * shop.TypePrice[type]).ToString("F2"));
		}

		static void DataFill()
		{
			shops.Add(new TeaShop("Teahouse", new Dictionary<string, decimal>() { { "HerbsTea", 3 }, { "BlackTea", 5 }, { "GreenTea", (decimal)4.5 } }));
			shops.Add(new TeaShop("Leaf", new Dictionary<string, decimal>() { { "HerbsTea", 5 }, { "BlackTea", 8 }, { "GreenTea", 7 } }));
			shops.Add(new TeaShop("HotHot", new Dictionary<string, decimal>() { { "HerbsTea", (decimal)4.5 }, { "BlackTea", 7 }, { "GreenTea", (decimal)9.5 } }));
		}
	}
}
