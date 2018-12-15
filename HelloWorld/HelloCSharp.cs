using System;
namespace HelloCSharp
{
	public class Program
	{
		public static void Main()
		{
			//Write to console
			Console.WriteLine("Hello, World");
			//Read input from console, store as String 'x'
			String x = Console.ReadLine();
			//Convert x to uppercase and print to console
			Console.WriteLine("Hello, {0}", x.ToUpper());
		}
    }
}
