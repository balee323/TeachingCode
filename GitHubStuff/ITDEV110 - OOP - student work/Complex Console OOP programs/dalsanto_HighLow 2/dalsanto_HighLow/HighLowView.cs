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
    class HighLowView
    {
        public HighLowView() { }

        int goGo = 0;
        int y = 10;
        int diffInt;
        int diffNum;
        string diffString;

        public int AskDifficulty()
        {
            goGo = 1;
            while (goGo == 1)
            {
                Console.Clear();

                Console.SetCursorPosition(5, 1);
                Console.Write("High/Low Guessing Game!");
                Console.SetCursorPosition(5, 4);
                Console.Write("Choose a difficulty!");
                Console.SetCursorPosition(5, 5);
                Console.Write("1 for Easy(1-20), 2 for Medium(1-50), 3 for Hard(1-100)!");
                Console.SetCursorPosition(5, 6);
                Console.Write("Enter an option : ");
                diffString = Console.ReadLine();
                if (Int32.TryParse(diffString, out diffInt) && diffInt > 0 && diffInt < 4)
                {
                    goGo = 0;
                    if (diffInt == 1) { diffNum = 20; }
                    if (diffInt == 2) { diffNum = 50; }
                    if (diffInt == 3) { diffNum = 100; }
                    return diffNum;
                }
            }
            return diffNum;
        }

        public void ViewCredits(int credits)
        {
            Console.SetCursorPosition(45, 1);
            Console.Write("Total Credits:              ");
            Console.SetCursorPosition(45, 1);
            Console.Write("Total Credits: " + credits);
        }

        public void ViewBet()
        {
            Console.SetCursorPosition(5, 6);
            Console.Write("                            ");
            Console.SetCursorPosition(5, 6);
            Console.Write("Bet how much? :   ");
        }

        public void ShowBetNum(int num)
        {
            Console.SetCursorPosition(45, 2);
            Console.Write("Betting:       ");
            Console.SetCursorPosition(45, 2);
            Console.Write("Betting: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(num);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }

        public void ViewSetup()
        {
            int x1 = 1;
            int x2 = 10;
            int x3 = 0;

            Console.Clear();

            Console.SetCursorPosition(5, 1);
            Console.Write("High/Low Guessing Game!");
            Console.SetCursorPosition(5, 2);
            Console.Write("Guess a number between 1 and " + diffNum + "!");
            Console.SetCursorPosition(5, 4);
            Console.Write("Type 'b' change be amount!");
            Console.SetCursorPosition(5, 5);
            Console.Write("Or type 'q' to quit, 'r' to replay!");
            Console.SetCursorPosition(5, 6);
            Console.Write("Guess a number? : ");

            while (x1 < 100)
            {
                Console.SetCursorPosition((x1 + 4), y);
                Console.Write(x1);
                x1++;
            }
            while (x2 < 100)
            {
                Console.SetCursorPosition((x2 + 4), (y + 1));
                Console.Write(x3);
                x2++;
                x3++;
                if (x3 > 9) { x3 = 0; }
            }
            Console.SetCursorPosition(104, y);
            Console.Write("1");
            Console.SetCursorPosition(104, (y + 1));
            Console.Write("0");
            Console.SetCursorPosition(104, (y + 2));
            Console.Write("0");
        }

        public void NumGuess(int num, int win)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (win == 1)
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
            if (num < 100)
            {
                Console.SetCursorPosition((num + 4), y);
                Console.Write(num / 10);
                if (num < 10)
                {
                    Console.SetCursorPosition((num + 4), y);
                    Console.Write(num);
                }
                if (num > 9)
                {
                    Console.SetCursorPosition((num + 4), (y + 1));
                    Console.Write(num % 10);
                }
            }
            if (num == 100)
            {
                Console.SetCursorPosition(104, y);
                Console.Write("1");
                Console.SetCursorPosition(104, (y + 1));
                Console.Write("0");
                Console.SetCursorPosition(104, (y + 2));
                Console.Write("0");
            }
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }

        public void ClearInput()
        {
            Console.SetCursorPosition(25, 6);
            Console.Write("                                                  ");
        }

        public void ClearMsg()
        {
            Console.SetCursorPosition(25, 7);
            Console.Write("                                                  ");
        }

        public void ShowGuessNum(int num)
        {
            Console.SetCursorPosition(5, 7);
            Console.Write("Guesses: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(num);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
    }
}
