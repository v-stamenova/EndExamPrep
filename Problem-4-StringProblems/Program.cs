using System;
using System.Linq;

namespace Problem_4_StringProblems
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(' ').ToArray();
			char[] firstNumber = input[0].ToCharArray();
			char[] secondNumber = input[1].ToCharArray();
			bool isSmaller = false;

			string output = "";
			if (firstNumber.Length < secondNumber.Length)
			{
				firstNumber = BringToEqualLength(firstNumber, secondNumber.Length);
				output = ReverseCalculate(secondNumber, firstNumber);
				output += "-";
			}
			else if (firstNumber.Length != secondNumber.Length)
			{
				secondNumber = BringToEqualLength(secondNumber, firstNumber.Length);
				output = ReverseCalculate(firstNumber, secondNumber);
			}
			else
			{
				for (int i = 0; i < firstNumber.Length; i++)
				{
					if (int.Parse(firstNumber[i].ToString()) < int.Parse(secondNumber[i].ToString()))
					{
						isSmaller = true;
					}
				}

				if (isSmaller)
				{
					output = ReverseCalculate(secondNumber, firstNumber);
					output += "-";
				}
				else
				{
					output = ReverseCalculate(firstNumber, secondNumber);
				}
			}

			output = new string(output.Reverse().ToArray());
			int count = 0;

			if(output[0] == '-')
			{
				count = GetZerosCount(output, 1);
			}
			else
			{
				count = GetZerosCount(output, 0);
			}

			output = output.Remove(1, count);
			Console.WriteLine(output);
		}

		static string ReverseCalculate(char[] bigger, char[] smaller)
		{
			string output = "";

			int additionalSub = 0;
			for (int i = bigger.Length - 1; i >= 0; i--)
			{
				int result = int.Parse(bigger[i].ToString()) - int.Parse(smaller[i].ToString()) - additionalSub;
				if (result < 0)
				{
					additionalSub = 1;
					output += (10 + result).ToString();
				}
				else
				{
					additionalSub = 0;
					output += result.ToString();
				}
			}

			return output;
		}

		static char[] BringToEqualLength(char[] array, int wantedLength)
		{
			char[] newArray = new char[wantedLength];
			for (int i = 0; i < newArray.Length; i++)
			{
				newArray[i] = '0';
			}

			int diff = wantedLength - array.Length;

			for (int i = newArray.Length - 1; i >= diff; i--)
			{
				newArray[i] = array[i - diff];
			}

			return newArray;
		}

		static int GetZerosCount(string input, int start)
		{
			int count = 0;
			for (int i = start; i < input.Length; i++)
			{
				if (input[i] == '0')
				{
					count++;
				}
				else
				{
					break;
				}
			}

			return count;
		}
	}
}
