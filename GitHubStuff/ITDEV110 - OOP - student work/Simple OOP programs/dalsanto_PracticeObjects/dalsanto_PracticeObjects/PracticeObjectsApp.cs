using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Assignment 5

namespace PracticeObjectsApp
{
    class PracticeObjectsApp
    {
        static void Main(string[] args)
        {
            //i. In Main instantiate a new object named GetReady of the class Admin.  Use the object to configure the setup the console and display an introduction.
            Admin GetReady = new Admin();
            //j. In Main instantiate two new objects named Calc1 and Calc2 of the class MathFun.
            MathFun Calc1 = new MathFun();
            MathFun Calc2 = new MathFun();
            //Creates the rnd object for creating random numbers.
            Random rnd = new Random();

            //Avoided random input for Background and Foreground as it may lead to unreadable text.
            GetReady.ConsoleSetup("White", "DarkRed", "Practice Objects App");
            GetReady.Intro();

            //k. Set the Number1 and Number2 properties for both Calc1 and Calc2 with different numbers from Main.
            //The while loops below ensure each variable will have a different number.  The sleep commands are to
            //allow the system clock time to change the random seed to ensure there will be no duplicate numbers 
            //before entering the loops due to processing too quickly.
            Calc1.Number1 = rnd.Next(1, 100);
            Thread.Sleep(10);
            while (Calc1.Number2 == Calc1.Number1 || Calc1.Number2 == 0)
            {
                Calc1.Number2 = rnd.Next(1, 100);
            }
            Thread.Sleep(10);
            while (Calc2.Number1 == Calc1.Number1 || Calc2.Number1 == Calc1.Number2 || Calc2.Number1 == 0)
            {
                Calc2.Number1 = rnd.Next(1, 100);
            }
            Thread.Sleep(10);
            while (Calc2.Number2 == Calc1.Number1 || Calc2.Number2 == Calc1.Number2 || Calc2.Number2 == Calc2.Number1 || Calc2.Number2 == 0)
            {
                Calc2.Number2 = rnd.Next(1, 100);
            }

            //l. In Main, get the Number1 and Number2 properties from oth Calc1 and Calc2 of the class MathFun and display them.
            Console.WriteLine("Calc1, Number1: " + Calc1.Number1);
            Console.WriteLine("Calc1, Number2: " + Calc1.Number2);
            Console.WriteLine("Calc2, Number1: " + Calc2.Number1);
            Console.WriteLine("Calc2, Number2: " + Calc2.Number2);

            //m.  In Main, call the MultiplyThem and AddThem methods in both Calc1 and Calc2 and display the return value for each.
            Console.WriteLine("\nCalc1 MathFun.MultiplyThem = " + Calc1.MultiplyThem());
            Console.WriteLine("Calc1 MathFun.AddThem = " + Calc1.AddThem());

            Console.WriteLine("\nCalc2 MathFun.MultiplyThem = " + Calc2.MultiplyThem());
            Console.WriteLine("Calc2 MathFun.AddThem = " + Calc2.AddThem());
            
            //n. In Main, get the Total property value from both Calc1 and Calc2 of the class MathFun and display them.
            //The Total properties will always show the AddThem values as they were the last method called.
            //n. asked specifically to just show the Total property value as is.  It did not specify to show the value
            //after each method call.
            Console.WriteLine("\nCalc1 Total = " + Calc1.Total);
            Console.WriteLine("Calc2 Total = " + Calc2.Total);
            
            //o. Call the Goodbye method in Admin from Main.
            GetReady.Goodbye();

        }
    }
}
