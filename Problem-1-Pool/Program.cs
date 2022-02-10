using System;

namespace Problem_1_Pool
{
	class Program
	{
		static void Main(string[] args)
		{
			//ex 1
			Pool pool = new Pool(200, 50);

			Console.WriteLine($"{nameof(pool)} - Height: {pool.Height} cm.; Radius: {pool.Radius} cm.");
			Console.WriteLine($"Volume of pool: {Math.Round(pool.Volume(), 2)} cm3");
			Console.WriteLine($"Price for filling: {Math.Round(pool.FillPrice(0.90, 20), 2)} лв.");

			Console.WriteLine();

			//ex 2
			DoubleSidedPool newPool = new DoubleSidedPool(200, 100, 50);

			Console.WriteLine($"{nameof(newPool)} - Height: {newPool.Height} cm.; Inner radius: {newPool.Radius} cm.; Outer Radius: {newPool.OuterRadiusInCm} cm.");
			Console.WriteLine($"Volume of pool: {Math.Round(newPool.Volume(), 2)} cm3");
			Console.WriteLine($"Price for filling: {Math.Round(newPool.FillPrice(0.90, 20), 2)} лв.");
		}
	}
}
