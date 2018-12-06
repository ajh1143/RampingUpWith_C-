using System;
namespace SharpLoops
{	
	
	public class Program
	{
		static string GetName()
		{
			Console.WriteLine("Please enter your name and press the 'Enter' key.");
			string userName = Console.ReadLine();
			return userName;
		}


		public static void Main(string[] args)
		{
			//Set boolean ValidName to false
			bool validName = false;
			//While no valid name is entered, loop through user prompt
			while(validName == false)	
			{
				//Call GetName() method to prompt user for name
				string name = GetName();

				//If 'name' is empty, inform user and call GetName() to try again
				if (String.IsNullOrEmpty(name))
				{
					Console.WriteLine("Error, Please enter a none-blank name");
					name = GetName();
				}

				//Else if name is not empty, print Greetings + 'name' to console
				else
				{
					Console.WriteLine("Greetings, " + name);
					validName=true;
				}
			}

		}
    }
}
