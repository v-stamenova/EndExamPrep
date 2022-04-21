using System;

namespace Problem_2_TwoDimensionalArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] array = new int[6, 6];

			Random random = new Random();
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					array[i, j] = random.Next(1, 6);
				}
			}

			DisplayArray(array);
			Console.WriteLine($"Even rows sum: {SumOfRowsDividedBy(array, 0)}");
			Console.WriteLine($"Odd rows sum: {SumOfRowsDividedBy(array, 1)}");
		}

		static void DisplayArray(int[,] array)
		{
			string output = "";

			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					output += $"{array[i, j]} ";
				}

				output += Environment.NewLine;
			}

			Console.WriteLine(output);
		}

		static int SumOfRowsDividedBy(int[,] array, int left)
		{
			int sum = 0;

			for (int i = 0; i < array.GetLength(0); i++)
			{
				if(i % 2 == left)
				{
					for(int j = 0; j < array.GetLength(1); j++)
					{
						sum += array[i, j];
					}
				}
			}

			return sum;
		}
	}
}
