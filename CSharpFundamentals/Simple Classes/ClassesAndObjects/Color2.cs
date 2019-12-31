using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{

    //enum is part of NameSpace
    //public enum NameSpaceColor //this is already defined
    //{
    //    yellow = 1,
    //    orange = 2,
    //    purple = 3

    //};

    public class Color2
    {

        public enum ClassColor
        {
            yellow = 1,
            orange = 2,
            purple = 3

        };

        private NameSpaceColor nameSpaceColor;
        private ClassColor classColorField = ClassColor.yellow;


        //constructior 
        public Color2()
        {

        }


        public Color2(NameSpaceColor nameSpaceColor)
        {
            this.nameSpaceColor = nameSpaceColor;
        }

        public Color2(ClassColor classColor)
        {
            this.classColorField = classColor;
        }



        public void WriteOutFieldColor()
        {
            WriteOutNameSpaceColor(nameSpaceColor);

            //or could use the generic function too
            //WriteOutColor(nameSpaceColor);
        }



        //methods

        public void WriteOutNameSpaceColor(NameSpaceColor color)
        {

            Console.WriteLine("the color is: " + color.ToString());

        }


        public void WriteClassOutColor(ClassColor color)
        {

            Console.WriteLine("the color is: " + color.ToString());

        }

        public void WriteClassOutColor()
        {

            Console.WriteLine("The private class color is: " + classColorField.ToString());

        }



        //overloaded function
        public void WriteClassOutColor(object color)
        {
            if (color is ClassColor)
            {
                color = (ClassColor)color;
                Console.WriteLine("the color is: " + color.ToString());
            }
            else
            {

                Console.WriteLine("the color is not a class enum type");
            }
        }




        public void InvokePrivateMethod()
        {
        SecretPrivateMethod();
        }


        private void SecretPrivateMethod()
        {
            Console.WriteLine("SecretPrivatemethod has been called! -- indirectly that is. How sneaky of you!");
        }



        //uncomment and comment out above funtion to use
        public void WriteOutColor(Object genericColor)
        {

            ClassColor color;
            NameSpaceColor nameSpaceColor;

            if (genericColor is ClassColor)
            {
                color = (ClassColor)genericColor;
                Console.WriteLine("the color is: " + color.ToString());
            }
            else if (genericColor is NameSpaceColor)
            {
                nameSpaceColor = (NameSpaceColor)genericColor;
                Console.WriteLine("the color is: " + nameSpaceColor.ToString());
            }
            else
            {
                Console.WriteLine("the object is not a supported enum type.");
            }


        }


    }
}
