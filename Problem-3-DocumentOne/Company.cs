using System.Collections.Generic;

namespace Problem_3_DocumentOne
{
	class Company
	{
		public Company(string name, Dictionary<int, decimal> typePrices)
		{
			this.Name = name;
			this.TypePrices = typePrices;
		}

		public string Name { get; set; }

		public Dictionary<int, decimal> TypePrices { get; set; }
	}
}
