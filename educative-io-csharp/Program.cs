using educative_io_csharp;
class Program
{
	public static void Main(string[] args)
	{
		Product[] products = new Product[4];
		products[0] = new Beverage("Pepsi", 9);
		products[1] = new Chocolate("Kandia", 15);
		products[2] = new Chocolate("Milka", 20);
		products[3] = new Beverage("Dorna", 8);

		foreach(Product product in products)
		{
			product.PrintDetails();
		}
	}
}