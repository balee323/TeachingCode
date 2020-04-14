using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAndStuff
{

    //https://www.tutorialspoint.com/Try-Catch-Finally-in-Chash
    //https://www.tutorialsteacher.com/Content/images/csharp/exception-hierarchy.png

    class Program
    {
        static void Main(string[] args)
        {



            var handlingExceptions = new HandlingExceptions();

            //Let's look at some basic Exception handling
            handlingExceptions.ExpectionsExample1();

        }
    }
}
