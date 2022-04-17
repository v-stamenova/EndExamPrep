using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_3_CoordSystem
{
	class Rectangle : RelativeCoordSystem
	{
		private int x1;
		private int y1;

		public Rectangle(int x0, int y0, int x1, int y1) : base(x0, y0)
		{
			this.x1 = x1;
			this.y1 = y1;
		}

		public int X1
		{
			get
			{
				return this.x1;
			}
			set
			{
				this.x1 = value;
			}
		}

		public int Y1
		{
			get
			{
				return this.y1;
			}
			set
			{
				this.y1 = value;
			}
		}
	}
}
