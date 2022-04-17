using System;

namespace Problem_3_CoordSystem
{
	class Program
	{
		static void Main(string[] args)
		{
			RelativeCoordSystem coordSystem = new RelativeCoordSystem(0, 0);
			Output(coordSystem);

			Circle circle = new Circle(0, 0, 1);
			Output(circle);

			CircluarArc arc = new CircluarArc(0, 0, 3, 150, 180);
			Output(arc);

			Rectangle rectangle = new Rectangle(0, 0, 1, 2);
			Output(rectangle);
		}

		static void Output(RelativeCoordSystem coordSystem)
		{
			Console.WriteLine($"Center's coordinates: X={coordSystem.X0}, Y={coordSystem.Y0}");
		}
	}
}
