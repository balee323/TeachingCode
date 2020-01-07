using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowAPP
{
    //Matthew Dal Santo
    //ITDEV110
    //Assignment 7
    class HighLowView
    {
        public HighLowView() { }

        int y = 10;

        public void ViewSetup()
        {
            int x1 = 1;
            int x2 = 10;
            int x3 = 0;

            Console.Clear();

            Console.SetCursorPosition(5, 1);
            Console.Write("High/Low Guessing Game!");
            Console.SetCursorPosition(5, 2);
            Console.Write("Guess a number between 1 and 100!");
            Console.SetCursorPosition(5, 3);
            Console.Write("Or type 'q' to quit, 'r' to replay!");
            Console.SetCursorPosition(5, 5);
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
            Console.SetCursorPosition(25, 5);
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
