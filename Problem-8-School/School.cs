using System;

namespace Problem_8_School
{
	class School
	{
		private string name;
		private string city;

		public School(string name, string city)
		{
			this.Name = name;
			this.City = city;
		}

		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("The school's name cannot be empty");
				}
				else
				{
					this.name = value;
				}
			}
		}

		public string City
		{
			get
			{
				return this.city;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("The city's name cannot be empty");
				}
				else
				{
					this.city = value;
				}
			}
		}
	}
}
