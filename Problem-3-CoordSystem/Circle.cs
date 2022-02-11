using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_3_CoordSystem
{
	class Circle : RelativeCoordSystem
	{
		private int radius;

		public Circle(int x0, int y0, int radius) : base(x0, y0)
		{
			this.radius = radius;
		}

		public int Radius
		{
			get
			{
				return this.radius;
			}
			set
			{
				this.radius = value;
			}
		}
	}
}
