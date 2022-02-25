using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_11_CStudent
{
	class CStudent
	{
		private string name;
		private List<int> scores;
		private string fn;

		public CStudent(string name, string facultyNumber)
		{
			this.Name = name;
			this.FacultyNumber = facultyNumber;
			this.Scores = new List<int>();
		}

		public string Name
		{
			get
			{
				return this.name;
			}
			private set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentNullException("The name should not be empty");
				}
				else
				{
					this.name = value;
				}
			}
		}

		public List<int> Scores
		{
			get
			{
				return this.scores;
			}
			private set
			{
				this.scores = value;
			}
		}

		public string FacultyNumber
		{
			get
			{
				return this.fn;
			}
			private set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentNullException("The faculty number cannot be empty");
				}
				else
				{
					this.fn = value;
				}
			}
		}

		public double getGrade() => this.scores.Average();

		public void addScore(int x)
		{
			if(x < 2 || x > 6)
			{
				throw new ArgumentException("The grade must be between 2 and 6");
			}

			this.scores.Add(x);
		}
	}
}
