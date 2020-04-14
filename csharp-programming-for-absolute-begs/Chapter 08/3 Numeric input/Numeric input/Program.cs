using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeric_input
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompting the user
            Console.Write("How old are you? ");

            // Reading line of text
            string input = Console.ReadLine();

            int enteredNumber = 0;

            int tooMuch = 2000;  //if under 1K, all is well


            //3 ways to convert the string to Integer...
            //1
           // enteredNumber = Convert.ToInt32(input);  
            //2
            //enteredNumber = int.Parse(input); //blow up if wrong value... string.
            //3
            //int.TryParse(input, out enteredNumber);  //maybe won't blow up...


            //But wait, you can also, and should, trap exceptions.  What are exceptions?
            //Glad you asked.  --> go to CSharpFundamentals solution, ExceptionsAndStuff project.
            //CONVERTING TO NUMBER(of entered text)
            try
            {
                enteredNumber = Convert.ToInt32(input);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error has occured, please notify support");
                //Log this error somewhere....
                //Log(e.message) //Show example of Log with stack trace and stuff.
                //Log(e) 

                //do something else
            }


            // Output of entered number
            Console.WriteLine("Your age: " + enteredNumber);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
