using System;

namespace Problem_1_2_4_Pool
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Problem-1
			Pool pool = new Pool(200, 50);

			Console.WriteLine($"{nameof(pool)} - Height: {pool.Height} cm.; Radius: {pool.Radius} cm.");
			Console.WriteLine($"Volume of pool: {Math.Round(pool.Volume(), 2)} cm3");
			Console.WriteLine($"Price for filling: {Math.Round(pool.FillPrice(0.90, 20), 2)} лв.");

			Console.WriteLine();
			#endregion

			#region Problem-2
			DoubleSidedPool newPool = new DoubleSidedPool(100, 70, 50);

			Console.WriteLine($"{nameof(newPool)} - Height: {newPool.Height} cm.; Inner radius: {newPool.Radius} cm.; Outer Radius: {newPool.OuterRadiusInCm} cm.");
			Console.WriteLine($"Volume of pool: {Math.Round(newPool.Volume(), 2)} cm3");
			Console.WriteLine($"Price for filling: {Math.Round(newPool.FillPrice(0.90, 20), 2)} лв.");

			Console.WriteLine();
			#endregion

			#region Problem-4
			ConePool conePool = new ConePool(100, 70, 50);

			Console.WriteLine($"{nameof(conePool)} - Height: {conePool.Height} cm.; Lower base radius: {conePool.Radius} cm.; Higher base radius: {conePool.OuterRadiusInCm} cm.");
			Console.WriteLine($"Volume of pool: {Math.Round(conePool.Volume(), 2)} cm3");
			Console.WriteLine($"Price for filling: {Math.Round(conePool.FillPrice(0.90, 20), 2)} лв.");
			#endregion
		}
	}
}
