using System;
using System.Collections.Generic;

namespace Problem_2_ADT
{
	class Program
	{
		static void Main(string[] args)
		{
			Queue<string> queue = new Queue<string>();
			Stack<string> stack = new Stack<string>();

			string word = Console.ReadLine();
			while(word != "End")
			{
				queue.Enqueue(word);
				stack.Push(word);

				word = Console.ReadLine();
			}

			Console.WriteLine($"a) {string.Join("; ", queue)}");
			Console.WriteLine($"b) {string.Join('-', stack)}");
		}
	}
}
