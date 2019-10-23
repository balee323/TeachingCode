using System;

namespace SimpleLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(args[0]);
            Console.WriteLine("Hello World!");

            Console.WriteLine("press anykey to exit");
            Console.ReadKey();
            Environment.Exit(0);
            //.net Core console applications now do not automatically close in debug mode, but this feature can be turned off.
            // Tools->Options->Debugging->Automatically close the console when debugging stops (check box)
        }
    }
}
