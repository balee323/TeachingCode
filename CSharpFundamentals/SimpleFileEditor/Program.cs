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


            SimpleFileManager fileManager = new SimpleFileManager("C:/testing/testfile.txt");//file path

            //var fileManager = new FileStreamManager("TestFile", "C:/testing/test/");

            //for breakpoint
            ;


            //write a file
           // string testData = "HELLO";
           // fileManager.SaveFile(testData);


            //open a file as single string
            string fileContents = fileManager.LoadTextFileAsSingleString();

            //for breakpoint
            ;

            //open file as a List of lines
            List<string> fileLines = fileManager.LoadTextFileAsLines();

            //for breakpoint
            ;

            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();

        }
    }
}
