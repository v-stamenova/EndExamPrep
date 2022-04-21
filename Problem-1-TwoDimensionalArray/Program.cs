using System;

namespace Problem_1_TwoDimensionalArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] array = new int[4, 4];

			Random random = new Random();
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					array[i, j] = random.Next(1, 11);
				}
			}

			Console.WriteLine(PrintArray(array));
			Console.WriteLine(PrimaryDiagonal(array));
			Console.WriteLine(SecondaryDiagonal(array));
			Console.WriteLine(ElementsBelowPrimaryDiagonal(array));
			Console.WriteLine(ElementsBelowSecondaryDiagonal(array));
		}

		static string PrintArray(int[,] array)
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

			return output;
		}

		static string PrimaryDiagonal(int[,] array)
		{
			string output = "B) Primary diagonal: ";

			for (int i = 0; i < array.GetLength(0); i++)
			{
				output += $"{array[i, i]} ";
			}

			return output;
		}

		static string SecondaryDiagonal(int[,] array)
		{
			string output = "C) Secondary diagonal: ";

			for (int i = array.GetLength(0) - 1; i >= 0; i--)
			{
				output += $"{array[i, array.GetLength(0) - i - 1]} ";
			}

			return output;
		}

		static string ElementsBelowPrimaryDiagonal(int[,] array)
		{
			string output = "D) Elements below the primary diagonal: ";

			for (int i = 0; i < array.GetLength(0); i++)
			{
				for(int j = 0; j < i; j++)
				{
					output += $"{array[i, j]} ";
				}
			}

			return output;
		}

		static string ElementsBelowSecondaryDiagonal(int[,] array)
		{
			string output = "E) Elements below the secondary array: ";

			for (int i = array.GetLength(0) - 1; i >= 0; i--)
			{
				for (int j = array.GetLength(0) - i; j < array.GetLength(0); j++)
				{
					output += $"{array[i, j]} ";
				}
			}

			return output;
		}
	}
}
