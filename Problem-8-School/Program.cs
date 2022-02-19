using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_8_School
{
	class Program
	{
		static List<Class> classes = new List<Class>();

		static void Main(string[] args)
		{
		}

		static void DisplayAllClasses() => classes.ForEach(x => Console.WriteLine(x));

		static void DoesTheSchoolHaveFinancing(string school, int schoolYear)
		{
			Class searchedClass = classes.Find(x => x.Name == school && x.GraduationYear == schoolYear);

			if(searchedClass.AverageFinalGrade > 5.5)
			{
				Console.WriteLine("Да - 10000лв");
			}
			else if(searchedClass.AverageFinalGrade > 5)
			{
				Console.WriteLine("Да - 8000лв");
			}
			else if(searchedClass.AverageFinalGrade > 4.5)
			{
				Console.WriteLine("Да - 5000лв");
			}
			else
			{
				Console.WriteLine("Не");
			}
		}

		static void GetSchoolNamesAndStudentsGraduated(string city, int schoolYear)
		{
			List<Class> filteredClasses = classes.Where(x => x.City == city && x.GraduationYear == schoolYear).ToList();

			filteredClasses.ForEach(x => Console.WriteLine($"{x.Name} - {x.StudentsCount} ученици"));
			Console.WriteLine($"Общо: {filteredClasses.Sum(x => x.StudentsCount)} ученици");
		}
	}
}
