using System;


//Abstract base class
public abstract class Facts
{
	public abstract int Fact(int fak); //Abstraction satisfaction
}


//Absctract child class
class Dos : Facts
{
	private int _faks;   //feild to be gettered and settered
	public int Faks     //property?
	{
		get { return _faks; }
		set { _faks = value; }
	}

	public override int Fact(int fak)  //Abstraction satisfaction
	{
		int i = fak;
		do
		{
			fak--;
			i = i * fak;
		} while (fak > 1);
		return i;
	}
}


//Absctract child class
class Whiles : Facts
{
	private int _faks;   //feild to be gettered and settered
	internal int Faks     //property internal so assembly only
	{
		get => _faks;   //Big Arrow, best friends to Big Data!!! Don't even need return set
		set => _faks = value;   //Big Arrow removes the () and the {} need from an anonymous function
	}

	public override int Fact(int fak)  //Abstraction satisfaction
	{
		int i = 1;
		int j = 1;

		while (j <= fak)
		{
			i *= j;
			j++;
		}
		return i;
	}
}


//Absctract child class
class Recurses : Facts
{
	//no property or private feild with get and set , normal route.

	public override int Fact(int fak)  //Abstraction satisfaction
	{
		if (fak > 1)
		{
			fak *= Fact(fak - 1);
		}
		return fak;
	}
}


public class Maths
{

	public static void Main()   //main function
	{
		//Method fields
		int fak = 0; //User input parsed
		string userInput;    //User input raw
		bool wrong = true;   //loops white wrong

		//instantiated objects
		Dos myDos = new Dos();  //instantiated new child derived classes
		Whiles myWhile = new Whiles();  //instantiated new child derived classes
		Recurses myRecurses = new Recurses();   //instantiated new child derived classes

		while (wrong)
		{
			Console.Write("Enter a positive integer value for your factorial and hit <enter>: ");   //BEGIN!
			userInput = Console.ReadLine();

			//Checking if user entered correct value
			try
			{
				fak = Int32.Parse(userInput);
			}
			catch (FormatException)
			{
				Console.WriteLine($"This is not an integer '{userInput}'\n");
				continue;   //resetting the loop if they did not to force 
			}
			//finally
			//{
			if (fak > 0)
			{
				Console.WriteLine("Awesome, let's do this...\n");
				wrong = false;  //setting bool value to exit loop
			}
			else
			{
				Console.Write("No, that is not P-O-S-I-T-I-V-E. Now try again...\n");   //overtly patronizing
			}
			//}
		}


		//Calling the Do derived class
		myDos.Faks = fak;
		Console.WriteLine($"We will figure out your '{fak}'factorial three very special ways, first the \"Do\" Method (very fancy).");
		Console.WriteLine($"The result of {fak}! is'{myRecurses.Fact(myDos.Faks)}' for the first method.\n");   //calling the value via get and set feild

		//Calling the While derived class
		myWhile.Faks = fak;
		Console.WriteLine($"Now let's plug in '{fak}' with the even better super \"While\" Method (very mega fancy).");
		Console.WriteLine($"The result of {fak}! is'{myRecurses.Fact(myWhile.Faks)}' for the second method.\n");    //calling the value via get and set feild

		//Calling the Recursive derived class
		Console.WriteLine($"Lastly we will solve '{fak}' with our ultra-secret \"Recursion\" Method (big data meta fancy).");
		Console.WriteLine($"The result of {fak}! is'{myRecurses.Fact(fak)}' for the third method.\n");

		//Exposition
		Console.WriteLine($"I hope you are pleased and will patronize us more than our parents!\n\n");


		Console.Read(); //pause for reading text on vs
	}
}
