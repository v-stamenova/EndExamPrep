using System;
using System.Linq;

namespace Problem_3_Array
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] array = Console.ReadLine().Split(' ').ToArray();

			for(int i = 0; i < array.Length; i++)
			{
				Console.WriteLine($"{array[i]} - {array[i].Length}");
			}
		}
	}
}
