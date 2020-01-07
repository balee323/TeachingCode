using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Final

namespace dalsanto_FinalExam
{
    class FinalApp
    {

        static void Main(string[] args)
        {
            FinalAdmin Admin = new FinalAdmin();
            FinalControl Control = new FinalControl();

            Admin.InitApp();

            Control.Core();


        }
    }
}
