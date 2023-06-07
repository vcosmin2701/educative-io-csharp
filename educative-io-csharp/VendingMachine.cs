namespace educative_io_csharp
{
	internal class VendingMachine
	{
		private bool _onOff;
		private int _count;
		private int _capacity;
		private int _moneyCollected;

		public VendingMachine()
		{
			this._onOff = false;
			this._capacity = 100;
			this._moneyCollected = 0;
		}

		public VendingMachine(bool onOff, int count)
		{
			this._onOff = onOff;
			this._count = count;
		}

		public VendingMachine(bool onOff, int count, int moneyCollected) : this(onOff, count)
		{
			this._moneyCollected = moneyCollected;
		}

		public void PrintFields()
		{
			Console.WriteLine($"Is the machine turned on? {this._onOff}");
			Console.WriteLine($"The count of products is: {this._count}");
			Console.WriteLine($"The capacity of machine is: {this._capacity}");
			Console.WriteLine($"The total money collected till now is: {this._moneyCollected}");
		}
	}
}
