using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Assignment 9

namespace dalsanto_Bester
{
    class BesterControl
    {
        BesterView View = new BesterView();
        BesterModel Model = new BesterModel();
        BesterSound Sound = new BesterSound();
        ConsoleKeyInfo key;
        ConsoleKeyInfo anyKey;

        public BesterControl() { }

        public void Game()
        {
            int RunGame = 1;

            View.InitDice();
            View.InitMsgBox();
            IntroMsg();
            Sound.playStart();

            while (RunGame == 1)
            {
                if (Model.PTotal > Model.CTotal && Model.CRolls >= 5)
                {
                    Sound.playPwin();
                    Model.MsgBox(" ");
                    Model.MsgBox("Congratulations!  You've won!");
                    Model.MsgBox(" ");
                    Model.MsgBox("Press any key to continue.");
                    anyKey = Console.ReadKey();
                    Model.ClearScores();
                    View.WritePRolls(Model.PRolls);
                    View.WritePTotal(Model.PTotal);
                    View.WriteCRolls(Model.CRolls);
                    View.WriteCTotal(Model.CTotal);
                    clearDice();
                }
                if (Model.CTotal > Model.PTotal && Model.PRolls >= 5)
                {
                    Sound.playCwin();
                    Model.MsgBox(" ");
                    Model.MsgBox("Too bad!  Try again!");
                    Model.MsgBox(" ");
                    Model.MsgBox("Press any key to continue.");
                    anyKey = Console.ReadKey();
                    Model.ClearScores();
                    View.WritePRolls(Model.PRolls);
                    View.WritePTotal(Model.PTotal);
                    View.WriteCRolls(Model.CRolls);
                    View.WriteCTotal(Model.CTotal);
                    clearDice();
                }
                if (Model.CRolls >= 5 && Model.PRolls >= 5)
                {
                    Model.MsgBox(" ");
                    if (Model.PTotal > Model.CTotal)
                    {
                        Sound.playPwin();
                        Model.MsgBox("Congratulations!  You've won!");
                    }
                    if (Model.PTotal < Model.CTotal)
                    {
                        Sound.playCwin();
                        Model.MsgBox("Too bad!  Try again!");
                    }
                    if (Model.PTotal == Model.CTotal)
                    {
                        Model.MsgBox("You've tied!");
                    }
                    Model.MsgBox(" ");
                    Model.MsgBox("Press any key to continue.");
                    anyKey = Console.ReadKey();
                    Model.ClearScores();
                    View.WritePRolls(Model.PRolls);
                    View.WritePTotal(Model.PTotal);
                    View.WriteCRolls(Model.CRolls);
                    View.WriteCTotal(Model.CTotal);
                    clearDice();
                }

                if (anyKey.Key == ConsoleKey.Q)
                {
                    RunGame = 0;
                    break;
                }

                key = Console.ReadKey();
                if (key.Key == ConsoleKey.R)
                {
                    if (Model.PRolls >= 5)
                    {
                        Model.MsgBox("You cannot roll again.");
                    }
                    else
                    {
                        rollPDice();
                        Model.PRolls++;
                        Model.MsgBox("Player rolled " + Model.PTotal + " total!");
                        View.WritePRolls(Model.PRolls);
                        View.WritePTotal(Model.PTotal);
                    }
                }
                if (key.Key == ConsoleKey.H)
                {
                    Model.MsgBox("Player held.");
                }
                if (key.Key == ConsoleKey.Q)
                {
                    RunGame = 0;
                    break;
                }

                if (Model.PRolls == 0 && Model.CRolls == 0 && RunGame == 1)
                {
                    Model.MsgBox("You must roll at least once.");
                    rollPDice();
                    Model.PRolls++;
                    Model.MsgBox("Player rolled " + Model.PTotal + " total!");
                    View.WritePRolls(Model.PRolls);
                    View.WritePTotal(Model.PTotal);
                }

                if (RunGame == 1)
                {
                    if (Model.CRolls >= 5)
                    {
                        Model.MsgBox("Computer cannot roll.");
                    }
                    else if (Model.CTotal > Model.PTotal)
                    {
                        Model.MsgBox("Computer holds.");
                    }
                    else
                    {
                        rollCDice();
                        Model.CRolls++;
                        Model.MsgBox("Computer rolled " + Model.CTotal + " total!");
                        View.WriteCRolls(Model.CRolls);
                        View.WriteCTotal(Model.CTotal);
                    }
                }
            }
        }

        public void IntroMsg()
        {
            Model.MsgBox("Good luck!");
            Model.MsgBox("Follow the legend on the right to play.");
            Model.MsgBox("the computer.");
            Model.MsgBox("Your goal is to score more than");
            Model.MsgBox("You have 5 rolls per turn.");
        }

        public void rollCDice()
        {
            int count = 0;
            int count2 = 0;
            int total = 0;
            Sound.playCRoll();
            while (count2 < 5)
            {
                while (count < 5)
                {
                    Model.WaitTimer(40 + (count * 20));
                    Model.CDice[count2] = Model.getRand();
                    View.WriteCDice(Model.CDice[count2], count2 + 1);
                    count++;
                }
                total = total + Model.CDice[count2];
                count = 0;
                count2++;
            }
            Model.CTotal = total;
        }

        public void rollPDice()
        {
            int count = 0;
            int count2 = 0;
            int total = 0;
            Sound.playPRoll();
            while (count2 < 5)
            {
                while (count < 5)
                {
                    Model.WaitTimer(40 + (count * 20));
                    Model.PDice[count2] = Model.getRand();
                    View.WritePDice(Model.PDice[count2], count2 + 1);
                    count++;
                }
                total = total + Model.PDice[count2];
                count = 0;
                count2++;
            }
            Model.PTotal = total;
        }

        public void clearDice()
        {
            int count = 0;
            while (count < 5)
            {
                View.WriteCDice(0, count + 1);
                View.WritePDice(0, count + 1);
                count++;
            }
        }
    }
}
