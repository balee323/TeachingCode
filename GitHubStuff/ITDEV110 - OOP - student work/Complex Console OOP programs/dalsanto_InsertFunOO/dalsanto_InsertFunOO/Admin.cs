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
    class Admin
    {
        Game MadLibs = new Game();

        public Admin() {}

        public void ConsoleSetup()
        {
            Console.Title = "Catch-22 Mad Libs";
        }

        //I know the layout is a little off.  Probably should have had the instructions at the top, but
        //I didn't want to edit every single SetCursorPosition to compensate, so they remain at the bottom.
        public void Intro()
        {
            Console.SetCursorPosition(30, 1);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("M A D  L I B S  F U N ! !");

            Console.SetCursorPosition(5, 25);
            Console.Write("Press [");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("e");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("] or [");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("enter");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("] to edit your Mad Libs word choice(13 character limit).");

            Console.SetCursorPosition(5, 26);
            Console.Write("Press [");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("s");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("] to show/hide the Mad Libs text.");

            Console.SetCursorPosition(5, 27);
            Console.Write("Press [");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("up and down arrow keys");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("] to navigate the Mad Libs word choices.");

            Console.SetCursorPosition(5, 28);
            Console.Write("Press [");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("end");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("] to clear all entered Mad Libs text.");

            Console.SetCursorPosition(5, 29);
            Console.Write("Press [");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("esc");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("] to exit the app.");


            Console.ForegroundColor = ConsoleColor.Gray;
            MadLibs.RunGame();
        }

        //This doesn't really do anything.  The app quits when it finishes the while loop in Game.
        public void EndGame()
        {
            Console.Clear();
        }

    }
}
