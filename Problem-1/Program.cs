using System;
using System.Linq;

namespace Problem_1_Array
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] array = new int[n];

			for(int i = 0; i < array.Length; i++)
			{
				int newElement = int.Parse(Console.ReadLine());

				while (array.Contains(newElement))
				{
					Console.Write("Въведете елемент, който не се съдържа: ");
					newElement = int.Parse(Console.ReadLine());
				}

				array[i] = newElement;
			}

			Console.WriteLine($"{string.Join(' ', array)}");
		}
	}
}
