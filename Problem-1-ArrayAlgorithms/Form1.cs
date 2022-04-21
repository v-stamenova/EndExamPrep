using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem_1_ArrayAlgorithms
{
	public partial class Form1 : Form
	{
		List<string> words = new List<string>();

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			words.Add(textBox1.Text);
			textBox1.Clear();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			button1.Enabled = false;
			SelectionSort();
			words.ForEach(x => listBox1.Items.Add(x));
		}

		private void SelectionSort()
		{
			for (int i = 0; i < words.Count; i++)
			{
				int minIndex = i;
				for (int j = i + 1; j < words.Count; j++)
				{
					if (string.Compare(words[j], words[minIndex]) > 0)
					{
						minIndex = j;
					}
				}

				string temp = words[i];
				words[i] = words[minIndex];
				words[minIndex] = temp;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string searched = textBox2.Text;

			int leftB = 0;
			int rightB = words.Count - 1;
			bool found = false;

			while(leftB < rightB && !found)
			{
				int middleIndex = (leftB + rightB) / 2;
				
				if(string.Compare(searched, words[middleIndex]) == 0)
				{
					found = true;
				}
				else if(string.Compare(searched, words[middleIndex]) < 0)
				{
					leftB = middleIndex;
				}
				else
				{
					rightB = middleIndex;
				}
			}

			if (found)
			{
				MessageBox.Show("Елементът е намерен");
			}
			else
			{
				MessageBox.Show("Елементът не е намерен");
			}
		}
	}
}
