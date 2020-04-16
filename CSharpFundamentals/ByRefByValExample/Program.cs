using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByRefByValExample
{
    class MyTestObj
    {
        public String MyString { get; set; }
    }



    class Program
    {
        static void Main(string[] args)
        {
            //By reference and by value

            //syntatic sugar  --> C# does complex things for you behind the scenes that are actually quite complicated
            //C# likes to do things implicitly for you.  Which is nice, but makes us lazy and dummer sometimes :)  :(
            int number = 1;
            PassIntByValFunction(number);  //just remember that integer is not a reference type... so special magic here...
            Console.WriteLine(number);

            string str = "Brian";  //object... which uses a reference type to point to the actual object
            PassStringByRefFuncion(str);  //C# handles strings live Value types (even though they actually are reference types).
            Console.WriteLine(str); //"Brian"

            MyTestObj testObj = new MyTestObj();   //pure object
            testObj.MyString = "brian";
            PassMyTestObjFuncion(testObj);  //there's no return from this function.  It is void!
            Console.WriteLine(testObj.MyString);  //"Stephanie"

            Console.ReadKey();
        }


        public static void PassIntByValFunction(int num)   //pass by reference and pass by value
        {
            num = num + 5;  //6
            //Console.WriteLine(num);
        }


        public static void PassStringByRefFuncion(string str)  //by default, functions use pass by value (which makes a copy..)
        {
            str = "Stephanie";  //changing what the pointer is pointing to.
        }


        public static void PassMyTestObjFuncion(MyTestObj testObj)  //by default, functions use pass by value (which makes a copy..)
        {
            testObj.MyString = "Stephanie";  //changing what the pointer is pointing to.
        }

    }
}
