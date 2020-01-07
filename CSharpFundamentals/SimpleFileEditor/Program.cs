using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFileEditor
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Simple File IO progam....");

            var fileManager = new FileManager("TestFile", "C:/testing/test/");

            //write a file
            string testData = "HELLO";
            fileManager.WriteFile(testData);


            //open a file
            //var fileContents = fileManager.ViewFile();



            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();

        }
    }
}
