using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Assignment 10

namespace dalsanto_GuessTheWord
{
    class GuessModel
    {
        public GuessModel() { }

        GuessSound gSound = new GuessSound();

        public string[] word1 = { "B", "L", "I", "Z", "Z", "A", "R", "D" };
        public string[] word2 = { "F", "L", "U", "F", "F", "I", "N", "E", "S", "S" };
        public string[] word3 = { "H", "A", "P", "H", "A", "Z", "A", "R", "D" };
        public string[] word4 = { "J", "A", "Z", "Z", "Y" };
        public string[] word5 = { "G", "L", "O", "W", "W", "O", "R", "M" };
        public string[] word6 = { "C", "U", "R", "A", "C", "A", "O" };
        public string[] word7 = { "W", "H", "I", "S", "K", "E", "Y" };
        public string[] word8 = { "F", "I", "S", "H", "H", "O", "O", "K" };
        public string[] word9 = { "E", "S", "P", "I", "O", "N", "A", "G", "E" };
        public string[] word10 = { "D", "A", "I", "Q", "U", "I", "R", "I" };
        public string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        public List<string> curWord = new List<string>();
        public List<string> gLetters = new List<string>();

        Random rnd = new Random();

        private int runOn = 1;
        public int RunOn { get { return runOn; } set { runOn = value; } }
        private int reset = 1;
        public int Reset { get { return reset; } set { reset = value; } }
        private int letterTotal = 0;
        public int LetterTotal { get { return letterTotal; } set { letterTotal = value; } }
        private int guessTotal = 0;
        public int GuessTotal { get { return guessTotal; } set { guessTotal = value; } }

        public void rndString()
        {
            int tempInt = rnd.Next(1, 11);
            curWord.Clear();
            gLetters.Clear();
            switch (tempInt)
            {
                case 1:
                    for (int i = 0; i < word1.Length; i++) { curWord.Add(word1[i]); }
                    break;
                case 2:
                    for (int i = 0; i < word2.Length; i++) { curWord.Add(word2[i]); }
                    break;
                case 3:
                    for (int i = 0; i < word3.Length; i++) { curWord.Add(word3[i]); }
                    break;
                case 4:
                    for (int i = 0; i < word4.Length; i++) { curWord.Add(word4[i]); }
                    break;
                case 5:
                    for (int i = 0; i < word5.Length; i++) { curWord.Add(word5[i]); }
                    break;
                case 6:
                    for (int i = 0; i < word6.Length; i++) { curWord.Add(word6[i]); }
                    break;
                case 7:
                    for (int i = 0; i < word7.Length; i++) { curWord.Add(word7[i]); }
                    break;
                case 8:
                    for (int i = 0; i < word8.Length; i++) { curWord.Add(word8[i]); }
                    break;
                case 9:
                    for (int i = 0; i < word9.Length; i++) { curWord.Add(word9[i]); }
                    break;
                case 10:
                    for (int i = 0; i < word10.Length; i++) { curWord.Add(word10[i]); }
                    break;
                default:
                    break;
            }
        }

        public void scanString(string str)
        {
            int doAddWord = 1;
            int doAddGuess = 1;
            int tempTotal = letterTotal;
            for (int a = 0; a < alphabet.Length; a++)
            {
                if (str == alphabet[a])
                {
                    for (int i = 0; i < gLetters.Count; i++)
                    {
                        if (str == gLetters[i])
                        {
                            doAddWord = 0;
                            doAddGuess = 0;
                        }
                    }
                    for (int i = 0; i < curWord.Count; i++)
                    {
                        if (str == curWord[i] && doAddWord == 1)
                        {
                            letterTotal++;
                            Console.SetCursorPosition(20 + (i * 2), 15);
                            Console.Write(curWord[i]);
                            doAddGuess = 0;
                        }
                    }
                    if (doAddGuess == 1) { GuessTotal = GuessTotal + doAddGuess; gSound.PlaySound(2); }
                    while (tempTotal < letterTotal)
                    {
                        tempTotal++;
                        gSound.PlaySound(3);
                        Thread.Sleep(300);
                    }
                    gLetters.Add(str);
                }
            }
        }
    }
}
