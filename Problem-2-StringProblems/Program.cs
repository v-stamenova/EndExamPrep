using System;
using System.Linq;
using System.Text;

namespace Problem_2_StringProblems
{
	class Program
	{
		static void Main(string[] args)
		{
			string number = Console.ReadLine();

			int biggestDigit = 0;
			foreach(char ch in number)
			{
				if (biggestDigit < int.Parse(ch.ToString()))
				{
					biggestDigit = int.Parse(ch.ToString());
				}
			}

			string output = $"{number} = ";
			for(int i = 0; i < biggestDigit; i++)
			{
				for(int j = 0; j < number.Length; j++)
				{
					if(int.Parse(number[j].ToString()) > i)
					{
						output += "1";
					}
					else if(output[output.Length - 1] != ' ')
					{
						output += "0";
					}
				}

				if(i + 1 != biggestDigit)
				{
					output += " + ";
				}
			}

			Console.WriteLine(output);
		}
	}
}
