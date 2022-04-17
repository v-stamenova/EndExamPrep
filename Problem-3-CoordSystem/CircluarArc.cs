using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_3_CoordSystem
{
	class CircluarArc : Circle
	{
		private int startingAngle;
		private int endingAngle;

		public CircluarArc(int x0, int y0, int radius, int startingAngle, int endingAngle) : base(x0, y0, radius)
		{
			this.startingAngle = startingAngle;
			this.endingAngle = endingAngle;
		}

		public int StartingAngle
		{
			get
			{
				return this.startingAngle;
			}
			set
			{
				this.startingAngle = value;
			}
		}

		public int EndingAngle
		{
			get
			{
				return this.endingAngle;
			}
			set
			{
				this.endingAngle = value;
			}
		}
	}
}
