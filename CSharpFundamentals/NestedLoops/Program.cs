using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            FindDuplicateNumbers findDuplicateNumbers = new FindDuplicateNumbers(CreateIntegerArray());

            int[] duplicates = findDuplicateNumbers.Start();

            foreach(int number in duplicates)
            {
                if(number != 0)
                {
                    Console.WriteLine("duplicate found: " + number);
                }

            }

            Console.ReadKey();


        }


        private static int[] CreateIntegerArray()
        {
            int[] numArray = new int[10];
            numArray[0] = 12;
            numArray[1] = 22;
            numArray[2] = 9;
            numArray[3] = 2;
            numArray[4] = 45;
            numArray[5] = 12;
            numArray[6] = 22;
            numArray[7] = 6;
            numArray[8] = 13;
            numArray[9] = 9;

            return numArray;
        }


    }
}
