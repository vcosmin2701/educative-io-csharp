﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace educative_io_csharp
{
	class Beverage : Product
	{
		private double _refCost;
		private double _profit;

		public Beverage(string name, double price):base(name, price)
		{
			this._refCost = GetPurchasePrice() * 0.10;
			this._profit = GetPurchasePrice() * 0.15;
		}

		public override double GetPrice()
		{
			return (GetPurchasePrice() + (int)Math.Round(this._refCost) + (int)Math.Round(this._profit));
		}

		public override void PrintDetails()
		{
			base.PrintDetails();
			Console.WriteLine($"Selling price: {this.GetPrice()}");
		}
	}
}
