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
    class HighLowAdmin
    {
        public HighLowAdmin() { }

        HighLowView View = new HighLowView();

        int height = Console.WindowHeight;

        public void HLInit()
        {
            Console.Title = "High Low Guessing Game";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetWindowSize(110, height);
            //View.ViewSetup();
        }
    }
}
