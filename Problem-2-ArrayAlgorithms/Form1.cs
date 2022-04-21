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

namespace Problem_2_ArrayAlgorithms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			int[] array;

			StreamReader reader = new StreamReader(@"D:\Projects\EndExamPrep\Problem-2-ArrayAlgorithms\numbers.txt");

			using (reader)
			{
				array = reader.ReadLine().Split(' ').Select(int.Parse).ToArray();
			}

			for(int i = 0; i < array.Length; i++)
			{
				int minIndex = i;
				for(int j = i + 1; j < array.Length; j++)
				{
					if(SumOfDigits(array[minIndex]) > SumOfDigits(array[j]))
					{
						minIndex = j;
					}
				}

				int temp = array[i];
				array[i] = array[minIndex];
				array[minIndex] = temp;
			}

			for(int i = 0; i < array.Length; i++)
			{
				listBox1.Items.Add(array[i]);
			}
		}

		private int SumOfDigits(int number)
		{
			int sum = 0;

			while(number != 0)
			{
				sum += number % 10;
				number /= 10;
			}

			return sum;
		}
	}
}
