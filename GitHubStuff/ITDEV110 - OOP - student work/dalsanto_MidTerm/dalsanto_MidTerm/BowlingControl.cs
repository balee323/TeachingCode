using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Mid Term

namespace BowlingScores
{
    class BowlingControl
    {
        public BowlingControl() { }

        BowlingUI BowlUI = new BowlingUI();
        BowlingModel BowlMod = new BowlingModel();

        //View class sets up the display.  Called from Main.
        public void SetupApp()
        {
            BowlUI.SetupDisplay();
            BowlUI.DisplayIntro();
        }//end SetupApp method

        //Main App loop method.  Called from Main.
        public void RunApp()
        {
            //This variable must be defined here as it is assigned a value from a TryParse return.
            //Unfortunately this returned value cannot be passed to a variable in another class.
            int scoreInt = 0;

            //Get the User's attention.
            Console.Beep();

            //Main App Loop
            while (BowlMod.GoGoGo == 1)
            {
                //Control class gets User's input.
                Console.Write("Enter score(or \"r\" to reset, \"f\" to finish): ");
                BowlMod.InputStr = Console.ReadLine();

                //Data validation.  If data is valid, put result into scoreInt.
                if (Int32.TryParse(BowlMod.InputStr, out scoreInt))
                {
                    if (scoreInt >= 0 && scoreInt <= 300)
                    {
                        //Model class does the logic.  Control class gets input and displays results.
                        BowlMod.CountUp();
                        Console.Write("Newest score: " + scoreInt + " | ");
                        Console.Write("Total number of scores: " + BowlMod.ScoreCount + " | ");
                        Console.WriteLine("Score average: " + BowlMod.CalcAverage(BowlMod.ScoreCount, BowlMod.CalcAddTotal(scoreInt)));
                    }
                }
                
                //Finish.
                if (BowlMod.InputStr == "f" || BowlMod.InputStr == "F")
                {
                    //Provide an audible symbol.
                    Console.Beep();

                    while (BowlMod.GoGoGo2 == 1)
                    {
                        BowlUI.DisplayResults();
                        Console.SetCursorPosition(65, 2);
                        Console.Write(BowlMod.ScoreCount);
                        Console.SetCursorPosition(65, 4);
                        Console.Write(BowlMod.ScoreAverageCalc);
                        Console.SetCursorPosition(0, 14);
                        Console.Write("Enter \"r\" to reset, \"q\" to quit: ");
                        BowlMod.InputStr = Console.ReadLine();

                        //Reset App.  Carries "r" value down to original loop.
                        if (BowlMod.InputStr == "r" || BowlMod.InputStr == "R")
                        {
                            BowlMod.GoGoGo2 = 0;
                        }

                        //Quit App.  Terminates both loops.
                        if (BowlMod.InputStr == "q" || BowlMod.InputStr == "Q")
                        {
                            BowlMod.GoGoGo = 0;
                            BowlMod.GoGoGo2 = 0;
                        }
                    }//end Finished loop
                }//end Finished if

                //Reset App.
                if (BowlMod.InputStr == "r" || BowlMod.InputStr == "R")
                {
                    BowlMod.ResetData();
                    BowlUI.DisplayIntro();
                }

            }//end Main App Loop
        }//end RunApp method

        //Goodbye.  Called from Main.
        public void Goodbye()
        {
            BowlUI.DisplayGoodbye();
        }//end Goodbye method
    }//end class
}
