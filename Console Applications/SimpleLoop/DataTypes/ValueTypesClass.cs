using System;
using System.Collections.Generic;
using System.Text;

namespace DataTypes
{

    //enum is part of NameSpace
    public enum NameSpaceColors
    {
        yellow = 1,
        orange = 2,
        purple = 3

    };


    class ValueTypesClass
    {

        public enum ClassColors
        {
            green = 1,
            red = 2,
            blue = 3

        };

        
        private int firstInt; //automatically set to 0
        private int secondInt = 5;


        //
        private float firstFloat; //automatically set to
        private float secondFloat = 1.0005f;
        private float thirdFloat = 1.0005F; //same as lowercase f





        //128 bit value (28 digits), so only use when you must
        private decimal firstDecimal;
        private decimal secondDecimal = 5.0m; 

        

        //methods
        
        public void WriteOutNameSpaceColor(NameSpaceColors color){

            Console.WriteLine("the color is: " + color.ToString());

        }

        public void WriteClassOutColor(ClassColors color)
        {

            Console.WriteLine("the color is: " + color.ToString());

        }

        //overloaded function

        public void WriteClassOutColor(object color)
        {
            if (color is ClassColors)
            {
                color = (ClassColors)color;
                Console.WriteLine("the color is: " + color.ToString());
            }
            else
            {
               
                Console.WriteLine("the color is not a class enum type");
            }


        }




        //public void WriteOutColor(Object genericColor)
        //{

        //    ClassColors color;
        //    NameSpaceColors nameSpaceColor;

        //    if(genericColor is ClassColors)
        //    {
        //        color = (ClassColors)genericColor;
        //        Console.WriteLine("the color is: " + color.ToString());
        //    }
        //    else
        //    {
        //        nameSpaceColor = (NameSpaceColors)genericColor;
        //        Console.WriteLine("the color is: " + nameSpaceColor.ToString());
        //    }

           

        //}


        //uncomment and comment out above funtion to use
        public void WriteOutColor(Object genericColor)
        {

            ClassColors color;
            NameSpaceColors nameSpaceColor;

            if (genericColor is ClassColors)
            {
                color = (ClassColors)genericColor;
                Console.WriteLine("the color is: " + color.ToString());
            }
            else if (genericColor is NameSpaceColors)
            {
                nameSpaceColor = (NameSpaceColors)genericColor;
                Console.WriteLine("the color is: " + nameSpaceColor.ToString());
            }
            else
            {
                Console.WriteLine("the object is not a supported enum type.");
            }



        }


    }
}
