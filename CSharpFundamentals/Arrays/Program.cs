using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            WorkWithIntArray();
            WorkWithStringArray();

            Console.ReadKey();

        }


        private static void WorkWithIntArray()
        {

            int num1 = 5;
            int num2 = 10;

            int[] nums = CreateIntArray();

            bool isFound = false;
            int numberToFind = 34;
            isFound = FindNumber(nums, numberToFind);
            Console.WriteLine(numberToFind + " found status: " + isFound);
        }


        private static void WorkWithStringArray()
        {
            string[] strings = CreateStringArray();

            bool isFound = false;
            string stringToFind = "wazzup";
            isFound = FindString(strings, stringToFind);
            Console.WriteLine(stringToFind + " found status: " + isFound);
        }



        private static int[] CreateIntArray()
        {
            int[] nums = new int[10];
            nums[0] = 5;
            nums[1] = 1;
            nums[2] = 3;
            nums[3] = 8;
            nums[4] = 22;
            nums[5] = 555;
            nums[6] = 0;
            nums[7] = 34;
            nums[8] = 99;
            nums[9] = 55;

            return nums;
        }


        private static bool FindNumber(int[] numbers, int numberToFind)
        {
            int arraySize = numbers.Length;
            bool isFound = false;

            for (int i = 0; i < arraySize; i++)
            {

                if (numbers[i] == numberToFind)
                {
                    isFound = true;
                    Console.WriteLine("Found it at element location: " + i);
                }
            }
            return isFound;
        }


        private static string[] CreateStringArray()
        {
            string[] strings = new string[5];
            strings[0] = "cool";
            strings[1] = "something";
            strings[2] = "hi";
            strings[3] = "wazzup";
            strings[4] = "awesome";

            // strings[60] = "does this work";  //array out of bounds exception

            return strings;
        }


        private static bool FindString(string[] strings, string stringToFind)
        {
            int arraySize = strings.Length;
            bool isFound = false;

            for (int i = 0; i < arraySize; i++)
            {

                if (strings[i] == stringToFind)
                {
                    isFound = true;
                    Console.WriteLine("Found it at element location: " + i);
                }
            }
            return isFound;
        }



    }
}
