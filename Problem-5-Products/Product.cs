using Problem_5_Products.Enums;
using Problem_5_Products.Interfaces;
using System;

namespace Problem_5_Products
{
	class Product : IProduct
	{
		private string name;
		private FoodGroup group;
		private MeasurementUnit unit;
		private decimal deliveryPrice;

		public Product(string name, FoodGroup group, MeasurementUnit unit, decimal deliveryPrice)
		{
			this.Name = name;
			this.Group = group;
			this.Unit = unit;
			this.DeliveryPrice = deliveryPrice; 
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
					throw new ArgumentException("The name of the product cannot be empty");
				}
				else
				{
					this.name = value;
				}
			}
		}

		public FoodGroup Group
		{
			get
			{
				return this.group;
			}
			set
			{
				this.group = value;
			}
		}

		public MeasurementUnit Unit
		{
			get
			{
				return this.unit;
			}
			set
			{
				this.unit = value;
			}
		}

		private decimal DeliveryPrice
		{
			get
			{
				return this.deliveryPrice;
			}
			set
			{
				if(value < 0)
				{
					throw new ArgumentException("The price cannot be lower than 0");
				}
				else
				{
					this.deliveryPrice = value;
				}
			}
		}

		public decimal Price()
		{
			return this.deliveryPrice;
		}

		public decimal Price_Customer()
		{
			return this.Price_DDS() * (decimal)1.15;
		}

		public decimal Price_DDS()
		{
			return this.Price() * (decimal)1.2;
		}

		public decimal Profit()
		{
			throw new NotImplementedException();
		}
	}
}
