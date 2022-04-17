using System;
using System.Collections.Generic;

namespace Problem_11_CStudent
{
	class CCourse
	{
		private List<CStudent> student_list;
		private string name;

		public CCourse(string name)
		{
			this.Name = name;
			this.Student_List = new List<CStudent>();
		}

		public CCourse(string name, List<CStudent> students) : this(name)
		{
			this.Student_List = students;
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

		public List<CStudent> Student_List
		{
			get
			{
				return this.student_list;
			}
			private set
			{
				this.student_list = value;
			}
		}
		
		public void addScore(string facultyNumber, int grade) => this.student_list.Find(x => x.FacultyNumber == facultyNumber).addScore(grade);

		public void addScores(string facultyNumber, List<int> grades) => this.student_list.Find(x => x.FacultyNumber == facultyNumber).Scores.AddRange(grades);

		public string displayScores()
		{
			string output = "";

			foreach(CStudent student in this.student_list)
			{
				output += $"{student.Name} ({string.Join(' ', student.Scores)}) - {Math.Round(student.getGrade(), 2)}";
			}

			return output;
		}
	}
}
