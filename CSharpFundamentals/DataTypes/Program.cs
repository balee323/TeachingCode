using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            //foreach (string str in args)
            //{
            //    Console.WriteLine(str);
            //}


   

            int defaultValueInt = new int(); //automatically set to 0
            int secondInt = 5;

            //Console.WriteLine(defaultValueInt);
            //Console.WriteLine(secondInt);


            float defaultValueFloat = new float(); //automatically set to
            float secondFloat = 1.0005f;
            float thirdFloat = 1.0005F; //same as lowercase f

            //Console.WriteLine(defaultValueFloat);
            //Console.WriteLine(secondFloat);
            //Console.WriteLine(thirdFloat);


            //128 bit value (28 digits), so only use when you must
            decimal defaultValueDecimal = new decimal();
            decimal secondDecimal = 5.0m;

            //Console.WriteLine(defaultValueDecimal);
            //Console.WriteLine(secondDecimal);




            string defaultValueString = new string(string.Empty);
            var str1 = new string(string.Empty);
            var str2 = "";
            var  str3 = "this is a string";

            //Console.WriteLine(defaultValueString);
            //Console.WriteLine(str1);
            //Console.WriteLine(str2);
            //Console.WriteLine(str3);



            #region bool


            //BOOLS fun!!

            //bool boolVal1 = new bool();                              
            //WriteLineWithColor("1: " + boolVal1.ToString(), ConsoleColor.Red); //false (default)


            //bool boolVal2 = true;
            //WriteLineWithColor("2: " + boolVal2.ToString(), ConsoleColor.Green);  //true

            //var boolVal3 = boolVal2;
            //WriteLineWithColor("3: " + boolVal3.ToString(), ConsoleColor.Green);  //true

            //var boolVal4 = 1 == 1;
            //WriteLineWithColor("4: " + boolVal4.ToString(), ConsoleColor.Green);  //true

            //var boolVal5 = 1 == 5;
            //WriteLineWithColor("5: " + boolVal5.ToString(), ConsoleColor.Red);  //?

            //var boolVal6 = 8 != 9;
            //WriteLineWithColor("6: " + boolVal6.ToString(), ConsoleColor.Green); //?

            //var boolVal7 = 5 < 9;
            //WriteLineWithColor("7: " + boolVal7.ToString(), ConsoleColor.Green); //true

            //var boolVal8 = (8 < 9) && (7 > 6);
            //WriteLineWithColor("8: " + boolVal8.ToString(), ConsoleColor.Green);  //true

            //var boolVal9 = (8 < 9) && (6 > 7);
            //WriteLineWithColor("9: " + boolVal9.ToString(), ConsoleColor.Red);  //?

            //var boolVal10 = (8 < 9) || (7 > 6);
            //WriteLineWithColor("10: " + boolVal10.ToString(), ConsoleColor.Green);  //true

            //var boolVal11 = (8 < 9) || (6 > 7);
            //WriteLineWithColor("11: " + boolVal11.ToString(), ConsoleColor.Green);  //?



            // //seeing if object is null (not instantiated, didn't use new keyword to create an object)
            // bool boolVal12 = new bool();

            // Object obj1;
            // obj1 = GetNullObject();

            // boolVal12 = (obj1 == null);

            // ////another way
            //// boolVal12 = obj1.Equals(null);
            // WriteLineWithColor("12: " + boolVal12.ToString(), ConsoleColor.Green);  //true





            //Seeing if 2 objects are the same

            var obj2 = new object();
            var obj3 = new object();

            var boolVal13 = obj2.Equals(obj3);
            WriteLineWithColor("13: " + boolVal13.ToString(), ConsoleColor.Red);  //false



            var boolVal14 = obj2.Equals(obj2);
            WriteLineWithColor("14: " + boolVal14.ToString(), ConsoleColor.Green);  //true


            obj2 = obj3;
            var boolVal15 = obj2.Equals(obj3);
            WriteLineWithColor("15: " + boolVal15.ToString(), ConsoleColor.Green);  //true


            #endregion


            FinishUp();
        }

        static void WriteLineWithColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
        }



        private static void FinishUp()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            Environment.Exit(0);
        }


        private static Object GetNullObject()
        {
            return null;
        }

    }
}
