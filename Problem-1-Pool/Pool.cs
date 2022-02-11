using System;

namespace Problem_1_2_Pool
{
	class Pool
	{
		private double radius;
		private double height;

		public Pool(double radiusInCm, double heightInCm)
		{
			this.radius = radiusInCm;
			this.height = heightInCm;
		}

		public double Radius
		{
			get
			{
				return this.radius;
			}
			set
			{
				if(value > 0.0)
				{
					this.radius = value;
				}
				else
				{
					throw new ArgumentException("The radius cannot be less or equal to zero");
				}
			}
		}

		public double Height
		{
			get
			{
				return this.height;
			}
			set
			{
				if(value > 0.0)
				{
					this.height = value;
				}
				else
				{
					throw new ArgumentException("The radius cannot be less or equal to zero");
				}
			}
		}

		public virtual double Volume()
		{
			return (Math.PI * Math.Pow(this.radius, 2) * this.height) / 1000000;
		}

		public virtual double FillPrice(double pricePerCube, int tax)
		{
			return Volume() * pricePerCube * (1 + tax / 100);
		}
	}
}
