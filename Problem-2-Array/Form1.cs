using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem_2_Array
{
	public partial class Form1 : Form
	{
		int count = 0;
		int[] array = new int[5];
		
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(count < array.Length)
			{
				int newElement = int.Parse(textBox1.Text);

				if (array.Contains(newElement))
				{
					MessageBox.Show("Въведете число, което не се съдържа в масива");
				}
				else
				{
					array[count] = newElement;
					textBox1.Clear();
					count++;
				}
			}

			if(count == array.Length)
			{
				button1.Enabled = false;
				for(int i = 0; i < array.Length; i++)
				{
					listBox1.Items.Add($"{array[i]}");
				}
			}
		}
	}
}
