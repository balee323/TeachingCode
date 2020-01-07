using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Assignment 10

namespace dalsanto_GuessTheWord
{
    class GuessView
    {
        public GuessView() { }

        int count = 0;
        public string[] alphabet =  { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        public void drawScreen(int wordNum)
        {
            Console.Clear();
            count = 0;
            while (count < wordNum * 2)
            {
                Console.SetCursorPosition(20 + count, 15);
                Console.Write("_");
                count += 2;
            }
            Console.SetCursorPosition(20, 20);
            Console.Write("A B C D E F G H I J K L M N O P Q R S T U V W X Y Z");
            Console.SetCursorPosition(20, 5);
            Console.Write("Guess the Word!");
            Console.SetCursorPosition(20, 6);
            Console.Write("Type any letter key to guess a letter to discover the mysery word below.");
            Console.SetCursorPosition(20, 7);
            Console.Write("Press the Escape key to exit at any time.");
            Console.SetCursorPosition(20, 9);
            Console.Write("  : Attempts Remaining |    Letters in the Mystery Word");
        }

        public void drawLetter(string letter)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (letter == alphabet[i])
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(20 + (i * 2), 20);
                    Console.Write(alphabet[i]);
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void drawAttempts(int num, int wordNum)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(20, 9);
            Console.Write(num);
            Console.SetCursorPosition(45, 9);
            Console.Write(wordNum);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
