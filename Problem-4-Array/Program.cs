using System;
using System.IO;
using System.Linq;

namespace Problem_4_Array
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] towns = Console.ReadLine().Split(new string[] { "; " }, StringSplitOptions.None).ToArray();

			string[] townsWithGrad = towns.Where(x => x.Contains("towns")).ToArray();
			string[] townsWithoutGrad = towns.Where(x => !x.Contains("towns")).ToArray();

			Console.WriteLine(string.Join(" ", townsWithoutGrad));
			Console.WriteLine(string.Join(" ", townsWithGrad));
		}
	}
}
