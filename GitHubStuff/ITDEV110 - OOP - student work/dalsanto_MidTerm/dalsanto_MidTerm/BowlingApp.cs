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
    class BowlingAPP
    {
        static void Main(string[] args)
        {            
            //Minimizes number of objects by only having BowlingUI class called from BowlingControl.
            BowlingControl BowlCtrl = new BowlingControl();

            //Console Setup & Introduction.
            BowlCtrl.SetupApp();

            //Passes control to Control class.
            BowlCtrl.RunApp();
            
            //Close App.
            BowlCtrl.Goodbye();
        }
    }
}
