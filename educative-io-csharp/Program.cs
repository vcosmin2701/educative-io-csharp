using educative_io_csharp;
class Program
{
	public static void Main(string[] args)
	{
		MoneyCollector collector = new MoneyCollector();
		collector.AddMoney(3);
		collector.AddMoney(5);
		collector.AddMoney(7);
		Console.WriteLine($"Total collection till now is: {collector.GetMoneyCollected()}");
	}
}