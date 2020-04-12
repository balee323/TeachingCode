using IntroToClasses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Motorcycle motorcycle = new Motorcycle();
            int Milage = motorcycle.GetMilage();

            motorcycle.Color = "Green";



            IMotorVehicle motorvehicle = new Car();

            motorvehicle.Color = "Green";
        }
    }
}
