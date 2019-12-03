using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multiplying million by million

            //short (alias) -> int16  -32768 to 32767
            short thirtyTwoThousand = 32_000;

            //int(alias) -> which is int32 actually, can store way more -2,147,483,648 to 2,147,483,647
            //Int32 million = 1_000_000; //Show that these are both the same
            int million = 1_000_000;

            //long(alias) -> int64 -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            long trillion = 1_000_000_000_000_000_000;


            int result = million * million;
            long resultInLong = million * million;

            // Outputs
            Console.WriteLine("Million times million: " + result);
            Console.WriteLine("also in long: " + resultInLong);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
