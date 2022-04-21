using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1_ADT
{
	class Program
	{
		static void Main(string[] args)
		{
			Queue<int> queue = new Queue<int>();

			int number = int.Parse(Console.ReadLine());
			while (number != 0)
			{
				while (number < 0)
				{
					Console.WriteLine("Моля въведете положително число");
					number = int.Parse(Console.ReadLine());
				}

				queue.Enqueue(number);
				number = int.Parse(Console.ReadLine());
			}

			Console.WriteLine($"Четни числа: {string.Join(' ', queue.Where(x => x % 2 == 0))}");
			Console.WriteLine($"Нечетни числа: {string.Join(' ', queue.Where(x => x % 2 == 1))}");
		}
	}
}
