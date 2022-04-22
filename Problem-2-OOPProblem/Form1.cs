using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Problem_2_OOPProblem
{
	public partial class Form1 : Form
	{
		List<Dish> dishes = new List<Dish>();
		List<Chef> chefs = new List<Chef>();

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Dish newDish = new Dish(textBox1.Text, textBox2.Text, decimal.Parse(textBox3.Text));
			dishes.Add(newDish);
			comboBox1.Items.Add(newDish.Name);
			comboBox2.Items.Add(newDish.Name);
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if(chefs.Any(x => x.Name == textBox2.Text))
			{
				Chef chef = chefs.First(x => x.Name == textBox2.Text);
				chef.Dishes.Add(dishes.First(x => x.Name == comboBox1.Text));
				chef.IsOnABreak = checkBox1.Checked;
			}
			else
			{
				Chef chef = new Chef(textBox2.Text, new List<Dish>() { dishes.First(x => x.Name == comboBox2.Text) }, checkBox1.Checked);
				chefs.Add(chef);
				comboBox3.Items.Add(chef.Name);
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Dish dish = dishes.First(x => x.Name == comboBox2.Text);
			richTextBox1.Text = dish.ToString();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Chef chef = chefs.First(x => x.Name == comboBox3.Text);
			richTextBox2.Text = chef.ToString();
		}
	}
}
