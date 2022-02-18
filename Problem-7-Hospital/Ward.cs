using System;

namespace Problem_7_Hospital
{
	class Ward : Hospital
	{
		private string wardName;
		private int bedsCount;
		private int doctorsCount;

		public Ward(string wardName, int bedsCount, int doctorsCount, string hospitalName, string city) : base(hospitalName, city)
		{
			this.WardName = wardName;
			this.BedsCount = bedsCount;
			this.DoctorsCount = doctorsCount;
		}

		public string WardName
		{
			get
			{
				return this.wardName;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("The ward's name cannot be empty");
				}
				else
				{
					this.wardName = value;
				}
			}
		}

		public int BedsCount
		{
			get
			{
				return this.bedsCount;
			}
			set
			{
				if(value < 0)
				{
					throw new ArgumentException("The beds'count cannot be less than zero");
				}
				else
				{
					this.bedsCount = value;
				}
			}
		}

		public int DoctorsCount
		{
			get
			{
				return this.doctorsCount;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("The doctors'count cannot be less than zero");
				}
				else
				{
					this.doctorsCount = value;
				}
			}
		}

		public override string ToString()
		{
			return $"{this.wardName} -> {this.Name} -> {this.City}{Environment.NewLine}" +
				$"Брой легла - {this.bedsCount}; Брой работещи лекари - {this.doctorsCount}";
		}
	}
}
