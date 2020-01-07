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
    class GuessControl
    {
        public GuessControl() { }

        GuessView gView = new GuessView();
        GuessModel gModel = new GuessModel();
        GuessSound gSound = new GuessSound();

        ConsoleKeyInfo gLetterChar;
        string gLetter;

        public void runGuess()
        {
            Console.Title = "Guess The Word";
            gSound.PlaySound(1);
            while (gModel.RunOn == 1)
            {
                if (gModel.Reset == 1)
                {
                    gModel.rndString();
                    gView.drawScreen(gModel.curWord.Count);
                    gModel.LetterTotal = 0;
                    gModel.GuessTotal = 0;
                    gModel.Reset = 0;
                }
                
                gView.drawAttempts(7 - gModel.GuessTotal, gModel.curWord.Count);
                Console.SetCursorPosition(0, 0);
                gLetterChar = Console.ReadKey();
                if (gLetterChar.Key == ConsoleKey.Escape) { gModel.RunOn = 0; }
                gLetter = gLetterChar.KeyChar.ToString();
                gLetter = gLetter.ToUpper();
                gModel.scanString(gLetter);
                gView.drawLetter(gLetter);
                //win
                if (gModel.LetterTotal == gModel.curWord.Count)
                {
                    gSound.PlaySound(5);
                    Console.SetCursorPosition(20, 11);
                    Console.Write("Great job!  You guessed it!");
                    do
                    {
                        Console.SetCursorPosition(20, 12);
                        Console.Write("Play again?(Y/N)");
                        gLetterChar = Console.ReadKey();
                    } while (gLetterChar.Key != ConsoleKey.Y && gLetterChar.Key != ConsoleKey.N);
                    if (gLetterChar.Key == ConsoleKey.Y) { gModel.Reset = 1; }
                    if (gLetterChar.Key == ConsoleKey.N) { gModel.RunOn = 0; }
                }
                //loss
                if (gModel.GuessTotal >= 7 && gModel.LetterTotal < gModel.curWord.Count)
                {
                    gSound.PlaySound(4);
                    Console.SetCursorPosition(20, 11);
                    Console.Write("Too bad!  Better luck next time!");
                    do
                    {
                        Console.SetCursorPosition(20, 12);
                        Console.Write("Play again?(Y/N)");
                        gLetterChar = Console.ReadKey();
                    } while (gLetterChar.Key != ConsoleKey.Y && gLetterChar.Key != ConsoleKey.N);
                    if (gLetterChar.Key == ConsoleKey.Y) { gModel.Reset = 1; }
                    if (gLetterChar.Key == ConsoleKey.N) { gModel.RunOn = 0; }
                }
            }
        }
    }
}
