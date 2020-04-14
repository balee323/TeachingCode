using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAndStuff
{
    class HandlingExceptions
    {


        public void ExpectionsExample1()
        {

            int tooMuch = 2000;  //if under 1K, all is well

            try
            {
                if (tooMuch > 1000)  //bonus points to Stephanie... 
                {
                    throw new OverflowException("tooMuch is too much");
                }

            }
            catch (NullReferenceException nre)
            {
                Console.WriteLine("Null ref exception happened...");
            }
            catch (OverflowException ofe)
            {
                Console.WriteLine("Overflow exception happened...");
            }
            catch (Exception e)
            {
                Console.WriteLine("tooMuch exception happened...");
            }
        }


    }
}
