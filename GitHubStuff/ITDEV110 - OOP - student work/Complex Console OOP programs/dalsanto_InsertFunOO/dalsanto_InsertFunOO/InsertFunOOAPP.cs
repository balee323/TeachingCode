using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Assignment 6

namespace InsertFunOO
{
    class InsertFunOOAPP
    {
        static void Main(string[] args)
        {
            Admin AdminGo = new Admin();

            //this drives everything here.  Intro leads into the Game class.
            AdminGo.ConsoleSetup();
            AdminGo.Intro();

            //EndGame doesn't really do anything.  The game is terminated by the esc key
            //returning a value that ends the game's while loop.
            AdminGo.EndGame();
        }
    }
}
