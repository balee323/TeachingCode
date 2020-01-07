using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Assignment 10

namespace dalsanto_GuessTheWord
{
    class GuessApp
    {
        static void Main(string[] args)
        {
            GuessControl gControl = new GuessControl();

            gControl.runGuess();

        }
    }
}
