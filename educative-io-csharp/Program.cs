using educative_io_csharp;
class Program
{
	public static void Main(string[] args)
	{
		Beverage cola = new Beverage("RC Cola", 0.7, "8/12/2019", 0.35, "Cola");
		cola.BeverageDetails();
		cola.Display();
		
	}
}