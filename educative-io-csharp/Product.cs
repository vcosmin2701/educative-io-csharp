using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace educative_io_csharp
{
	class Product
	{
		private string _name;
		private double _price;
		private string _expiryDate;

		public Product(string name, double price, string expiryDate)
		{
			this._name = name;
			this._price = price;
			this._expiryDate = expiryDate;
		}

		public void PrintDetails()
		{
			Console.WriteLine("Name: " + this._name);
			Console.WriteLine("Price: " + this._price);
			Console.WriteLine("Expiry Date: " + this._expiryDate);
		}

		public void RandomMessage()
		{
			Console.WriteLine("product class");
		}

	}
}
