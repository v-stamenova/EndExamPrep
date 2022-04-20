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

namespace Problem_1_Dictionary
{
	public partial class Form1 : Form
	{
		Dictionary<string, DateTime> people = new Dictionary<string, DateTime>();

		public Form1()
		{
			InitializeComponent();
			people = GetPeople();

			foreach(KeyValuePair<string, DateTime> person in people)
			{
				comboBox1.Items.Add(person.Key);
			}
		}

		private Dictionary<string, DateTime> GetPeople()
		{
			Dictionary<string, DateTime> helper = new Dictionary<string, DateTime>();

			StreamReader reader = new StreamReader(@"D:\Projects\EndExamPrep\Problem-1-Dictionary\TextFile.txt", Encoding.UTF8);

			using (reader)
			{
				while (!reader.EndOfStream)
				{
					List<string> data = reader.ReadLine().Split('-').ToList();
					helper.Add(data[0], DateTime.ParseExact(data[1].ToString(), "dd.MM.yyyy", null));
				}
			}

			return helper;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
			List<string> helper = TransformToString(people);
			helper.ForEach(x => richTextBox1.Text += x + Environment.NewLine);
		}

		private List<string> TransformToString(Dictionary<string, DateTime> pairs)
		{
			List<string> list = new List<string>();
			
			foreach(KeyValuePair<string, DateTime> pair in pairs)
			{
				list.Add($"{pair.Key} - {pair.Value.ToShortDateString()}");
			}

			return list;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string name = textBox1.Text;
			DateTime date = dateTimePicker1.Value;

			if (people.ContainsKey(name))
			{
				MessageBox.Show("Вече съществува човек с такова име");
			}
			else
			{
				people.Add(name, date);
				MessageBox.Show("Човекът е добавен успешно");
			}

			textBox1.Clear();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string name = comboBox1.Text;

			KeyValuePair<string, DateTime> searchedPair = people.First(x => x.Key == name);
			richTextBox2.Text = $"{searchedPair.Key} - {searchedPair.Value.ToShortDateString()}";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			DateTime birthdate = dateTimePicker2.Value;

			Dictionary<string, DateTime> helper = new Dictionary<string, DateTime>();

			foreach(KeyValuePair<string, DateTime> pair in people)
			{
				if(DateTime.Equals(pair.Value, birthdate))
				{
					helper.Add(pair.Key, pair.Value);
				}
			}

			richTextBox3.Text = string.Join(Environment.NewLine, TransformToString(helper));
		}

		protected override void OnClosed(EventArgs e)
		{
			StreamWriter writer = new StreamWriter(@"D:\Projects\EndExamPrep\Problem-1-Dictionary\TextFile.txt", false, Encoding.UTF8);

			using (writer)
			{
				foreach(KeyValuePair<string, DateTime> pair in people)
				{
					writer.WriteLine($"{pair.Key}-{pair.Value.ToShortDateString().Replace('-', '.')}");
				}
			}
		}
	}
}
 