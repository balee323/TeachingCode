using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Assignment 7

namespace HighLowAPP
{
    class HighLowControl
    {
        public HighLowControl() { }

        HighLowModel HLMod = new HighLowModel();
        HighLowView UI = new HighLowView();

        int goGoGo = 1;
        int goGoGo2 = 1;
        int numGuessInt;
        int guessCount;
        string numGuessString;

        public void HLRun()
        {
            HLMod.resetHLRand();
            HLMod.playHey();
            HLMod.playListen();

            while (goGoGo == 1)
            {
                UI.ClearInput();
                Console.SetCursorPosition(25, 5);
                numGuessString = Console.ReadLine();
                if (Int32.TryParse(numGuessString, out numGuessInt))
                {
                    if ((numGuessInt > HLMod.HLRand) && (numGuessInt < 101) && (numGuessInt > 0))
                    {
                        guessCount++;
                        UI.ShowGuessNum(guessCount);
                        UI.ClearMsg();
                        UI.NumGuess(numGuessInt, 0);
                        Console.SetCursorPosition(25, 7);
                        Console.Write("Too High!");
                        HLMod.playUp();
                    }
                    if ((numGuessInt < HLMod.HLRand) && (numGuessInt < 101) && (numGuessInt > 0))
                    {
                        guessCount++;
                        UI.ShowGuessNum(guessCount);
                        UI.ClearMsg();
                        UI.NumGuess(numGuessInt, 0);
                        Console.SetCursorPosition(25, 7);
                        Console.Write("Too Low!");
                        HLMod.playDown();
                    }
                    if (numGuessInt == HLMod.HLRand)
                    {
                        guessCount++;
                        UI.ShowGuessNum(guessCount);
                        UI.ClearMsg();
                        UI.NumGuess(numGuessInt, 1);
                        Console.SetCursorPosition(25, 7);
                        Console.Write("Righto!  You won!");
                        HLMod.playSecret();
                        while (goGoGo2 == 1)
                        {
                            Console.SetCursorPosition(25, 8);
                            Console.Write("Type 'r' to play again or 'q' to quit : ");
                            numGuessString = Console.ReadLine();
                            if (numGuessString == "q" || numGuessString == "Q")
                            {
                                goGoGo2 = 0;
                            }
                            if (numGuessString == "r" || numGuessString == "R")
                            {
                                goGoGo2 = 0;
                            }
                        }
                        goGoGo2 = 1;
                    }
                }
                if (numGuessString == "q" || numGuessString == "Q")
                {
                    while (goGoGo2 == 1)
                    {
                        Console.SetCursorPosition(25, 7);
                        Console.Write("Are you sure?                           ");
                        Console.SetCursorPosition(25, 8);
                        Console.Write("Type 'r' to play again or 'q' to quit : ");
                        numGuessString = Console.ReadLine();
                        if (numGuessString == "q" || numGuessString == "Q")
                        {
                            goGoGo = 0;
                            goGoGo2 = 0;
                        }
                        if (numGuessString == "r" || numGuessString == "R")
                        {
                            goGoGo2 = 0;
                        }
                    }
                    goGoGo2 = 1;
                }
                if (numGuessString == "r" || numGuessString == "R")
                {
                    HLMod.resetHLRand();
                    guessCount = 0;
                    UI.ViewSetup();
                    UI.ShowGuessNum(guessCount);
                } 
            }
        }
    }
}
