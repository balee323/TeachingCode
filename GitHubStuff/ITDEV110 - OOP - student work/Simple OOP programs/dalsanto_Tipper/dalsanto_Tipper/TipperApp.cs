using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Assignment 3

namespace TipperApp
{
    class TipperApp
    {
        static void Main(string[] args)
        {
            //Initialized variables and objects.  Most will be defined later.
            TipCalc TipC = new TipCalc();
            DisplayInfo Disp = new DisplayInfo();
            double TipAmount;
            double TotAndTip;
            double Tot;
            string StTot;
            string RestName;

            Console.WriteLine("This app will calculate your tip owed.");
            Console.WriteLine("The tip calculated will be 15% of the total amount owed.");
            Console.WriteLine("Please enter the total amount of you bill(numeric input only):");
            StTot = Console.ReadLine();

            //Encountered some errors when testing, so I found a method to avoid the most common exception.
            //I'm not going to code an exception for a negative value as anyone who would enter a negative value
            //would recieve results making their error obvious.
            try
            {
                Tot = System.Convert.ToDouble(StTot);
            }//end try
            //I was having difficulty with looping logic though, so I just had the program exit on bad input.
            catch (System.FormatException)
            {
                Console.WriteLine("Invalid Entry.  Please try again.");
                Console.ReadKey();
                return;
            }//end catch
            Tot = System.Convert.ToDouble(StTot);
            
            Console.WriteLine("What is the name of the restaurant where you are dining?");
            RestName = Console.ReadLine();

            //Uses the TipCalc class and GetTip method to calculate the tip.
            TipAmount = TipC.GetTip(Tot);
            TotAndTip = TipAmount + Tot;

            //This simply takes the input and displays it nicely.
            Disp.FormatInfo(Tot, TipAmount, TotAndTip, RestName);

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();

        }//end main
    }//end TipperApp
}//end namespace
