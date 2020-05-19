using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateList();
        }



        public static void CreateList()
        {

            List<int> numbers = new List<int>();

            numbers.Add(55);
            numbers.Add(60);

            bool isFifyFiveExists = numbers.Contains(55);

            int count = numbers.Count;

            numbers.Remove(60);

            count = numbers.Count;

            ;

        }


    }
}
