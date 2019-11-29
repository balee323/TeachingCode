using System;
using System.Collections.Generic;
using System.Text;

namespace Enums
{

    //enum is part of NameSpace
    public enum NameSpaceColor
    {
        yellow = 1,
        orange = 2,
        purple = 3
    };

    public class EnumClass
    {

        public enum ClassColor
        {
            yellow = 1,
            orange = 2,
            purple = 3

        };


        private ClassColor classColorField = ClassColor.yellow;  //we manually set this.


        //methods
        /// <summary>
        /// This function displays the NameSpaceColor in the console
        /// </summary>
        /// <param name="color"></param>
        public void WriteOutNameSpaceColor(NameSpaceColor color)
        {

            Console.WriteLine("the color is: " + color.ToString());

        }


        /// <summary>
        /// This function displays the ClassColor in the console
        /// </summary>
        /// <param name="color"></param>
        public void WriteClassOutColor(ClassColor color)
        {

            Console.WriteLine("the color is: " + color.ToString());

        }

        /// <summary>
        /// This void function writes the enum color of the private field in the console.
        /// </summary>
        public void WriteClassOutColor()
        {

            Console.WriteLine("The private class color is: " + classColorField.ToString());

        }



    }
}
