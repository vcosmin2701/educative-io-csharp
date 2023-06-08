using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace educative_io_csharp
{
	class Chocolate : Product
	{
		private double _profit;

		public Chocolate(string name, double price):base(name, price)
		{
			this._profit = base.GetPurchasePrice() * 0.20;
		}

		public override double GetPrice()
		{
			return base.GetPurchasePrice() + (int)Math.Round(this._profit);
		}

		public override void PrintDetails()
		{
			base.PrintDetails();
			Console.WriteLine($"Selling price: {this.GetPrice()}");
		}
	}
}
