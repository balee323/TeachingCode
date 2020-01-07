using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Assignment 8

namespace HighLowAPP
{
    class HighLowAPP
    {
        static void Main(string[] args)
        {
            HighLowAdmin Admin = new HighLowAdmin();

            HighLowControl Control = new HighLowControl();

            Admin.HLInit();

            Control.HLRun();
        }
    }
}
