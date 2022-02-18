using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Problem_7_Hospital
{
	public partial class Form1 : Form
	{
		List<Ward> wards = new List<Ward>();

		public Form1()
		{
			InitializeComponent();
			DisplayAllWards();
		}

		#region Подточка А

		public void DisplayAllWards() => wards.ForEach(x => richTextBox1.Text += wards.ToString() + Environment.NewLine);

		#endregion

		#region Подточка Б
		private void comboBox1_DropDown(object sender, EventArgs e) => wards.Select(x => x.City).Distinct().ToList().ForEach(x => comboBox1.Items.Add(x));

		private void comboBox2_DropDown(object sender, EventArgs e) => wards.Where(x => x.City == comboBox1.SelectedItem.ToString()).Select(x => x.Name).ToList().ForEach(x => comboBox2.Items.Add(x));

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			List<Ward> filteredWards = wards.Where(x => x.Name == comboBox2.SelectedItem.ToString()).ToList();

			filteredWards.ForEach(x => richTextBox2.Text += $"{x.Name} - легла: {x.BedsCount}");
		}

		#endregion

		#region Подточка В

		private void comboBox3_DropDown(object sender, EventArgs e)
		{
			List<string> distinctWardNames = wards.Select(x => x.WardName).Distinct().ToList();
			distinctWardNames.ForEach(x => comboBox3.Items.Add(x));
		}

		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			List<Ward> filteredWards = wards.Where(x => x.WardName == comboBox3.SelectedItem.ToString()).ToList();

			filteredWards.ForEach(x => richTextBox3.Text += $"Град: {x.City}; Лекари: {x.DoctorsCount}{Environment.NewLine}");
			richTextBox3.Text += $"Лекари общо: {filteredWards.Sum(x => x.DoctorsCount)}";
		}

		#endregion
	}
}
