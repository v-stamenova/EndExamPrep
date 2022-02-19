using System;

namespace Problem_8_School
{
	class Teacher : School
	{
		private string teacherName;
		private string speciality;
		private int workExperience;

		public Teacher(string teacherName, string speciality, int workExperience,
			string schoolName, string city) : base(schoolName, city)
		{
			this.TeacherName = teacherName;
			this.Speciality = speciality;
			this.WorkExperience = workExperience;
		}

		public string TeacherName
		{
			get
			{
				return this.teacherName;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("The teacher's name cannot be empty");
				}
				else
				{
					this.teacherName = value;
				}
			}
		}

		public string Speciality
		{
			get
			{
				return this.speciality;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("The speciality cannot be empty");
				}
				else
				{
					this.speciality = value;
				}
			}
		}

		public int WorkExperience
		{
			get
			{
				return this.workExperience;
			}
			set
			{
				if(value < 0)
				{
					throw new ArgumentException("The work experience cannot be less than 0");
				}
				else
				{
					this.workExperience = value;
				}
			}
		}

		public override string ToString()
		{
			return $"{this.teacherName} <-> {this.speciality} <-> {this.Name}{Environment.NewLine}" +
				$"{this.City} <-> {this.WorkExperience}";
		}
	}
}
