using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Problem_3_ADT
{
	class Program
	{
		static void Main(string[] args)
		{
			StreamReader reader = new StreamReader(@"D:\Projects\EndExamPrep\Problem-3-ADT\dumi.txt", Encoding.UTF8);
			List<string> words = new List<string>();

			using (reader)
			{
				while (!reader.EndOfStream)
				{
					words.Add(reader.ReadLine());
				}
			}

			words.ForEach(x => Console.Write(x[0].ToString().ToUpper()));
			Console.WriteLine();
			words.ForEach(x => Console.Write(x.ToLower() + " "));
		}
	}
}
