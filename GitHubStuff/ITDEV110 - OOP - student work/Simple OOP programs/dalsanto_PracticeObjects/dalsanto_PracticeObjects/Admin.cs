using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Assignment 5

namespace PracticeObjectsApp
{
    class Admin
    {
        //a. Create a class named Admin.
        public Admin() { }

        //b. Create a method within Admin named ConsoleSetup that will configure the console.
        public void ConsoleSetup(string bg, string fg, string title)
        {
            Console.Title = title;
            Console.ResetColor();
            //Enum.Parse will take the passed string value and create a usable value for Background and Foreground color.
            //I was unsure how else to do this, but it does satisfy the instructions.
            Console.BackgroundColor = (ConsoleColor) Enum.Parse(typeof(ConsoleColor), bg, true);
            Console.Clear();
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), fg, true);

        }

        //c. Create a method within Admin named Intro to display introduction and directions on what user is to do.
        public void Intro()
        {
            Console.WriteLine("This App will process two sets of random numbers to demonstrate");
            Console.WriteLine("two different instances of the same object working within the same namespace.");
            Console.WriteLine("NO USER INPUT IS REQUIRED.\n");
        }

        //d. Create a method within Admin named Goodbye that tells the user to press any key to exit.
        public void Goodbye()
        {
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadLine();
        }

    }
}
