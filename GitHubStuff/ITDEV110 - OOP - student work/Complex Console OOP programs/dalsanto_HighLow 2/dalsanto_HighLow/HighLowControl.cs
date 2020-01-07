using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Assignment 8

namespace HighLowAPP
{
    class HighLowControl
    {
        public HighLowControl() { }

        HighLowModel HLMod = new HighLowModel();
        HighLowView UI = new HighLowView();

        int goGoGo = 1;
        int goGoGo2 = 1;
        int win = 0;
        int goBet;
        int numGuessInt;
        int guessCount;
        int credits = 100;
        int betNumInt;
        int diff;
        string betNumStr;
        string numGuessString;

        public void HLRun()
        {
            diff = UI.AskDifficulty();
            UI.ViewSetup();
            UI.ViewCredits(credits);
            UI.ShowBetNum(betNumInt);
            HLMod.resetHLRand(diff);
            //HLMod.playHey();
            //HLMod.playListen();

            while (goGoGo == 1)
            {
                UI.ClearInput();
                Console.SetCursorPosition(25, 6);
                numGuessString = Console.ReadLine();
                if (Int32.TryParse(numGuessString, out numGuessInt))
                {
                    if ((numGuessInt > HLMod.HLRand) && (numGuessInt < diff + 1) && (numGuessInt > 0))
                    {
                        guessCount++;
                        UI.ShowGuessNum(guessCount);
                        UI.ClearMsg();
                        UI.NumGuess(numGuessInt, 0);
                        Console.SetCursorPosition(25, 7);
                        Console.Write("Too High!");
                        //HLMod.playUp();
                        if (betNumInt > 0)
                        {
                            if (betNumInt > credits)
                            {
                                credits = 0;
                                betNumInt = 0;
                            }
                            else { credits = credits - betNumInt; }
                            UI.ShowBetNum(betNumInt);
                            UI.ViewCredits(credits);
                        }
                    }
                    if ((numGuessInt < HLMod.HLRand) && (numGuessInt < diff + 1) && (numGuessInt > 0))
                    {
                        guessCount++;
                        UI.ShowGuessNum(guessCount);
                        UI.ClearMsg();
                        UI.NumGuess(numGuessInt, 0);
                        Console.SetCursorPosition(25, 7);
                        Console.Write("Too Low!");
                        //HLMod.playDown();
                        if (betNumInt > 0)
                        {
                            if (betNumInt > credits)
                            {
                                credits = 0;
                                betNumInt = 0;
                            }
                            else { credits = credits - betNumInt; }
                            UI.ShowBetNum(betNumInt);
                            UI.ViewCredits(credits);
                        }
                    }
                    if (numGuessInt == HLMod.HLRand)
                    {
                        guessCount++;
                        UI.ShowGuessNum(guessCount);
                        UI.ClearMsg();
                        UI.NumGuess(numGuessInt, 1);
                        Console.SetCursorPosition(25, 7);
                        Console.Write("Righto!  You won!");
                        //HLMod.playSecret();
                        credits = 100 + betNumInt;
                        betNumInt = 0;
                        win = 1;
                        UI.ShowBetNum(betNumInt);
                        UI.ViewCredits(credits);

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
                if (credits <= 0) { numGuessString = "q"; }
                if (numGuessString == "b" || numGuessString == "B")
                {
                    if (credits <= 0)
                    {
                        UI.ClearMsg();
                        Console.SetCursorPosition(25, 7);
                        Console.Write("No Credits to Bet!");
                    }
                    else
                    {
                        goBet = 1;
                        UI.ViewCredits(credits);
                        while (goBet == 1)
                        {
                            UI.ShowBetNum(betNumInt);
                            UI.ViewBet();
                            Console.SetCursorPosition(25, 6);
                            betNumStr = Console.ReadLine();
                            if (Int32.TryParse(betNumStr, out betNumInt))
                            {
                                if (betNumInt > 0)
                                {
                                    goBet = 0;
                                }
                            }
                            if (betNumInt < 0) { betNumInt = 0; }
                            if (credits < betNumInt) { betNumInt = credits; }
                        }
                        UI.ViewCredits(credits);
                        UI.ShowBetNum(betNumInt);
                        UI.ShowGuessNum(guessCount);
                        UI.ClearMsg();
                        Console.SetCursorPosition(5, 6);
                        Console.Write("Guess a number? : ");
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
                    if (win == 0) { credits = 100; }
                    win = 0;
                    HLMod.resetHLRand(diff);
                    guessCount = 0;
                    UI.ViewSetup();
                    UI.ShowBetNum(betNumInt);
                    UI.ViewCredits(credits);
                    UI.ShowGuessNum(guessCount);
                } 
            }
        }
    }
}
