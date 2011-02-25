using System;

namespace CBusManager
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello");
			
			// TODO: Implement Functionality Here
			
			Route r1 = new Route("0 1 2 3 4 5");
			Route r2 = new Route("5 6 7 8 9");
			Route r3 = new Route("3 8 9");
			Route[] r = new Route[]{r1,r2,r3};
			
			Graph g = new Graph(10, r);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}