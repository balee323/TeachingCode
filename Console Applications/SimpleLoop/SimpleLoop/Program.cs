using System;

namespace SimpleLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isContinued = true;

            //this loop will run at least once.
            do
            {
                Console.WriteLine(args[0]);
                Console.WriteLine("Hello World!");

                Console.WriteLine("Press \"y\" to repeat, or press any other key to exit");
                var rawInputKeyObj = Console.ReadKey(); //let's look at this object
                var input = rawInputKeyObj.KeyChar.ToString();
                if (input.ToUpper() != "Y")
                {
                    isContinued = false;
                }


            } while (isContinued);

             //.net Core console applications now do not automatically close in debug mode, but this feature can be turned off.
             // Tools->Options->Debugging->Automatically close the console when debugging stops (check box)

            Environment.Exit(0);
        }
    }
}
