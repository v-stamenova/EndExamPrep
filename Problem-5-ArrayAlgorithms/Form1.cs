using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem_5_ArrayAlgorithms
{
	public partial class Form1 : Form
	{
		River[] rivers = new River[5];
		int count = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(count < rivers.Length)
			{
				River river = new River(textBox1.Text, double.Parse(textBox2.Text));
				rivers[count] = river;

				count++;
			}

			if(count == rivers.Length)
			{
				button1.Enabled = false;

				for(int i = 0; i < rivers.Length; i++)
				{
					int minIndex = i;
					for(int j = i; j < rivers.Length; j++)
					{
						if(rivers[minIndex].Compare(rivers[minIndex], rivers[j]) < 0)
						{
							minIndex = j;
						}
					}

					River temp = rivers[minIndex];
					rivers[minIndex] = rivers[i];
					rivers[i] = temp;
				}

				for(int i = 0; i < rivers.Length; i++)
				{
					listBox1.Items.Add(rivers[i]);
				}
			}
		}
	}
}
