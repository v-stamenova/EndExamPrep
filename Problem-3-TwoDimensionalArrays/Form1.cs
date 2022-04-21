using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem_3_TwoDimensionalArrays
{
	public partial class Form1 : Form
	{
		int[,] magicalSquare = new int[3, 3];

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FillMagicalSquare();

			if (IsMagical())
			{
				MessageBox.Show("The square is magical");
			}
			else
			{
				MessageBox.Show("The square is not magical");
			}
		}

		void FillMagicalSquare()
		{
			string name = "textBox";

			for (int i = 0; i < magicalSquare.GetLength(0); i++)
			{
				for (int j = 0; j < magicalSquare.GetLength(1); j++)
				{
					magicalSquare[i, j] = int.Parse(((TextBox)this.Controls.Find($"{name}{i * magicalSquare.GetLength(0) + j + 1}", true)[0]).Text);
				}
			}
		}

		bool IsMagical()
		{
			int[] sums = new int[6];

			for (int i = 0; i < magicalSquare.GetLength(0); i++)
			{
				int sum = 0;
				for (int j = 0; j < magicalSquare.GetLength(1); j++)
				{
					sum += magicalSquare[i, j];
				}

				sums[i] = sum;
			}

			for (int i = 0; i < magicalSquare.GetLength(0); i++)
			{
				int sum = 0;
				for (int j = 0; j < magicalSquare.GetLength(1); j++)
				{
					sum += magicalSquare[j, i];
				}

				sums[i + 3] = sum;
			}

			int pDiagonal = 0;
			for (int i = 0; i < magicalSquare.GetLength(0); i++)
			{
				pDiagonal += magicalSquare[i, i];
			}

			int sDiagonal = 0;
			for (int i = magicalSquare.GetLength(0); i > 0; i--)
			{
				sDiagonal += magicalSquare[i - 1, magicalSquare.GetLength(0) - i];
			}

			if(pDiagonal != sDiagonal)
			{
				return false;
			}
			else
			{
				for(int i = 0; i < sums.Length; i++)
				{
					if(pDiagonal != sums[i])
					{
						return false;
					}
				}
			}

			return true;
		}
	}
}
