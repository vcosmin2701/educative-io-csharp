using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace educative_io_csharp
{
	class MoneyCollector
	{
		private int _moneyCollected;
		private int _productPrice;
		private int _insertedMoney;

		public MoneyCollector()
		{
			this._moneyCollected = 0;
			this._productPrice = 2;
			this._insertedMoney = 0;
		}

		public void AddMoney(int money)
		{
			this._insertedMoney = money;
			if(this._insertedMoney >= 0)
			{
				Console.WriteLine($"You inserted {this._insertedMoney}");
				this.Change();
			}
			else
			{
				Console.WriteLine("Invalid insertion");
			}
			this._insertedMoney = 0;
		}

		private void Change()
		{
			if(this._insertedMoney >= this._productPrice)
			{
				int change = this._insertedMoney - this._productPrice;
				this._moneyCollected += this._productPrice;
				Console.WriteLine($"Your change is: {change}$");
			}
			else
			{
				Console.WriteLine("You didn't insert sufficient money!");
				Console.WriteLine($"Your change is: {this._insertedMoney}");
			}
		}

		public int GetMoneyCollected()
		{
			return this._moneyCollected;
		}
	}
}
