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
    class DisplayInfo
    {
        //I don't want anything in the constructor as I'm calling the class later.
        public DisplayInfo() {}

        public void FormatInfo(double Tot, double Tip, double TipAndTot, string RestName)
        {
            string todaytime;

            //Just put this in here so it wasn't such an abrupt transition.
            Console.Clear();
            Console.WriteLine("Calculating...");
            Thread.Sleep(1000);
            Console.Clear();

            todaytime = DateTime.Now.ToString("HH:mm tt");
            Console.WriteLine("\nRestaurant Name: " + RestName);
            Console.WriteLine("Current Time: " + todaytime);
            Console.WriteLine("Bill Total: $" + Tot);
            Console.WriteLine("Tip Amount(at 15%): $" + Tip);
            Console.WriteLine("Total Including Tip: $" + TipAndTot);
        }//end FormatInfo
    }//end DisplayInfo
}//end namespace
