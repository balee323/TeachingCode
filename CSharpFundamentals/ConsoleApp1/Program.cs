using System;

namespace ConsoleApp1
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
				function2();
			}
			else if (choice == 3)
			{
				function3();
			}
			else
			{
				Console.WriteLine("You have entered an invalid selection");
			}

			Console.WriteLine("press any key to exit program.");
			Console.ReadKey();
		}


		private static void function3()
		{
			Console.WriteLine("Hi from function 3");
		}


		private static void function2()
		{
			Console.WriteLine("Hi from function 2");
		}


		private static void function1()
		{
			Console.WriteLine("Hi from function 1");
		}
	}
}
