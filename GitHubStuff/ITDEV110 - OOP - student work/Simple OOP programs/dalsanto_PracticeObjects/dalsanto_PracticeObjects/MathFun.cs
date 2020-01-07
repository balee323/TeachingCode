using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Assignment 5

namespace PracticeObjectsApp
{
    class MathFun
    {
        //e. Create a class named MathFun.
        //f. Create the following properties in MathFun:
        //Number1
        //Number2
        //Total
        private int number1 = 0;
        public int Number1
        {
            get
            {
                return number1;
            }
            set
            {
                number1 = value;
            }
        }
        private int number2 = 0;
        public int Number2
        {
            get
            {
                return number2;
            }
            set
            {
                number2 = value;
            }
        }
        private int total = 0;
        public int Total
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
            }
        }

        public MathFun() { }

        //g. Create a method named MultiplyThem in MathFun that multiplies two numbers and returns the product.
        public int MultiplyThem()
        {
            total = number1 * number2;
            return total;
        }

        //h. Create a method named AddThem in MathFun that adds two numbers and returns the sum.
        public int AddThem()
        {
            total = number1 + number2;
            return total;
        }
    }
}
