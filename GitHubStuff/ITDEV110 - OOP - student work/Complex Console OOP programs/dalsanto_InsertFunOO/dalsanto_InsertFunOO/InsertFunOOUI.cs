using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Assignment 6

namespace InsertFunOO
{
    class InsertFunOOUI
    {
        string madLib1 = "_____________";
        string madLib2 = "_____________";
        string madLib3 = "_____________";
        string madLib4 = "_____________";
        string madLib5 = "_____________";
        string madLib6 = "_____________";
        string madLib7 = "_____________";
        string madLib8 = "_____________";
        string madLib9 = "_____________";
        string madLib10 = "_____________";
        
        //poem X axis
        int pX = 40;
        //input X axis
        int iX = 20;
        //input clear X axis
        int clearY;

        private int madChoice = 4;
        public int MadChoice { get { return madChoice; } set { madChoice = value; } }

        //Solution for truncating strings found at https://www.dotnetperls.com/truncate
        //See the InScreen method.  I decided to use this as it seemed the simplest solution and 
        //C# doesn't seem to have a native truncate method.
        string Truncate(string source, int length)
        {
            if (source.Length > length)
            {
                source = source.Substring(0, length);
            }
            return source;
        }

        public InsertFunOOUI() { }

        //This get's the user's input based on where the cursor value is
        //it uses a Truncate string method(?) I found and edited so that it wasn't public.
        //I didn't completely understand the logic(array?), but I understood enough that it
        //originally used a much larger scope than is prefered and so I contained it to this
        //class only.
        public void InScreen()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (madChoice == 0)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                return;
            }
            if (madChoice == 4)
            {
                Console.SetCursorPosition(iX, madChoice);
                Console.Write("                    ");
                Console.SetCursorPosition(iX, madChoice);
                madLib1 = Console.ReadLine();
                madLib1 = Truncate(madLib1, 13);
            }
            if (madChoice == 6)
            {
                Console.SetCursorPosition(iX, madChoice);
                Console.Write("                    ");
                Console.SetCursorPosition(iX, madChoice);
                madLib2 = Console.ReadLine();
                madLib2 = Truncate(madLib2, 13);
            }
            if (madChoice == 8)
            {
                Console.SetCursorPosition(iX, madChoice);
                Console.Write("                    ");
                Console.SetCursorPosition(iX, madChoice);
                madLib3 = Console.ReadLine();
                madLib3 = Truncate(madLib3, 13);
            }
            if (madChoice == 10)
            {
                Console.SetCursorPosition(iX, madChoice);
                Console.Write("                    ");
                Console.SetCursorPosition(iX, madChoice);
                madLib4 = Console.ReadLine();
                madLib4 = Truncate(madLib4, 13);
            }
            if (madChoice == 12)
            {
                Console.SetCursorPosition(iX, madChoice);
                Console.Write("                    ");
                Console.SetCursorPosition(iX, madChoice);
                madLib5 = Console.ReadLine();
                madLib5 = Truncate(madLib5, 13);
            }
            if (madChoice == 14)
            {
                Console.SetCursorPosition(iX, madChoice);
                Console.Write("                    ");
                Console.SetCursorPosition(iX, madChoice);
                madLib6 = Console.ReadLine();
                madLib6 = Truncate(madLib6, 13);
            }
            if (madChoice == 16)
            {
                Console.SetCursorPosition(iX, madChoice);
                Console.Write("                    ");
                Console.SetCursorPosition(iX, madChoice);
                madLib7 = Console.ReadLine();
                madLib7 = Truncate(madLib7, 13);
            }
            if (madChoice == 18)
            {
                Console.SetCursorPosition(iX, madChoice);
                Console.Write("                    ");
                Console.SetCursorPosition(iX, madChoice);
                madLib8 = Console.ReadLine();
                madLib8 = Truncate(madLib8, 13);
            }
            if (madChoice == 20)
            {
                Console.SetCursorPosition(iX, madChoice);
                Console.Write("                    ");
                Console.SetCursorPosition(iX, madChoice);
                madLib9 = Console.ReadLine();
                madLib9 = Truncate(madLib9, 13);
            }
            if (madChoice == 22)
            {
                Console.SetCursorPosition(iX, madChoice);
                Console.Write("                    ");
                Console.SetCursorPosition(iX, madChoice);
                madLib10 = Console.ReadLine();
                madLib10 = Truncate(madLib10, 13);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            InCursor();

        }

        //This method is for updating just the madLib values and also hilighting the
        //'cursor' madLib.
        public void InCursor()
        {
            //This clears all the values and then replaces them with their value.
            //Basically a super inefficient way of updating a value when needed without
            //specifying a specific value to update.
            clearY = 4;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            while (clearY <= 22)
            {
                Console.SetCursorPosition(iX, clearY);
                Console.Write("                    ");
                Console.SetCursorPosition(iX, clearY);
                if (clearY == 4) { Console.Write(madLib1); }
                if (clearY == 6) { Console.Write(madLib2); }
                if (clearY == 8) { Console.Write(madLib3); }
                if (clearY == 10) { Console.Write(madLib4); }
                if (clearY == 12) { Console.Write(madLib5); }
                if (clearY == 14) { Console.Write(madLib6); }
                if (clearY == 16) { Console.Write(madLib7); }
                if (clearY == 18) { Console.Write(madLib8); }
                if (clearY == 20) { Console.Write(madLib9); }
                if (clearY == 22) { Console.Write(madLib10); }
                clearY = clearY + 2;
            }

            //Hilights one value depending on the 'cursor' position.
            Console.SetCursorPosition(iX, madChoice);
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("             ");
            Console.SetCursorPosition(iX, madChoice);
            if (madChoice == 4) { Console.Write(madLib1); }
            if (madChoice == 6) { Console.Write(madLib2); }
            if (madChoice == 8) { Console.Write(madLib3); }
            if (madChoice == 10) { Console.Write(madLib4); }
            if (madChoice == 12) { Console.Write(madLib5); }
            if (madChoice == 14) { Console.Write(madLib6); }
            if (madChoice == 16) { Console.Write(madLib7); }
            if (madChoice == 18) { Console.Write(madLib8); }
            if (madChoice == 20) { Console.Write(madLib9); }
            if (madChoice == 22) { Console.Write(madLib10); }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        //Display finished MadLibs
        //The layout is a little strange in a couple spots.  I didn't want the text to wrap
        //so I just split a couple lines.
        public void Poem()
        {
            Console.SetCursorPosition(pX, 3);
            Console.Write("'You mean there’s a ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(madLib5);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("?'");

            Console.SetCursorPosition(pX, 5);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("'Sure there’s a ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(madLib5);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(",' Doc ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(madLib1);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" replied. 'Catch-22.");

            Console.SetCursorPosition(pX, 6);
            Console.Write("Anyone who wants to get out of combat duty isn’t really crazy.'");

            Console.SetCursorPosition(pX, 8);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("There was only one ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(madLib5);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" and that was Catch-22, which specified");

            Console.SetCursorPosition(pX, 9);
            Console.Write("that a concern for one’s own safety in the face of dangers that");

            Console.SetCursorPosition(pX, 10);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("were real and ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(madLib8);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" was the process of a rational mind.  ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(madLib2);

            Console.SetCursorPosition(pX, 11);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("was crazy and could be grounded. All he had to do was ask; and");

            Console.SetCursorPosition(pX, 12);
            Console.Write("as soon as he did, he would no longer be crazy and would have");

            Console.SetCursorPosition(pX, 13);
            Console.Write("to ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(madLib3);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" more ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(madLib4);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(". ");

            Console.SetCursorPosition(pX, 14);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(madLib2);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" would be crazy to ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(madLib3);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" more ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(madLib4);

            Console.SetCursorPosition(pX, 15);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("and sane if he didn’t, but if he was sane he had to ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(madLib3);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" them.");

            Console.SetCursorPosition(pX, 16);
            Console.Write("If he ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(madLib7);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" then he was crazy and didn’t have to; but if he");

            Console.SetCursorPosition(pX, 17);
            Console.Write("didn’t want to he was sane and had to.  Yossarian was moved very");

            Console.SetCursorPosition(pX, 18);
            Console.Write("deeply by the ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(madLib6);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" simplicity of this clause of Catch-22");

            Console.SetCursorPosition(pX, 19);
            Console.Write("and let out a ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(madLib9);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(madLib10);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(".");
            
            Console.SetCursorPosition(pX, 21);
            Console.Write("'That’s some ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(madLib5);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(", that Catch-22,' he observed.");

            Console.SetCursorPosition(pX, 23);
            Console.Write("'It’s the best there is,' Doc ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(madLib1);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" agreed.");
        }

        //Clears the poem for either refreshing values or hiding it from the user.
        //I know this method is rather inefficient and that I should have built each part into
        //modules that could be loaded or unloaded on the fly, but I didn't want to rewrite everything 
        //a minor assignment so...
        public void ClearPoem()
        {
            clearY = 3;
            while (clearY < 24)
            {
                Console.SetCursorPosition(pX, clearY);
                Console.Write("                                                                              ");
                clearY = clearY + 1;
            }
        }

        //This returns the Mad Libs values to their original value.
        public void ClearMadLibs()
        {
            madLib1 = "_____________";
            madLib2 = "_____________";
            madLib3 = "_____________";
            madLib4 = "_____________";
            madLib5 = "_____________";
            madLib6 = "_____________";
            madLib7 = "_____________";
            madLib8 = "_____________";
            madLib9 = "_____________";
            madLib10 = "_____________";
        }
        
        //This displays the initial input direction for the Mad Libs values
        //It also updates all the Mad Libs values displayed.  If I really wanted to optimize
        //this, I could have split up this into two methods.
        public void DisplayInput()
        {
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("Person's Last Name: ");
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("Person's Name: ");
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("Present Tense Verb: ");
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("Thing: ");
            Console.SetCursorPosition(0, 12);
            Console.WriteLine("Thing: ");
            Console.SetCursorPosition(0, 14);
            Console.WriteLine("Adjective: ");
            Console.SetCursorPosition(0, 16);
            Console.WriteLine("Past Tense Verb: ");
            Console.SetCursorPosition(0, 18);
            Console.WriteLine("Adjective: ");
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("Adjective: ");
            Console.SetCursorPosition(0, 22);
            Console.WriteLine("Exclaimation: ");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(iX, 4);
            Console.Write(madLib1);
            Console.SetCursorPosition(iX, 6);
            Console.Write(madLib2);
            Console.SetCursorPosition(iX, 8);
            Console.Write(madLib3);
            Console.SetCursorPosition(iX, 10);
            Console.Write(madLib4);
            Console.SetCursorPosition(iX, 12);
            Console.Write(madLib5);
            Console.SetCursorPosition(iX, 14);
            Console.Write(madLib6);
            Console.SetCursorPosition(iX, 16);
            Console.Write(madLib7);
            Console.SetCursorPosition(iX, 18);
            Console.Write(madLib8);
            Console.SetCursorPosition(iX, 20);
            Console.Write(madLib9);
            Console.SetCursorPosition(iX, 22);
            Console.Write(madLib10);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
