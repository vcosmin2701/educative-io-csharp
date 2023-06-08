namespace educative_io_csharp
{
	class Product
	{
		private string _name;
		private double _purchasePrice;


		public Product(string name, double purchasePrice)
		{
			this._name = name;
			this._purchasePrice = purchasePrice;
		}

		public double GetPurchasePrice()
		{
			return this._purchasePrice;
		}

		public virtual double GetPrice()
		{
			return 0;
		}

		public virtual void PrintDetails()
		{
			Console.WriteLine($"Selected Product's name: {this._name}");
		}

	}
}
