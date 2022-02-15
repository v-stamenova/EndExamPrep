using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_6_Bachelor
{
	class Bachelor
	{
		private string name;
		private double[] grades;

		public Bachelor(string name)
		{
			this.name = name;
			this.grades = new double[5];
		}

		public Bachelor(string name, double[] grades)
		{
			this.name = name;
			this.grades = grades;
		}

		public void SetGrades(string gradesString)
		{
			double[] grades = gradesString.Split(' ').Select(double.Parse).ToArray();

			if(grades.Length != 5)
			{
				throw new Exception("The grades are not equal to five");
			}

			if(grades.Any(x => x < 2 || x > 6))
			{
				throw new Exception("The grades are not valid");
			}

			this.grades = grades;
		}

		public override string ToString()
		{
			return $"{this.name} - Среден успех: {Math.Round(AverageGrade(), 2)}";
		}

		private double AverageGrade() => this.grades.Average();

		private bool HasAScholarship()
		{
			if(AverageGrade() >= 4.5)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public decimal ValueOfScholarship()
		{
			if (HasAScholarship())
			{
				if(AverageGrade() < 5.5)
				{
					return 60;
				}

				return 100;
			}

			return 0;
		}

	}
}
