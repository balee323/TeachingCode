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

            Transportation fuckinThingThatMoves = new Transportation();
            Console.WriteLine("this thing is moving speed" + fuckinThingThatMoves.Speed);


            Motorcycle fingMotorBike = new Motorcycle();
            Console.WriteLine("this thing is moving speed" + fingMotorBike.Speed);
            Console.WriteLine("this thing has an engine size" + fingMotorBike.MotorSize);

            //modular, I switch out parts
            IMotorVehicle myVehicle = new Car();  //interface  //like anything else, an interface is a tool
            Console.WriteLine("this thing is moving speed" + myVehicle.GetSpeed());
            Console.WriteLine("this thing has an engine size" + myVehicle.MotorSize);

            // you use tools where they make sense... 

            //Motorcycle motorcycle = new Motorcycle();
            //int Milage = motorcycle.GetMilage();

            //motorcycle.Color = "Green";



            //IMotorVehicle motorvehicle = new Car();

            //motorvehicle.Color = "Green";
        }
    }
}
