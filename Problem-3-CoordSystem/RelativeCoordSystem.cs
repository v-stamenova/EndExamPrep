using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_3_CoordSystem
{
	class RelativeCoordSystem
	{
		private int x0;
		private int y0;

		public RelativeCoordSystem(int x0, int y0)
		{
			this.x0 = x0;
			this.y0 = y0;
		}

		public int X0
		{
			get
			{
				return this.x0;
			}
			set
			{
				this.x0 = value;
			}
		}

		public int Y0
		{
			get
			{
				return this.y0;
			}
			set
			{
				this.y0 = value;
			}
		}
	}
}
