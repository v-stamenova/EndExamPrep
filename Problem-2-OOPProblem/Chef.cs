using System;
using System.Collections.Generic;

namespace Problem_2_OOPProblem
{
	class Chef
	{
		private string name;
		private List<Dish> dishes;
		private bool isOnABreak;

		public Chef(string name, List<Dish> dishes, bool isOnABreak) : this(name)
		{
			this.Name = name;
			this.Dishes = dishes;
			this.IsOnABreak = isOnABreak;
		}

		public Chef(string name)
		{
			this.Name = name;
			this.Dishes = new List<Dish>();
			this.IsOnABreak = false;
		}

		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		public List<Dish> Dishes
		{
			get
			{
				return this.dishes;
			}
			set
			{
				this.dishes = value;
			}
		}

		public bool IsOnABreak
		{
			get
			{
				return this.isOnABreak;
			}
			set
			{
				this.isOnABreak = value;
			}
		}

		public override string ToString()
		{
			return $"Chef's name: {this.name}{Environment.NewLine}Dishes: {string.Join(", ", this.Dishes)}, Break? {this.isOnABreak}";
		}
	}
}
