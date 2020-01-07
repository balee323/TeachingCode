using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Assignment 3

namespace TipperApp
{
    class TipCalc
    {
        //I don't want anything in the constructor as I'm calling the class later.
        public TipCalc() { }

        //Super simple method for calculating tip amount.  Returns said amount.
        public double GetTip(double BillTotal)
        {
            double Tip;

            Tip = BillTotal * 0.15;
            return Tip;
        }//end GetTip
    }//end TipCalc
}//end namespace
