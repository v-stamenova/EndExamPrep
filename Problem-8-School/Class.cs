using System;

namespace Problem_8_School
{
	class Class : School
	{
		private int graduationYear;
		private int studentsCount;
		private double averageFinalGrade;

		public Class(int graduationYear, int studentsCount, double averageFinalGrade,
			string name, string city) : base(name, city)
		{
			this.GraduationYear = graduationYear;
			this.StudentsCount = studentsCount;
			this.AverageFinalGrade = averageFinalGrade;
		}

		public int GraduationYear
		{
			get
			{
				return this.graduationYear;
			}
			set
			{
				if (graduationYear > DateTime.Now.Year || graduationYear < 1900)
				{
					throw new ArgumentException("The graduation year must be in the interval 1900 and " + DateTime.Now.Year);
				}
				else
				{
					this.graduationYear = value;
				}
			}
		}

		public int StudentsCount
		{
			get
			{
				return this.studentsCount;
			}
			set
			{
				if(value < 0)
				{
					throw new ArgumentException("The student's count cannot be less than zero");
				}
				else
				{
					this.studentsCount = value;
				}
			}
		}

		public double AverageFinalGrade
		{
			get
			{
				return this.averageFinalGrade;
			}
			set
			{
				if(value < 2 || value > 6)
				{
					throw new ArgumentException("The average final grade must be in the interval [2, 6]");
				}
				else
				{
					this.averageFinalGrade = value;
				}
			}
		}

		public override string ToString()
		{
			return $"Випуск {this.GraduationYear} от {this.Name}; {this.City}{Environment.NewLine}" +
				$"завърши със среден успех от матурата по БЕЛ - {this.AverageFinalGrade}";
		}
	}
}
