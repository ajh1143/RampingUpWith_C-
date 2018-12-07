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
	
	    
	static void ForEachLetter(string user_name)
	{
	    int counter = 0;
	    string hw = "Hello, World!";
	    Console.WriteLine("\nInitiating Foreach Loop:");
            System.Threading.Thread.Sleep(200);
	    
	    foreach (var letter in user_name)
            {
	       	Console.WriteLine("Position {0} : Letter {1}", counter, letter);
		counter++;
		System.Threading.Thread.Sleep(1000);
	    }
	    Console.WriteLine("\nTotal Letters in Your Name =  {0}", user_name.Length);
	 }    
	
	    
	    static void WhileName(string name, bool validName)
	{
           //While no valid name is entered, loop through user prompt
	    while(validName == false)	
	    {
	        //If 'name' is empty, inform user and call GetName() to try again
		if (String.IsNullOrEmpty(name))
		{
		    Console.WriteLine("Error, Please enter a non-blank name");
		    name = GetName();
		}

		//Else if name is not empty, print Greetings + 'name' to console
		else
		{
	    	    Console.WriteLine("Greetings, " + name);
		    ForEachLetter(name);
		    validName=true;
		}
	     }
          }
		
		
	public static void Main(string[] args)
	{
	    //Set boolean ValidName to false
	    bool validity = false;
	    //Call GetName() method to prompt user for name
	    string username = GetName();
	    WhileName(username, validity);
	}

    }
}   
