using System.Drawing;

namespace Problem_1_OOPProblem
{
	class Rectangle
	{
		private Point upperLeft;
		private Point lowerRight;

		public Rectangle(int ulX, int ulY, int lrX, int lrY)
		{
			this.upperLeft = new Point(ulX, ulY);
			this.lowerRight = new Point(lrX, lrY);
		}

		public Point UpperLeft
		{
			get
			{
				return this.upperLeft;
			}
		}

		public Point LowerRight
		{
			get
			{
				return this.lowerRight;
			}
		}
	}
}
