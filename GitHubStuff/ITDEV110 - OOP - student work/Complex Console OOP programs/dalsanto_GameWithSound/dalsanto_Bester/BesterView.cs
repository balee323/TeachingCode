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
    class BesterView
    {
        public BesterView() { }

        public void InitDice()
        {
            int count = 1;
            int x = 20;
            while (count < 6)
            {
                Console.SetCursorPosition(x, 13);
                Console.Write("/---\\");
                Console.SetCursorPosition(x, 14);
                Console.Write("|- -|");
                Console.SetCursorPosition(x, 15);
                Console.Write("\\---/");
                count++;
                x = x + 7;
            }
            Console.SetCursorPosition(x, 14);
            Console.Write("Computer :");

            count = 1;
            x = 20;
            while (count < 6)
            {
                Console.SetCursorPosition(x, 18);
                Console.Write("/---\\");
                Console.SetCursorPosition(x, 19);
                Console.Write("|- -|");
                Console.SetCursorPosition(x, 20);
                Console.Write("\\---/");
                count++;
                x = x + 7;
            }
            Console.SetCursorPosition(x, 19);
            Console.Write("Player   :");
            Console.SetCursorPosition(0, 0);
        }

        public void InitMsgBox()
        {
            int x = 0;
            int y = 0;

            x = 20;
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Bester!");
            Console.ForegroundColor = ConsoleColor.DarkRed;

            y = 1;
            x = 15;
            while (x < 61)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("-");
                x++;
            }

            y = 10;
            x = 15;
            while (x < 61)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("-");
                x++;
            }

            y = 2;
            x = 15;
            Console.SetCursorPosition(x, y - 1);
            Console.Write("+");
            while (y < 10)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("|");
                y++;
            }
            Console.SetCursorPosition(x, y);
            Console.Write("+");

            y = 2;
            x = 60;
            Console.SetCursorPosition(x, y - 1);
            Console.Write("+");
            while (y < 10)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("|");
                y++;
            }
            Console.SetCursorPosition(x, y);
            Console.Write("+");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(65, 3);
            Console.Write("R");
            Console.SetCursorPosition(65, 5);
            Console.Write("H");
            Console.SetCursorPosition(65, 7);
            Console.Write("Q");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(67, 3);
            Console.Write(": Roll");
            Console.SetCursorPosition(67, 5);
            Console.Write(": Hold");
            Console.SetCursorPosition(67, 7);
            Console.Write(": Quit");
            Console.SetCursorPosition(20, 12);
            Console.Write("Computer Rolls :");
            Console.SetCursorPosition(20, 17);
            Console.Write("Player Rolls   :");
            Console.SetCursorPosition(0, 0);
        }

        public void WriteCRolls(int num)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(37, 12);
            Console.Write(num);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(0, 0);
        }

        public void WritePRolls(int num)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(37, 17);
            Console.Write(num);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(0, 0);
        }

        public void WriteCTotal(int num)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(66, 14);
            Console.Write("  ");
            Console.SetCursorPosition(66, 14);
            Console.Write(num);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(0, 0);
        }

        public void WritePTotal(int num)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(66, 19);
            Console.Write("  ");
            Console.SetCursorPosition(66, 19);
            Console.Write(num);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(0, 0);
        }

        public void WriteCDice(int num, int dnum)
        {
            int x = 6;
            x = (x * dnum) + dnum;
            Console.SetCursorPosition(15 + x, 14);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(num);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(0, 0);
        }

        public void WritePDice(int num, int dnum)
        {
            int x = 6;
            x = (x * dnum) + dnum;
            Console.SetCursorPosition(15 + x, 19);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(num);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(0, 0);
        }
    }
}
