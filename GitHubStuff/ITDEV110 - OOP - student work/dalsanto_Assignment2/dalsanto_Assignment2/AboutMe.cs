using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Assignment 2

namespace dalsanto_Assignment2
{
    class AboutMe
    {
        //constructor method
        public AboutMe()
        {
            DisplayInfo();
        }

        //DisplayInfo method
        public void DisplayInfo()
        {
            //We were asked for the Date, not Time.
            var todaydate = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine("\nMatthew Dal Santo \tAssignment 2");
            Console.WriteLine("ITDEV-110 \t\tIntroduction to Object Oriented Programing");
            Console.WriteLine("Larry Domine \t\t" + todaydate);
        }
    }
}
