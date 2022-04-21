using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5_ArrayAlgorithms
{
	class River : IComparer
	{
		private string name;
		private double length;

		public River(string _name, double _length)
		{
			this.Name = _name;
			this.Length = _length;
		}

		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("The name cannot be empty");
				}
				else
				{
					this.name = value;
				}
			}
		}

		public double Length
		{
			get
			{
				return this.length;
			}
			set
			{
				if(value <= 0)
				{
					throw new ArgumentException("Meters cannot be less than zero"); 
				}
				else
				{
					this.length = value;
				}
			}
		}

		public int Compare(object x, object y)
		{
			River first = (River)x;
			River second = (River)y;

			if(first.Length > second.Length)
			{
				return -1;
			}
			else if(first.Length < second.Length)
			{
				return 1;
			}
			else
			{
				return 0;
			}
		}

		public override string ToString()
		{
			return $"{this.name} - {this.length}";
		}
	}
}
