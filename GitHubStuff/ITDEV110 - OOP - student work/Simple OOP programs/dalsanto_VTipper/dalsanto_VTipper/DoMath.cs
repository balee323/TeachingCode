using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Assignment 4

namespace dalsanto_VTipper
{
    class DoMath
    {
        public DoMath() {}

        public double TipCalc (string TipOrTot, double BillTot, double TipPerc)
        {
            //Instructions called for a method to return two different values.  This cannot be done wihtout
            //a boolean toggle as a method can only ever return one value.
            double num1 = 0;

            if (TipOrTot == "tip")
            {
                num1 = BillTot * (TipPerc / 100);
            }
            if (TipOrTot == "tot")
            {
                num1 = BillTot * (TipPerc / 100) + (BillTot); 
            }

            return num1;
        }
    }
}
