using System;

namespace Problem_1_Pool
{
	class Program
	{
		static void Main(string[] args)
		{
			Pool pool = new Pool(100, 50);

			Console.WriteLine($"Volume of pool: {Math.Round(pool.Volume(), 2)} cm3");
			Console.WriteLine($"Price for filling: {Math.Round(pool.FillPrice(0.90, 20), 2)} лв.");
		}
	}
}
