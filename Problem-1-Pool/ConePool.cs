using System;

namespace Problem_1_2_4_Pool
{
	class ConePool : DoubleSidedPool
	{
		public ConePool(double lowerBaseRadius, double higherBaseRadius, double heightInCm) : base(lowerBaseRadius, higherBaseRadius, heightInCm)
		{ 
		}

		public override double Volume()
		{
			return (Math.PI * this.Height * (Math.Pow(this.Radius, 2) + Math.Pow(this.OuterRadiusInCm, 2) + this.OuterRadiusInCm * this.Radius)) / ( 3 * 1000000);
		}
	}
}
