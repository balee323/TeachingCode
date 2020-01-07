using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cSHARPalaga
{
    //Updated 12/16/2017

    class calagaView
    {
        //Menu Width and Height
        int Mwidth = 60;
        int Mheight = 16;

        DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        //Toggles and Timers for Menu cursor animation
        double animStart = 0;
        double animNow = 0;
        int animTog = 0;

        public calagaView() { }

        public void menuAnim(int num)
        {
            int x = 0;
            int y = 0;
            animNow = (DateTime.UtcNow - UnixEpoch).TotalMilliseconds;
            if ((animNow - animStart) >= 400)
            {
                if (animTog == 0) { Console.ForegroundColor = ConsoleColor.Red; animTog = 1; }
                else if (animTog == 1) { Console.ForegroundColor = ConsoleColor.DarkRed; animTog = 0; }
                x = ((Console.WindowWidth - 1) / 2) - (Mwidth / 2) + 10;
                y = ((Console.WindowHeight - 1) / 2) - (Mheight / 2) + (3 * num);
                Console.SetCursorPosition(x, y);
                switch (num)
                {
                    case 1:
                        Console.Write(">");
                        break;
                    case 2:
                        Console.Write(">");
                        break;
                    case 3:
                        Console.Write(">");
                        break;
                    default:
                        break;
                }
                animStart = (DateTime.UtcNow - UnixEpoch).TotalMilliseconds;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(0, 0);
            }
        }

        public void drawIntro()
        {
            int x = 0;
            int y = 0;
            int count = 0;
            while (count < 4)
            {
                Thread.Sleep(1000);
                Console.SetCursorPosition(4, 2);
                Console.Write("     ");
                Console.SetCursorPosition(4, 2);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(" ");
                if (count > 0)
                {
                    Console.SetCursorPosition(6, 2);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(" ");
                }
                if (count > 1)
                {
                    Console.SetCursorPosition(8, 2);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(" ");
                }
                Console.BackgroundColor = ConsoleColor.Black;
                count++;
            }
            x = ((Console.WindowWidth + 1) / 2) - 12;
            y = ((Console.WindowHeight - 1) / 2) - 8;
            Console.SetCursorPosition(x, y);
            Console.Write("Maximize Your Game Window");
            x = ((Console.WindowWidth + 1) / 2) - 17;
            y = ((Console.WindowHeight - 1) / 2) - 6;
            Console.SetCursorPosition(x, y);
            Console.Write("Press Escape to Continue Minimized");

        }

        public void drawMMenu(int diff, int maxOn)
        {
            drawMenuBox();
            drawMMenuSel(1, diff, maxOn);
            Console.SetCursorPosition(0, 0);
        }

        public void drawMMenuSel(int num, int diff, int maxOn)
        {
            int x = 0;
            int y = 0;
            x = ((Console.WindowWidth - 1) / 2) - (Mwidth / 2) + 10;
            y = ((Console.WindowHeight - 1) / 2) - (Mheight / 2) + (3 * 1);
            Console.SetCursorPosition(x, y);
            Console.Write("  New Game");
            y = ((Console.WindowHeight - 1) / 2) - (Mheight / 2) + (3 * 2);
            Console.SetCursorPosition(x, y);
            Console.Write("  Difficulty");
            y = ((Console.WindowHeight - 1) / 2) - (Mheight / 2) + (3 * 3);
            Console.SetCursorPosition(x, y);
            Console.Write("  Quit");
            y = ((Console.WindowHeight - 1) / 2) - (Mheight / 2) + (3 * 4);
            Console.SetCursorPosition(x, y);
            Console.Write("Maximized: ");
            Console.ForegroundColor = ConsoleColor.Red;
            if (maxOn == 1) { Console.Write("Yes"); }
            else { Console.Write("No"); }
            Console.ForegroundColor = ConsoleColor.White;

            x = ((Console.WindowWidth - 1) / 2) - (Mwidth / 2) + 25;
            y = ((Console.WindowHeight - 1) / 2) - (Mheight / 2) + (3 * 2);
            Console.SetCursorPosition(x, y);
            Console.Write("Easy");
            x = ((Console.WindowWidth - 1) / 2) - (Mwidth / 2) + 35;
            y = ((Console.WindowHeight - 1) / 2) - (Mheight / 2) + (3 * 2);
            Console.SetCursorPosition(x, y);
            Console.Write("Moderate");
            x = ((Console.WindowWidth - 1) / 2) - (Mwidth / 2) + 45;
            y = ((Console.WindowHeight - 1) / 2) - (Mheight / 2) + (3 * 2);
            Console.SetCursorPosition(x, y);
            Console.Write("Hard");
            //Hilight
            Console.ForegroundColor = ConsoleColor.Red;
            y = ((Console.WindowHeight - 1) / 2) - (Mheight / 2) + (3 * 2);
            switch (diff)
            {
                case 1:
                    x = ((Console.WindowWidth - 1) / 2) - (Mwidth / 2) + 25;
                    Console.SetCursorPosition(x, y);
                    Console.Write("Easy");
                    break;
                case 2:
                    x = ((Console.WindowWidth - 1) / 2) - (Mwidth / 2) + 35;
                    Console.SetCursorPosition(x, y);
                    Console.Write("Moderate");
                    break;
                case 3:
                    x = ((Console.WindowWidth - 1) / 2) - (Mwidth / 2) + 45;
                    Console.SetCursorPosition(x, y);
                    Console.Write("Hard");
                    break;
                default:
                    break;
            }
            x = ((Console.WindowWidth - 1) / 2) - (Mwidth / 2) + 10;
            y = ((Console.WindowHeight - 1) / 2) - (Mheight / 2) + (3 * num);
            Console.SetCursorPosition(x, y);
            switch (num)
            {
                case 1:
                    Console.Write("> New Game");
                    break;
                case 2:
                    Console.Write("> Difficulty");
                    break;
                case 3:
                    Console.Write("> Quit");
                    break;
                default:
                    break;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
        }//end drawMMenuSel

        public void drawPMenu()
        {
            drawMenuBox();
            drawPMenuSel(1);
            Console.SetCursorPosition(0, 0);
        }

        public void drawPMenuSel(int num)
        {
            int x = 0;
            int y = 0;
            x = ((Console.WindowWidth - 1) / 2) - (Mwidth / 2) + 10;
            y = ((Console.WindowHeight - 1) / 2) - (Mheight / 2) + (3 * 1);
            Console.SetCursorPosition(x, y);
            Console.Write("  Continue");
            y = ((Console.WindowHeight - 1) / 2) - (Mheight / 2) + (3 * 2);
            Console.SetCursorPosition(x, y);
            Console.Write("  Restart");
            y = ((Console.WindowHeight - 1) / 2) - (Mheight / 2) + (3 * 3);
            Console.SetCursorPosition(x, y);
            Console.Write("  Quit");
            Console.ForegroundColor = ConsoleColor.Red;
            y = ((Console.WindowHeight - 1) / 2) - (Mheight / 2) + (3 * num);
            Console.SetCursorPosition(x, y);
            switch (num)
            {
                case 1:
                    Console.Write("> Continue");
                    break;
                case 2:
                    Console.Write("> Restart");
                    break;
                case 3:
                    Console.Write("> Quit");
                    break;
                default:
                    break;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
        }

        public void drawMenuBox()
        {
            int countx = 0;
            int county = 0;
            int x = 0;
            int y = 0;
            while (county <= Mheight)
            {
                while (countx <= Mwidth)
                {
                    x = ((Console.WindowWidth - 1) / 2) - (Mwidth / 2) + countx;
                    y = ((Console.WindowHeight - 1) / 2) - (Mheight / 2) + county;
                    if (y == ((Console.WindowHeight - 1) / 2) - (Mheight / 2) ||
                        y == ((Console.WindowHeight - 1) / 2) + (Mheight / 2) ||
                        x == ((Console.WindowWidth - 1) / 2) - (Mwidth / 2) ||
                        x == ((Console.WindowWidth - 1) / 2) + (Mwidth / 2))
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write("+");
                    }
                    else
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write(" ");
                    }
                    countx++;
                }//x
                countx = 0;
                county++;
            }//y
            Console.SetCursorPosition(0, 0);
        }

        public void drawQuit()
        {
            int x = 0;
            int y = 0;
            Console.Clear();
            drawMenuBox();
            x = ((Console.WindowWidth - 1) / 2) - 4;
            y = ((Console.WindowHeight - 1) / 2) - 4;
            Console.SetCursorPosition(x, y);
            Console.Write("Goodbye!");
            x = ((Console.WindowWidth - 1) / 2) - 10;
            y = ((Console.WindowHeight - 1) / 2) - 2;
            Console.SetCursorPosition(x, y);
            Console.Write("Press Esc to exit...");
        }

        public void drawTop(int score, int spread, int exp)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("Score:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(10, 0);
            Console.Write(score);
            if (spread == 1) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
            else if (spread > 1) { Console.ForegroundColor = ConsoleColor.Cyan; }
            else { Console.ForegroundColor = ConsoleColor.Gray; }
            Console.SetCursorPosition(15, 0);
            Console.Write("Spread");
            if (exp > 0) { Console.ForegroundColor = ConsoleColor.Yellow; }
            else { Console.ForegroundColor = ConsoleColor.Gray; }
            Console.SetCursorPosition(25, 0);
            Console.Write("Explosive Shot");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(45, 0);
            Console.Write("Press (Esc) to pause.  DO NOT resize unless you are paused.");
            Console.SetCursorPosition(0, 0);
        }

        public void drawPlayer(int x, int y)
        {
            Console.SetCursorPosition(x - 2, y - 1);
            Console.Write("  ^  ");
            Console.SetCursorPosition(x - 2, y);
            Console.Write("\\_U_/");
            Console.SetCursorPosition(x - 2, y + 1);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(" ' ' ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
        }

        public void clearPlayer(int x, int y)
        {
            Console.SetCursorPosition(x - 2, y - 1);
            Console.Write("     ");
            Console.SetCursorPosition(x - 2, y);
            Console.Write("     ");
            Console.SetCursorPosition(x - 2, y + 1);
            Console.Write("     ");
            Console.SetCursorPosition(0, 0);
        }

        public void drawEnemy(int x, int y)
        {
            Console.SetCursorPosition(x - 2, y - 1);
            Console.Write("/   \\");
            Console.SetCursorPosition(x - 2, y);
            Console.Write("|-o-|");
            Console.SetCursorPosition(x - 2, y + 1);
            Console.Write("\\   /");
            Console.SetCursorPosition(0, 0);
        }

        public void drawPUpSpread(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(x - 2, y - 1);
            Console.Write("+---+");
            Console.SetCursorPosition(x - 2, y);
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(x - 1, y);
            Console.Write("-");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(x, y);
            Console.Write("S");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(x + 1, y);
            Console.Write("-");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(x + 2, y);
            Console.Write("|");
            Console.SetCursorPosition(x - 2, y + 1);
            Console.Write("+---+");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
        }

        public void drawPUpHealth(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(x - 2, y - 1);
            Console.Write("+- -+");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x, y - 1);
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x - 2, y);
            Console.Write("-");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x - 1, y);
            Console.Write("-");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x, y);
            Console.Write("H");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x + 1, y);
            Console.Write("-");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x + 2, y);
            Console.Write("-");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(x - 2, y + 1);
            Console.Write("+- -+");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x, y + 1);
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
        }

        public void drawPUpExp(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(x - 2, y - 1);
            Console.Write("+---+");
            Console.SetCursorPosition(x - 2, y);
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(x - 1, y);
            Console.Write("-");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(x, y);
            Console.Write("E");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(x + 1, y);
            Console.Write("-");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(x + 2, y);
            Console.Write("|");
            Console.SetCursorPosition(x - 2, y + 1);
            Console.Write("+---+");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
        }

        public void clearEnemy(int x, int y)
        {
            Console.SetCursorPosition(x - 2, y - 1);
            Console.Write("     ");
            Console.SetCursorPosition(x - 2, y);
            Console.Write("     ");
            Console.SetCursorPosition(x - 2, y + 1);
            Console.Write("     ");
            Console.SetCursorPosition(0, 0);
        }

        public void drawBoom(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(x - 2, y - 2);
            Console.Write("  |  ");
            Console.SetCursorPosition(x - 2, y - 1);
            Console.Write("\\   /");
            Console.SetCursorPosition(x - 5, y);
            Console.Write("--   +   --");
            Console.SetCursorPosition(x - 2, y + 1);
            Console.Write("/   \\");
            Console.SetCursorPosition(x - 2, y + 2);
            Console.Write("  |  ");
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
        }

        public void drawProj(int x, int y, int color)
        {
            switch (color)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            Console.SetCursorPosition(x, y);
            Console.Write("+");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
        }

        public void clearProj(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
            Console.SetCursorPosition(0, 0);
        }

        public void drawColScore(int p, int e)
        {
            Console.SetCursorPosition(10, 0);
            Console.Write("Player Collisions: " + p + "  Enemy Collisions: " + e);
        }

        public void drawPlayerHealth(int num)
        {
            int count = 0;
            Console.SetCursorPosition(1, Console.WindowHeight - 1);
            Console.Write("Health : ");
            while (count <= 100)
            {
                Console.SetCursorPosition(15 + count, Console.WindowHeight - 1);
                Console.Write(" ");
                count = count + 2;
            }
            count = 0;
            Console.BackgroundColor = ConsoleColor.Red;
            while (num >= count)
            {
                Console.SetCursorPosition(15 + count, Console.WindowHeight - 1);
                Console.Write(" ");
                count = count + 2;
            }
            Console.BackgroundColor = ConsoleColor.Black;

        }

        public void drawLogoMax()
        {
            Console.SetCursorPosition(3, 1);
            Console.Write(".-.__        .-.  ___							");
            Console.SetCursorPosition(3, 2);
            Console.Write("|_|  '--.-.-(   \\/\\;;\\_ .-._______.-.                ::::::::    :::   :::        :::     :::            :::      ::::::::      :::  ");
            Console.SetCursorPosition(3, 3);
            Console.Write("(-)___     \\ \\ .-\\ \\;;\\(   \\       \\ \\             :+:    :+:   :+:   :+:      :+: :+:   :+:          :+: :+:   :+:    :+:   :+: :+: ");
            Console.SetCursorPosition(3, 4);
            Console.Write(" Y    '---._\\_((Q)) \\;;\\ .-\\     __(_)            +:+       +:+:+:+:+:+:+:+  +:+   +:+  +:+         +:+   +:+  +:+         +:+   +:+ ");
            Console.SetCursorPosition(3, 5);
            Console.Write(" I           __'-' / .--.((Q))---'    \\,         +#+          +#+   +:+    +#++:++#++: +#+        +#++:++#++: :#:        +#++:++#++: ");
            Console.SetCursorPosition(3, 6);
            Console.Write(" I     ___.-:    \\|  |   \'-'_           \\       +#+       +#+#+#+#+#+#+#+ +#+     +#+ +#+        +#+     +#+ +#+   +#+# +#+     +#+  ");
            Console.SetCursorPosition(3, 7);
            Console.Write(" A  .-'      \\ .-.\\   \\   \\ \\ '--.__     '\\    #+#    #+#   #+#   #+#    #+#     #+# #+#        #+#     #+# #+#    #+# #+#     #+#   ");
            Console.SetCursorPosition(3, 8);
            Console.Write(" |  |____.----((Q))\\   \\__|--\\_      \\     '	  ########    ###   ###    ###     ### ########## ###     ###  ########  ###     ###    ");
            Console.SetCursorPosition(3, 9);
            Console.Write("    ( )        '-'  \\_  :  \\-' '--.___\\");
            Console.SetCursorPosition(3, 10);
            Console.Write("     Y                \\  \\  \\       \\(_)");
            Console.SetCursorPosition(3, 11);
            Console.Write("     I                 \\  \\  \\         \\,");
            Console.SetCursorPosition(3, 12);
            Console.Write("     I                  \\  \\  \\          \\");
            Console.SetCursorPosition(3, 13);
            Console.Write("     A                   \\  \\  \\          '\\");
            Console.SetCursorPosition(3, 14);
            Console.Write("     |              snd   \\  \\__|           '");
            Console.SetCursorPosition(3, 15);
            Console.Write("                           \\_:.  \\");
            Console.SetCursorPosition(3, 16);
            Console.Write("                             \\ \\  \\");
            Console.SetCursorPosition(3, 17);
            Console.Write("                              \\ \\  \\");
            Console.SetCursorPosition(3, 18);
            Console.Write("                               \\_\\_|");
            Console.SetCursorPosition(0, 0);
        }

        public void drawLogoMin()
        {
            Console.SetCursorPosition(3, 1);
            Console.Write(".-.__        .-.  ___							");
            Console.SetCursorPosition(3, 2);
            Console.Write("|_|  '--.-.-(   \\/\\;;\\_ .-._______.-.");
            Console.SetCursorPosition(3, 3);
            Console.Write("(-)___     \\ \\ .-\\ \\;;\\(   \\       \\ \\");
            Console.SetCursorPosition(3, 4);
            Console.Write(" Y    '---._\\_((Q)) \\;;\\ .-\\     __(_)");
            Console.SetCursorPosition(3, 5);
            Console.Write(" I           __'-' / .--.((Q))---'     \\,");
            Console.SetCursorPosition(3, 6);
            Console.Write(" I     ___.-:    \\|  |   \'-'_            \\");
            Console.SetCursorPosition(3, 7);
            Console.Write(" A  .-'      \\ .-.\\   \\   \\ \\ '--.__     '\\");
            Console.SetCursorPosition(3, 8);
            Console.Write(" |  |____.----((Q))\\   \\__|--\\_      \\      '");
            Console.SetCursorPosition(3, 9);
            Console.Write("    ( )        '-'  \\_  :  \\-' '--.___\\");
            Console.SetCursorPosition(3, 10);
            Console.Write("     Y                \\  \\  \\       \\(_)");
            Console.SetCursorPosition(3, 11);
            Console.Write("     I                 \\  \\  \\        \\,		");
            Console.SetCursorPosition(3, 12);
            Console.Write("     I                  \\  \\  \\         \\		");
            Console.SetCursorPosition(3, 13);
            Console.Write("     A                   \\  \\  \\          '\\	");
            Console.SetCursorPosition(3, 14);
            Console.Write("     |              snd   \\  \\__|           '	");
            Console.SetCursorPosition(3, 15);
            Console.Write("                           \\_:.  \\				");
            Console.SetCursorPosition(3, 16);
            Console.Write("                             \\ \\  \\				");
            Console.SetCursorPosition(3, 17);
            Console.Write("                              \\ \\  \\			");
            Console.SetCursorPosition(3, 18);
            Console.Write("                               \\_\\_|			");
            Console.SetCursorPosition(0, 0);
        }
    }
}
