using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_join
{
    class Program
    {

        int number = 500000000;
        int number2 = 500_000_000;
        
        static void Main(string[] args)
        {
            // Normal text
            Console.WriteLine("I have started to program");

            // Also normal text
            Console.WriteLine(" in C#.");

            // Joining two texts using plus sign
            Console.WriteLine($"I have started to program {Math.PI.ToString()}");

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
