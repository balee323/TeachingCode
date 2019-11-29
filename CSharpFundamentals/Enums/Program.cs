using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {

            //EnumClass enumObj = new EnumClass();


            //Enum Value type (class level)
            var color1 = EnumClass.ClassColor.orange;

            //Enum Value Type (NameSpace level)
            var color2 = NameSpaceColor.yellow;

         
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            Environment.Exit(0);

        }
    }
}
