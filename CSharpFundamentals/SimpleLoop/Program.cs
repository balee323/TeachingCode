using System;
using System.Collections.Generic;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {


            //********* WHILE LOOP ********************
            //this loop may not run at all depending on 

            bool isContinuedRunWhileLoop = false;

            while (isContinuedRunWhileLoop == true)
            {
                // Console.WriteLine(args[0]);
                Console.WriteLine("Hello World, Again!!");


                Console.WriteLine("Press \"y\" to repeat, or press any other key to exit");
                var rawInputKeyObj = Console.ReadKey(); //let's look at this object
                var input = rawInputKeyObj.KeyChar.ToString();
                if (input.ToUpper() != "Y")
                {
                    isContinuedRunWhileLoop = false;
                }

            }
            ////*****************************************************



            //*********** FOR Loop ******************************

            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine("hello");
            }

            //*****************************************************




            //********  FOR Loop  VS  While Loop ****************
            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine("hello");
            }


            int j = 1;
            while (j < 20)
            {
                Console.WriteLine("hello");
                j += 1;

            }

            Console.ReadKey();
            ////*****************************************************




            //********** DO WHILE Loop *****************
            //this loop will run at least once.
            bool isContinuedRunDoLoop = false;

            do
            {
                //Console.WriteLine(args[0]);
                Console.WriteLine("Hello World!");

                Console.WriteLine("Press \"y\" to repeat, or press any other key to exit for Do While");
                var rawInputKeyObj = Console.ReadKey(); //let's look at this object
                var input = rawInputKeyObj.KeyChar.ToString();
                if (input.ToLower() != "y")
                {
                    isContinuedRunDoLoop = false;
                }

            } while (isContinuedRunDoLoop == true);



            //*****************************************************



            ////**** Do While Loop  VS  While Loop *******************

            var keepRunning = true;

            do
            {
                Console.WriteLine("ran throough do while loop.");
                keepRunning = false;
            } while (keepRunning == true);


            while (keepRunning)
            {
                Console.WriteLine("ran throough regular while loop.");

            }
            ////*****************************************************




            ////**** Foreach Loops *******************
            ////these loops are for iterating a collection

            int[] numArray = new int[5];
            numArray[0] = 25;
            numArray[1] = 8;
            numArray[2] = 60;
            numArray[3] = -85;
            numArray[4] = 78;


            //iterator is handled by the foreach function
            foreach (int item in numArray)
            {
                Console.WriteLine(item.ToString());
            }



            Console.WriteLine("***************");

            //let's compare the difference from a for loop 

            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine(numArray[i].ToString());
            }


            Console.ReadKey();

            ////*****************************************************

            Environment.Exit(0);
        }


      

     
    }
}
