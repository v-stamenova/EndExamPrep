using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem_1_OOPProblem
{
	public partial class Form1 : Form
	{
		List<Rectangle> rectangles = new List<Rectangle>();

		public Form1()
		{
			InitializeComponent();

			InitializeRectangles();
			Check(rectangles[0], rectangles[1]);
		}

		List<int> GetCoordinates()
		{
			List<int> coords = new List<int>();
			StreamReader reader = new StreamReader(@"D:\Projects\EndExamPrep\Problem-1-OOPProblem\danni.txt");

			using (reader)
			{
				while (!reader.EndOfStream)
				{
					coords.Add(int.Parse(reader.ReadLine()));
				}
			}

			return coords;
		}

		void InitializeRectangles()
		{
			List<int> coords = GetCoordinates();

			for (int i = 0; i < coords.Count - 3; i += 4)
			{
				rectangles.Add(new Rectangle(coords[i], coords[i + 1], coords[i + 2], coords[i + 3]));
			}
		}

		void Check(Rectangle first, Rectangle second)
		{
			int firstArea = GetArea(first);
			int secondArea = GetArea(second);

			if (firstArea > secondArea)
			{
				if(CheckIfInside(first, second))
				{
					label1.Text = "Вторият правоъгълник е в първия правоъгълен";
				}
				else
				{
					label1.Text = "Нито един от правоъгълниците не е в другия";
				}
			}
			else if(firstArea == secondArea)
			{
				if (CheckIfInside(first, second))
				{
					label1.Text = "Двата правоъгълника съвпадат";
				}
				else
				{
					label1.Text = "Нито един от правоъгълниците не е в другия";
				}
			}
			else
			{
				if(CheckIfInside(second, first))
				{
					label1.Text = "Първият правоъгълник е в втория правоъгълен";
				}
				else
				{
					label1.Text = "Нито един от правоъгълниците не е в другия";
				}
			}
		}

		int GetArea(Rectangle rec)
		{
			int sideA = rec.LowerRight.X - rec.UpperLeft.X;
			int sideB = rec.UpperLeft.Y - rec.LowerRight.Y;

			return sideA * sideB;
		}

		bool CheckIfInside(Rectangle outer, Rectangle inner)
		{
			if (outer.UpperLeft.Y < inner.UpperLeft.Y)
				return false;

			if (outer.UpperLeft.X > inner.UpperLeft.X)
				return false;

			if (outer.LowerRight.Y > inner.LowerRight.Y)
				return false;

			if (outer.LowerRight.X < inner.LowerRight.X)
				return false;

			return true;
		}
	}
}
