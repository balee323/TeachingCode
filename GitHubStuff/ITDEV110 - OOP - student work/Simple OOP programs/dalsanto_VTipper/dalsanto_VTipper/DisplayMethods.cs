using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Assignment 4

namespace dalsanto_VTipper
{
    class DisplayMethods
    {
        string RName;
        double TBillWTip = 0;
        double TBillWoTip = 0;
        string STBillWoTip;
        double GBillWoTip = 0;
        double GBillWTip = 0;
        double TTip = 0;
        double GTip = 0;
        double RTip = 0;
        string SGuestN;
        double GuestN = 1;
        string STipP;
        double TipP = 20;
        double RTipP = 0;
        string RGuest;

        //found this bit on the Microsoft site for using key presses
        ConsoleKeyInfo InputChoice;
        //this variable is meant to be a loop enforcer and break on esc.  it prevents erronious data from being entered
        int GetMeOut = 0;
        //as per instructions a second(third?) class was created
        DoMath Maths = new DoMath();

        public DisplayMethods() {}

        public void ConsoleSetup()
        //configure console with a method named ConsoleSetup
        {
            //the app should remain open till the user quits the app
            while (GetMeOut != 1)
            {
                Console.Clear();
                //display introduction and directions on what user is to do using a method named Intro
                Intro();
                //display the restaurant name, the current date and time, total bill without tip,
                //tip amount, total bill with tip using a method called TotalBill
                TotalBill();
                //user to input name of the restaurant and total amount on bill without tip in a method named InScreen
                InScreen();

            }
        }

        public void Intro()
        {
            Console.WriteLine("Variable Tipper!");
            Console.WriteLine("Follow the prompt below to calculate your tip!");
        }

        public void InScreen()
        {

            Console.WriteLine("\nPress 1 - 4 to edit any of the information with the preceding number above.");
            Console.WriteLine("Or press escape to exit.");
            if (GetMeOut == 0)
            {
                InputChoice = Console.ReadKey();
            }
            //option to escape
            if (InputChoice.Key == ConsoleKey.Escape)
            {
                GetMeOut = 1;
            }//end choice esc

            //option to change restaurant name
            if (InputChoice.Key == ConsoleKey.D1 || InputChoice.Key == ConsoleKey.NumPad1)
            {
                Console.WriteLine("  Change Restaurant Name: ");
                RName = Console.ReadLine();
            }//end choice 1

            //option to change bill total without tip
            if (InputChoice.Key == ConsoleKey.D2 || InputChoice.Key == ConsoleKey.NumPad2 || GetMeOut == 2)
            {
                GetMeOut = 0;
                Console.WriteLine("  Change Bill Total Without Tip(do not include dollar sign): ");
                STBillWoTip = Console.ReadLine();
                try
                {
                    TBillWoTip = System.Convert.ToDouble(STBillWoTip);
                }//end try
                catch (System.FormatException)
                {
                    GetMeOut = 2;
                }//end catch
                if (GetMeOut != 2)
                {
                    TBillWoTip = System.Convert.ToDouble(STBillWoTip);
                }

            }//end choice 2

            //option to change tip percentage.  defaulted at 20 and can only be 1 - 50.  all data stored in the class
            if (InputChoice.Key == ConsoleKey.D3 || InputChoice.Key == ConsoleKey.NumPad3 || GetMeOut == 3)
            {
                double TempTipP = TipP;
                GetMeOut = 0;
                Console.WriteLine("  Change Tip Percentage(Must be 1 - 50): ");
                STipP = Console.ReadLine();
                try
                {
                    TipP = System.Convert.ToInt32(STipP);
                }//end try
                catch (System.FormatException)
                {
                    GetMeOut = 3;
                }//end catch
                if (GetMeOut != 3)
                {
                    TipP = System.Convert.ToInt32(STipP);
                }
                if (TipP > 50 || TipP < 1)
                {
                    TipP = TempTipP;
                    GetMeOut = 3;
                }
            }//end choice 3

            //option to change number of guests
            if (InputChoice.Key == ConsoleKey.D4 || InputChoice.Key == ConsoleKey.NumPad4 || GetMeOut == 4)
            {
                GetMeOut = 0;
                Console.WriteLine("  Change Number of Guests: ");
                SGuestN = Console.ReadLine();
                try
                {
                    GuestN = System.Convert.ToInt32(SGuestN);
                }//end try
                catch (System.FormatException)
                {
                    GetMeOut = 4;
                }//end catch
                if (GetMeOut != 4)
                {
                    GuestN = System.Convert.ToInt32(SGuestN);
                }
            }//end choice 4

            //calculate tip amount and the totalbill using a method named TipCalc
            TTip = Maths.TipCalc("tip", TBillWoTip, TipP);
            TBillWTip = Maths.TipCalc("tot", TBillWoTip, TipP);

            GBillWoTip = TBillWoTip / GuestN;
            GTip = TTip / GuestN;
            GBillWTip = TBillWTip / GuestN;
        }

        public void TotalBill()
        {
            Console.WriteLine("Current Date and Time: " + DateTime.Now);
            Console.WriteLine("\n1 - Restaurant Name: " + RName);
            Console.WriteLine("2 - Total Bill Without Tip: $" + TBillWoTip);
            Console.WriteLine("3 - Tip Percentage: " + TipP + "%");
            Console.WriteLine("4 - Total Number of Guests: " + GuestN);
            Console.WriteLine("\nTip total: $" + TTip);
            Console.WriteLine("Bill total with tip: $" + TBillWTip);

            //If there are multiple people in the party, provide individual total amounts
            if (GuestN > 1)
            {
                Console.WriteLine("Bill amount without tip for each guest: $" + GBillWoTip);
                Console.WriteLine("Tip amount for each guest: $" + GTip);
                Console.WriteLine("Bill amount with tip for each guest: $" + GBillWTip);
            }

            //In addition to calculating tip based on percentage, also show what the percentage tip would be if
            //the total amount on bill was 'rounded up' to either a ten, twenty, fifty, or one hundred dollar bill
            if (GuestN == 1)
            {
                RGuest = "Your";
            }
            if (GuestN > 1)
            {
                RGuest = "Each guest's";
            }

            if (TBillWoTip <= 11 && TBillWoTip > 0)
            {
                Console.WriteLine("\nRounded to $10,");
                RTipP = (((10 - TBillWoTip) / 10) / GuestN) * 100;
                RTip = 10 / GuestN;
                Console.WriteLine(RGuest +  " tip percentage would be: " + RTipP + "%");
                Console.WriteLine(RGuest + " total due with tip: $" + RTip);
            }
            if (TBillWoTip <= 21 && TBillWoTip > 10)
            {
                Console.WriteLine("\nRounded to $20,");
                RTipP = (((20- TBillWoTip) / 20) / GuestN) * 100;
                RTip = 20 / GuestN;
                Console.WriteLine(RGuest + " tip percentage would be: " + RTipP + "%");
                Console.WriteLine(RGuest + " total due with tip: $" + RTip);
            }
            if (TBillWoTip <= 51 && TBillWoTip > 20)
            {
                Console.WriteLine("\nRounded to $50,");
                RTipP = (((50 - TBillWoTip) / 50) / GuestN) * 100;
                RTip = 50 / GuestN;
                Console.WriteLine(RGuest + " tip percentage would be: " + RTipP + "%");
                Console.WriteLine(RGuest + " total due with tip: $" + RTip);
            }
            if (TBillWoTip <= 101 && TBillWoTip > 50)
            {
                Console.WriteLine("\nRounded to $100,");
                RTipP = (((100 - TBillWoTip) / 100) / GuestN) * 100;
                RTip = 100 / GuestN;
                Console.WriteLine(RGuest + " tip percentage would be: " + RTipP + "%");
                Console.WriteLine(RGuest + " total due with tip: $" + RTip);
            }
        }
    }
}
