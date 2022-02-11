using System;

namespace Problem_1_2_4_Pool
{
	class DoubleSidedPool : Pool
	{
		private double outerRadiusInCm;

		public DoubleSidedPool(double outerRadiusInCm, double innerRadiusInCm, double heightInCm) : base(innerRadiusInCm, heightInCm)
		{
			this.OuterRadiusInCm = outerRadiusInCm;
		}

		public double OuterRadiusInCm
		{
			get
			{
				return this.outerRadiusInCm;
			}
			set
			{
				if(value <= this.Radius)
				{
					throw new Exception("Outer radius cannot be smaller than inner");
				}
				else
				{
					this.outerRadiusInCm = value;
				}
			}
		}

		public override double Volume()
		{
			return (Math.PI * this.Height * Math.Abs(Math.Pow(this.Radius, 2) - Math.Pow(this.OuterRadiusInCm, 2))) / 1000000;
		}
	}
}
