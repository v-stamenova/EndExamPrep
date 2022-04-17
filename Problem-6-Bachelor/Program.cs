using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Problem_6_Bachelor
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Bachelor> bachelors = GetBachelors();

			DisplayAll(bachelors);
			Console.WriteLine();
			DisplayWithScholarships(bachelors);

			FillInFile(bachelors);
		}

		static List<Bachelor> GetBachelors()
		{
			List<Bachelor> bachelors = new List<Bachelor>();
			StreamReader reader = new StreamReader("bachelors.txt");

			using (reader)
			{
				while (!reader.EndOfStream)
				{
					List<string> data = reader.ReadLine().Split(' ').ToList();
					string name = data[0];
					data.RemoveAt(0);
					double[] grades = data.Select(double.Parse).ToArray();

					bachelors.Add(new Bachelor(name, grades));
				}
			}

			return bachelors;
		}

		static void DisplayAll(List<Bachelor> bachelors)
		{
			Console.WriteLine("All bachelors:");
			bachelors.ForEach(x => Console.WriteLine(x));
		}

		static void DisplayWithScholarships(List<Bachelor> bachelors)
		{
			Console.WriteLine("Bachelors with scholarships:");
			List<Bachelor> scholarships = bachelors.Where(x => x.ValueOfScholarship() != 0).ToList();

			scholarships.ForEach(x => Console.WriteLine(x));
		}

		static void FillInFile(List<Bachelor> bachelors)
		{
			StreamWriter writer = new StreamWriter("scholars.txt", false, Encoding.UTF8);

			using (writer)
			{
				List<Bachelor> scholarships = bachelors.Where(x => x.ValueOfScholarship() != 0).ToList();

				scholarships.ForEach(x => writer.WriteLine(x));
			}
		}
	}
}
