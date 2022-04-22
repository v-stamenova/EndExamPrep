namespace Problem_2_OOPProblem
{
	class Dish
	{
		private string name;
		private string foodGroup;
		private decimal price;

		public Dish(string name, string foodGroup, decimal price)
		{
			this.Name = name;
			this.FoodGroup = foodGroup;
			this.Price = price;
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

		public string FoodGroup
		{
			get
			{
				return this.foodGroup;
			}
			set
			{
				this.foodGroup = value;
			}
		}

		public decimal Price
		{
			get
			{
				return this.price;
			}
			set
			{
				this.price = value;
			}
		}

		public override string ToString()
		{
			return $"Dish name: {this.name}, Food group: {this.foodGroup}, Price: {this.price.ToString("F2")}";
		}
	}
}
