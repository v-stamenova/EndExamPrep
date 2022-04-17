using Problem_5_Products.Enums;
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

namespace Problem_5_Products
{
	public partial class Form1 : Form
	{
		List<Product> products;

		public Form1()
		{
			InitializeComponent();

			products = LoadProducts();
			DisplayTheProfit();
			WriteInFile();
			DisplayNameAndPriceWithTax();
			DisplayNameAndCustomerPrice();
			DisplayExpenseAndProfit();
		}

		private List<Product> LoadProducts()
		{
			List<Product> returnProducts = new List<Product>();
			StreamReader streamReader = new StreamReader("Products.txt", Encoding.UTF8);

			using (streamReader)
			{
				while (!streamReader.EndOfStream)
				{
					List<string> data = streamReader.ReadLine().Split(' ').ToList();

					FoodGroup group;
					FoodGroup.TryParse(data[1], out group);

					MeasurementUnit unit;
					MeasurementUnit.TryParse(data[2], out unit);

					returnProducts.Add(new Product(data[0], group, unit, decimal.Parse(data[3])));
				}
			}

			return returnProducts;
		}

		private void DisplayTheProfit()
		{
			products.ForEach(x => listBox1.Items.Add($"{x.Name} -> {(x.Price_Customer() - x.Price_DDS()).ToString("C2")}"));
		}

		private void WriteInFile()
		{
			StreamWriter writer = new StreamWriter("result.txt", false, Encoding.UTF8);

			using (writer)
			{
				products.ForEach(x => writer.WriteLine($"{x.Name} -> {(x.Price_Customer() - x.Price_DDS()).ToString("C2")}"));
			}
		}

		private void DisplayNameAndCustomerPrice()
		{
			products.ForEach(x => listBox2.Items.Add($"{x.Name} -> {x.Price_Customer().ToString("C2")}"));
		}

		private void DisplayNameAndPriceWithTax()
		{
			products.ForEach(x => listBox3.Items.Add($"{x.Name} -> {x.Price_DDS().ToString("C2")}"));
		}

		private void DisplayExpenseAndProfit()
		{
			decimal expense = products.Sum(x => x.Price_DDS());

			decimal total = products.Sum(x => x.Price_Customer());

			label1.Text = $"Expenses: {expense.ToString("C2")}{Environment.NewLine}" +
				$" ----- {Environment.NewLine}" +
				$"Profit: {(total - expense).ToString("C2")}";
		}
	}
}
