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
    class BowlingUI
    {
        public BowlingUI() { }

        //Display setup.
        public void SetupDisplay()
        {
            Console.Title = "Average Bowling Scores Mid Term Assignment";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }

        //Found the ASCII art.  Always give credit where credit is due.
        public void BowlClear()
        {
            Console.Clear();
            Console.WriteLine("           .-. ");
            Console.WriteLine("           \\ /      .-. ");
            Console.WriteLine("           |_|  .-. \\ / ");
            Console.WriteLine("           |=|  \\ / |_| ");
            Console.WriteLine("          /   \\ |_| |=| ");
            Console.WriteLine("         / (@) \\|=|/   \\ ");
            Console.WriteLine("    ____ |     /   \\@)  \\ ");
            Console.WriteLine("  .'    '.    / (@) \\   | ");
            Console.WriteLine(" / #      \\   |     |   | ");
            Console.WriteLine(" |    o o |'='|     |  / ");
            Console.WriteLine(" \\      o /    \\   /'=' ");
            Console.WriteLine("  '.____.'      '=' ");
            Console.WriteLine(" ACSII by jgs, http://www.chris.com/ascii/");
            Console.SetCursorPosition(30, 0);
            Console.Write("Bowling Scores Average Mid Term");
        }//end BowlClear method

        //Intro.
        public void DisplayIntro()
        {
            BowlClear();
            Console.SetCursorPosition(30, 2);
            Console.Write("Begin by entering scores to average.  The App will calculate as you enter your scores.");
            Console.SetCursorPosition(30, 3);
            Console.Write("Scores must be an interger from 0 to 300.  Averages will be rounded to the");
            Console.SetCursorPosition(30, 4);
            Console.Write("nearest interger.");
            Console.SetCursorPosition(30, 6);
            Console.Write("Enter \"r\" if you'd like to reset the app.");
            Console.SetCursorPosition(30, 7);
            Console.Write("Enter \"f\" when you're finished entering scores.");
            Console.SetCursorPosition(30, 9);
            Console.Write("If you've entered too many scores that some information is no longer on the screen,");
            Console.SetCursorPosition(30, 10);
            Console.Write("just scroll back up to see the instructions or previously entered scores.");
            Console.SetCursorPosition(0, 14);
        }//end DisplayIntro method

        //Final results.
        public void DisplayResults()
        {
            BowlClear();
            Console.SetCursorPosition(30, 2);
            Console.Write("Total number of scores entered:");
            Console.SetCursorPosition(30, 4);
            Console.Write("Average of all entered scores:");
            Console.SetCursorPosition(30, 6);
            Console.Write("Enter \"r\" if you'd like to reset the app and enter a new set of scores.");
            Console.SetCursorPosition(30, 7);
            Console.Write("Enter \"q\" if you'd like to quit.");
            Console.SetCursorPosition(0, 14);
        }//end DisplayResults method

        //Closing screen message and set of tones.
        public void DisplayGoodbye()
        {
            BowlClear();
            Console.SetCursorPosition(40, 9);
            Console.Write("█");
            Console.Beep(392, 200);//G
            Console.SetCursorPosition(42, 8);
            Console.Write("█");
            Console.Beep(370, 200);//F#
            Console.SetCursorPosition(44, 5);
            Console.Write("█");
            Console.Beep(311, 200);//D#
            Console.SetCursorPosition(46, 11);
            Console.Write("█");
            Console.Beep(220, 200);//A
            Console.SetCursorPosition(48, 10);
            Console.Write("█");
            Console.Beep(415, 200);//G#
            Console.SetCursorPosition(50, 6);
            Console.Write("█");
            Console.Beep(330, 200);//E
            Console.SetCursorPosition(52, 10);
            Console.Write("█");
            Console.Beep(415, 200);//G#
            Console.SetCursorPosition(54, 2);
            Console.Write("█  Goodbye...");
            Console.Beep(262, 200);//C
            Console.ReadKey();
        }//end DisplayGoodbye method
    }//end class
}
