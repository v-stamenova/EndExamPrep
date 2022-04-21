using System;
using System.Linq;

namespace Problem_3_ArrayAlgorithms
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			int number = int.Parse(Console.ReadLine());
			int index = 0;
			bool foundIndex = false;

			for(int i = 0; i < array.Length && !foundIndex; i++)
			{
				if(number < array[i])
				{
					foundIndex = true;
					index = i;
				}
			}
			if (!foundIndex)
			{
				index = array.Length;
			}

			int[] newArray = new int[array.Length + 1];
			for(int i = 0; i < index; i++)
			{
				newArray[i] = array[i];
			}

			newArray[index] = number;

			for(int i = index; i < array.Length; i++)
			{
				newArray[i + 1] = array[i];
			}

			Console.WriteLine($"Array: {string.Join(" ", newArray)}");
		}
	}
}
