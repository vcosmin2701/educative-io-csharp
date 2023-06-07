using educative_io_csharp;
class Program
{
	public static void Main(string[] args)
	{
		VendingMachine vend1 = new VendingMachine(true, 50, 10);
		VendingMachine vend2 = new VendingMachine(true, 5);
		VendingMachine vend3 = new VendingMachine();
		Console.WriteLine("----------------------");
		vend1.PrintFields();
		Console.WriteLine("----------------------");
		vend2.PrintFields();
		Console.WriteLine("----------------------");
		vend3.PrintFields();
	}
}