using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photos.Model
{
    internal class Photo
    {
		private int count;

		public int Count
		{
			get { return count; }
			set {  count = value; }
		}

		private string size;

		public string Size
		{
			get { return size; }
			set { size = value; }
		}

		private string orderMethod;

		public string OrderMethod
		{
			get { return orderMethod; }
			set { orderMethod = value; }
		}

		private double sum;

		public double Sum
		{
			get { return sum; }
			set { sum = value; }
		}

		private double discount;

		public double Discount
		{
			get { return discount; }
			set { discount = value; }
		}

		private double totalSum;

		public double TotalSum
		{
			get { return totalSum; }
			set { totalSum = value; }
		}




		public double CalculateSum()
		{
			switch (size)
			{
				case "9X13": this.Sum = this.Count * 0.16;
					break;
				case "10X15": this.Sum = this.Count * 0.16;
					break;
				case "13X18": this.Sum = this.Count * 0.38;
					break;
				case "20X30": this.Sum = this.Count * 2.90;
					break;
			}

			return this.Sum;
		}

		public double CalculateDiscount()
		{
			switch (size)
			{
				case "9X13":
					if (this.Count >= 50)
					{
						this.Discount = 0.05;
					}
					break;
				case "10X15":
					if (this.Count >= 80)
					{
						this.Discount = 0.03;
					}
					break;
				case "13X18":
					if (this.Count >= 50 && this.Count <= 100)
					{
						this.Discount = 0.03;
					}
					else if (this.Count > 100)
					{
						this.Discount = 0.05;
					}
					break;
				case "20X30":
					if (this.Count >= 10 && this.Count <= 50)
					{
						this.Discount = 0.07;
					}
					else if (this.Count > 50)
					{
						this.Discount = 0.09;
					}
					break;
			}

			    if (orderMethod == "online")
			    {
				   this.Discount = this.Discount + 0.02;
			    }

				this.Discount = this.Sum * this.Discount;

			     return this.Discount;
		}
		
		public double CalculateTotalSum()
		{
			this.TotalSum = this.Sum - this.Discount;
			return this.TotalSum;
		}

		public Photo()
		{

		}

		public Photo(int count, string size, string orderMethod, double sum, double discount, double totalSum)
		{
			this.Count = count;
			this.Size = size;
			this.OrderMethod = orderMethod;
			this.Sum = sum;
			this.Discount = discount;
			this.TotalSum = totalSum;
		}
	}
}
