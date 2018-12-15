# RampingUpWith_C\#
Improving my C# skills

## Hello, World!    
Print Hello, World
Collect user input, convert to uppercase, and print `Hello, USERINPUT`. 
```C#
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
```

## Loops
### Get Name Loop
Collect user input, a desired name. 
```C#
static string GetName()
{
    Console.WriteLine("Please enter your name and press the 'Enter' key.");
    string userName = Console.ReadLine();
    return userName;
}
	
```
### ForEachLetter Loop
For each letter in the user name, print position and letter.
Set Thread.Sleep to slow generation of output between letters.
Calculate total letters in user's name.
```C#
static void ForEachLetter(string user_name)
{
    int counter = 0;
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
```
### WhileName Loop
Control user input loop, check for valid entry, prompt user to re-enter name if invalid. 
```C#
	    
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
		
```
### Loop Main
```C#
public static void Main(string[] args)
{
    //Set boolean ValidName to false
    bool validity = false;
    //Call GetName() method to prompt user for name
    string username = GetName();
    WhileName(username, validity);
}
```

## Recursion
### User Input
Collect user input, do-while loop to prompt user for a valid integer input if not given. 
```C#
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
```
### Simple Recursion
Given user-defined integer, recursively print current value and deincrement until 0.
```C#

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
```
### Recursion: Main
```C#	
public static void Main(string[] args)
{
    int userNum = UserInput();
    SimpleRecurse(userNum);
}
	   
```
