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
    class BesterApp
    {
        static void Main(string[] args)
        {
            BesterAdmin Admin = new BesterAdmin();
            BesterControl Control = new BesterControl();

            Admin.Init();

            Control.Game();            
        }
    }
}
