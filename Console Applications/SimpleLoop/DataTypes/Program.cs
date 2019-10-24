using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            


            var valTypesClass = new ValueTypesClass();  //just make an instance so we can step through in debugger




            //Enum Value type (class level)
            var color1 = ValueTypesClass.ClassColors.green;

            //Enum Value Type (NameSpace level)
            var color2 = NameSpaceColors.yellow;

            //lets test some functions:
            valTypesClass.WriteClassOutColor(color1); //tests ValueTypesClass Enum member
            valTypesClass.WriteClassOutColor(color2); //test overloaded method (notice not a class enum)



            valTypesClass.WriteOutNameSpaceColor(color2); //tests NameSpace Enum member
            //you notice this won't work as the parameter passed doesn't match method signature
            //valTypesClass.WriteOutNameSpaceColor(color1); 


            //lets test the object parameter passing
            valTypesClass.WriteOutColor(color1);
            valTypesClass.WriteOutColor(color2);
            valTypesClass.WriteOutColor(ValueTypesClass.ClassColors.red);
            valTypesClass.WriteOutColor(NameSpaceColors.purple);
            valTypesClass.WriteOutColor(new object()); //blow up? Let us see!  (comment out 1st funtion, and uncomment 2nd one)









            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            Environment.Exit(0);


        }
    }
}
