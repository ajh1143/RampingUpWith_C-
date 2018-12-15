using System;
namespace Recurse
{	
	
    public class Program
    {
    
    static int UserInput()
        /*
        Purpose: Prompts user for valid integer.
        :return userValue:
        */
    {   
        string userValue;
        int userVal;
        bool valid;

        do
        {
            Console.WriteLine("Please enter a positive valued integer and press the 'Enter' key.");
            userValue = Console.ReadLine();
            valid = Int32.TryParse(userValue, out userVal);
           }while (!valid);
        return userVal;
        }
		
    static void SimpleRecurse(int num)
        /*
        Purpose: Prints input number, iterates recursively while non-negative
        :arg num: integer 
        */
	  {
		    if(num >=0)
		    {
	 	    Console.WriteLine("Recursive Count {0}", num);
		    SimpleRecurse(num-1);
		    }
	   }

	
	public static void Main(string[] args)
	{
    int userNum = UserInput();
		SimpleRecurse(userNum);
   }
	
	}
}   
