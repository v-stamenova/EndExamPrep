using System;
using System.Linq;

namespace Problem_3_StringProblem
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(", ").ToArray();
			char[] firstNumber = input[0].ToCharArray();
			char[] secondNumber = input[1].ToCharArray();

			int shortest = 0;
			if (firstNumber.Length < secondNumber.Length)
			{
				shortest = firstNumber.Length;
			}
			else
			{
				shortest = secondNumber.Length;
			}

			for (int i = 0; i < shortest; i++)
			{
				if (int.Parse(firstNumber[i].ToString()) % 2 == 0 && int.Parse(secondNumber[i].ToString()) % 2 == 1)
				{
					char temp = firstNumber[i];
					firstNumber[i] = secondNumber[i];
					secondNumber[i] = temp;
				}
			}

			Console.WriteLine($"{Output(firstNumber)}, {Output(secondNumber)}");
		}

		static string Output(char[] array)
		{
			string output = "";

			for (int i = 0; i < array.Length; i++)
			{
				output += array[i];
			}

			return output;
		}
	}
}
