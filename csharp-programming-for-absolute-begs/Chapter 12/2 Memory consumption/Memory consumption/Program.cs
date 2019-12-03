using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_consumption
{
    class Program
    {
        static void Main(string[] args)
        {
            // Outputs
            Console.WriteLine("Whole numbers");
            Console.WriteLine("-------------");
            Console.WriteLine("byte:   " + sizeof(byte));
            Console.WriteLine("sbyte:  " + sizeof(sbyte));
            Console.WriteLine();
            Console.WriteLine("short:  " + sizeof(short));
            Console.WriteLine($"short Min and Max: {short.MinValue} to {short.MaxValue}"  );
            Console.WriteLine("ushort: " + sizeof(ushort));
            Console.WriteLine($"ushort Min and Max: {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine();
            Console.WriteLine("int:    " + sizeof(int));
            Console.WriteLine($"int Min and Max: {int.MinValue} to {int.MaxValue}");
            Console.WriteLine("uint:   " + sizeof(uint));
            Console.WriteLine($"uint Min and Max: {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine();
            Console.WriteLine("long:   " + sizeof(long));
            Console.WriteLine($"long Min and Max: {long.MinValue} to {long.MaxValue}");
            Console.WriteLine("ulong:  " + sizeof(ulong));
            Console.WriteLine($"ulong Min and Max: {ulong.MinValue} to {ulong.MaxValue}");
            Console.WriteLine();
            Console.WriteLine("Decimal numbers");
            Console.WriteLine("-----------------");
            Console.WriteLine("float:    " + sizeof(float));
            Console.WriteLine($"float Min and Max: {float.MinValue.ToString("0.#")} to {float.MaxValue.ToString("0.#")}");
            Console.WriteLine("_______");
            Console.WriteLine("double:   " + sizeof(double));
            Console.WriteLine($"double Min and Max: {double.MinValue.ToString("0.#")} to {double.MaxValue.ToString("0.#")}");
            Console.WriteLine("_______");
            Console.WriteLine("decimal:  " + sizeof(decimal));
            Console.WriteLine($"decimal Min and Max: {decimal.MinValue.ToString("0.#")} to {decimal.MaxValue.ToString("0.#")}");
            Console.WriteLine();



            //compare decimal to double

            decimal decimalNum1 = 605055.4353435554M;
            decimal decimalNum2 = 75545.4541554564M;
            var decimalVal = decimalNum1 / decimalNum2;
            Console.WriteLine($"Decimal result: {decimalVal.ToString("0.##################################################")}");


            double doubleNum1 = 605055.4353435554D;
            double doubleNum2 = 75545.4541554564D;
            var doubleVal = doubleNum1 / doubleNum2;
            Console.WriteLine($"double result: {doubleVal.ToString("0.##################################################")}");

          
            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
