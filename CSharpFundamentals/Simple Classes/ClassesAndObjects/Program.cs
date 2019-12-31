using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            NameSpaceColor nameSpaceColor = NameSpaceColor.purple;

            Console.WriteLine("The color you picked was: " + nameSpaceColor.ToString());

            //you don't need to create instance of object to access a public enum in the class
            var classColor = Color.ClassColor.orange;

            Color colorObj = new Color();

            //lets pick a color








        }
    }
}
