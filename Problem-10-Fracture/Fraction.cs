using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_10_Fraction
{
	public class Fraction
	{
		private int numerator;
		private int denumerator;

		public Fraction(int numerator, int denumerator)
		{
			if(Math.Abs(numerator) != numerator && Math.Abs(denumerator) != denumerator)
			{
				this.Numerator = Math.Abs(numerator);
				this.Denumerator = Math.Abs(denumerator);
			}
			else
			{
				this.Numerator = numerator;
				this.Denumerator = denumerator;
			}
		}

		public int Numerator
		{
			get
			{
				return this.numerator;
			}
			private set
			{
				this.numerator = value;
			}
		}
		public int Denumerator
		{
			get
			{
				return this.denumerator;
			}
			private set
			{
				if(value == 0)
				{
					throw new DivideByZeroException();
				}
				else if(value < 0)
				{
					this.denumerator = Math.Abs(denumerator);
					this.numerator = -this.numerator;
				}
				else
				{
					this.denumerator = value;
				}
			}
		}

		public override string ToString()
		{
			return $"{this.numerator}/{Math.Abs(this.denumerator)}";
		}

		public Fraction Add(Fraction fraction)
		{
			int lcm = this.LeastCommonMultiple(this.denumerator, fraction.denumerator);

			int newFractionNumerator = this.numerator * (lcm / this.denumerator)
				+ fraction.Numerator * (lcm / fraction.Denumerator);

			return new Fraction(newFractionNumerator, lcm);
		}

		public Fraction Subtract(Fraction fraction)
		{
			int lcm = this.LeastCommonMultiple(this.denumerator, fraction.denumerator);

			int newFractionNumerator = this.numerator * (lcm / this.denumerator)
				- fraction.Numerator * (lcm / fraction.Denumerator);

			return new Fraction(newFractionNumerator, lcm);
		}

		public Fraction Multiply(Fraction fraction)
		{
			int newFractionNumerator = this.numerator * fraction.Numerator;
			int newFractionDenumerator = this.denumerator * fraction.Denumerator;

			int gcm = GreatestCommonDivider(newFractionNumerator, newFractionDenumerator);

			return new Fraction(newFractionNumerator / gcm, newFractionDenumerator / gcm);
		}

		public Fraction Divide(Fraction fraction)
		{
			int newFractionNumerator = this.numerator * fraction.Denumerator;
			int newFractionDenumerator = this.denumerator * fraction.Numerator;

			int gcm = GreatestCommonDivider(newFractionNumerator, newFractionDenumerator);

			return new Fraction(newFractionNumerator / gcm, newFractionDenumerator / gcm);
		}

		private int GreatestCommonDivider(int a, int b)
		{
			while(b != 0)
			{
				int temp = b;
				b = a % b;
				a = temp;
			}

			return a;
		}

		private int LeastCommonMultiple(int a, int b)
		{
			return (a / GreatestCommonDivider(a, b)) * b;
		}
	}
}
