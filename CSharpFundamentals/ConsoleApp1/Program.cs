using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
		
			Console.WriteLine("This program runs 3 different funtions.  Please pick from the following:");
			Console.WriteLine("1: n-times loop, 2: random loop, 3: user-option loop");
			Console.WriteLine("please type 1, 2, or 3 and press enter.");

			int choice = 0;
			choice = int.Parse(Console.ReadLine());  //if anything else than an integer is entered an exception will occur.

			if (choice == 1)
			{
				function1();
			}
			else if (choice == 2)
			{
				function2("Hello from Function 2");
			}
			else if (choice == 3)
			{
				string message = function3();
				Console.WriteLine(message);
			}
			else
			{
				Console.WriteLine("You have entered an invalid selection");
			}

			Console.WriteLine("press any key to exit program.");
			Console.ReadKey();
		}


		//void function example
		private static void function1()
		{
			Console.WriteLine("Hi from function 1");
		}


		//parameter example
		private static void function2(string message)
		{
			Console.WriteLine(message);
		}


		//return function example
		private static string function3()
		{
			string message = "Hi from function 3";
			return message;
		}
	}
}
