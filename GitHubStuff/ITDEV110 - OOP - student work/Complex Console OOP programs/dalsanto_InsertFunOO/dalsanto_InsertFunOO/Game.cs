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
    class Game
    {
        ConsoleKeyInfo keyPress;
        int stayOn = 1;
        int showPoem = 0;

        InsertFunOOUI OOUI = new InsertFunOOUI();

        public Game() { }

        //The while loop that drives everything.
        public void RunGame()
        {
            OOUI.DisplayInput();
            OOUI.InCursor();

            while (stayOn == 1)
            {
                //This keeps the cursor from jumping around all over.  It stays in the upper lefthand corner.
                //Also writes over itself, so user keypress input isn't displayed and 'just works'.
                Console.SetCursorPosition(0, 0);
                keyPress = Console.ReadKey();
                Console.SetCursorPosition(0, 0);
                Console.Write(" ");

                //keyPress logic
                //Enter Input based in cursor location
                if (keyPress.Key == ConsoleKey.E || keyPress.Key == ConsoleKey.Enter)
                {
                    OOUI.InScreen();
                    //Probably should have made this a method.
                    if (showPoem == 1)
                    {
                        OOUI.ClearPoem();
                        OOUI.Poem();
                    }
                    else
                    {
                        OOUI.ClearPoem();
                    }
                }
                //show or hide poem
                if (keyPress.Key == ConsoleKey.S)
                {
                    if (showPoem == 0)
                    {
                        showPoem = 1;
                        OOUI.Poem();
                    }
                    else
                    {
                        showPoem = 0;
                        OOUI.ClearPoem();
                    }
                }
                //move cursor up
                if (keyPress.Key == ConsoleKey.UpArrow)
                {
                    if (OOUI.MadChoice > 4){
                        OOUI.MadChoice = OOUI.MadChoice - 2;
                    }
                    else if (OOUI.MadChoice == 4)
                    {
                        OOUI.MadChoice = 22;
                    }
                    OOUI.InCursor();
                }
                //move cursor down
                if (keyPress.Key == ConsoleKey.DownArrow)
                {
                    if (OOUI.MadChoice < 22)
                    {
                        OOUI.MadChoice = OOUI.MadChoice + 2;
                    }
                    else if (OOUI.MadChoice == 22)
                    {
                        OOUI.MadChoice = 4;
                    }
                    OOUI.InCursor();
                }
                //clear all input to original values
                if (keyPress.Key == ConsoleKey.End)
                {
                    OOUI.ClearMadLibs();
                    OOUI.InCursor();
                    if (showPoem == 1)
                    {
                        OOUI.ClearPoem();
                        OOUI.Poem();
                    }
                    else
                    {
                        OOUI.ClearPoem();
                    }
                }
                //exit while loop
                if (keyPress.Key == ConsoleKey.Escape)
                {
                    stayOn = 0;
                }
            }
        }
    }
}
