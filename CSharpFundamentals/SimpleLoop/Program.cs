using System;

namespace SimpleLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isContinuedRunDoLoop = true;

            //this loop will run at least once.
            do
            {
                Console.WriteLine(args[0]);
                Console.WriteLine("Hello World!");

                Console.WriteLine("Press \"y\" to repeat, or press any other key to exit for Do While");
                var rawInputKeyObj = Console.ReadKey(); //let's look at this object
                var input = rawInputKeyObj.KeyChar.ToString();
                if (input.ToUpper() != "Y")
                {
                    isContinuedRunDoLoop = false;
                }


                //this is the extracted method
                //isContinuedRunDoLoop = GetUserDecision(RunWhileLoop);


                Console.WriteLine("Press \"y\" to repeat, or press any other key to exit for Do While");
                rawInputKeyObj = Console.ReadKey(); //let's look at this object
                input = rawInputKeyObj.KeyChar.ToString();
                if (input.ToUpper() != "Y")
                {
                    //isContinuedRunWhileLoop = false;
                }


                //this is extracted method
                //isContinuedRunWhileLoop = GetUserDecision(RunWhileLoop);


            } while (isContinuedRunDoLoop);

            


            bool isContinuedRunWhileLoop = true;

            //this loop may not run at all depending on 
            while (isContinuedRunWhileLoop)
            {
                Console.WriteLine(args[0]);
                Console.WriteLine("Hello World, Again!!");

                isContinuedRunWhileLoop = GetUserDecision(isContinuedRunWhileLoop);
            }



            Environment.Exit(0);
        }


        private static bool GetUserDecision(bool RunLoop)
        {
             throw new NotImplementedException("This function hasn't been implemented yet!");
        }


        //the extracted Funtion
        //private static bool GetUserDecision(bool RunLoop)
        //{
        //    Console.WriteLine("Press \"y\" to repeat, or press any other key to exit");
        //    var rawInputKeyObj = Console.ReadKey(); //let's look at this object
        //    var input = rawInputKeyObj.KeyChar.ToString();
        //    if (input.ToUpper() != "Y")
        //    {
        //        RunLoop = false;
        //    }

        //    return RunLoop;
        //}


    }
}
