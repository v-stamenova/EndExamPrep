using System.Collections.Generic;

namespace Problem_3_DocumentTwo
{
	class TeaShop
	{
		public TeaShop(string name, Dictionary<string, decimal> typePrice)
		{
			this.Name = name;
			this.TypePrice = typePrice;
		}

		public string Name { get; set; }

		public Dictionary<string, decimal> TypePrice { get; set; }
	}
}
