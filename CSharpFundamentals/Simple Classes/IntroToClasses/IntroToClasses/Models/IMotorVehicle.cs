using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToClasses.Models
{
    interface IMotorVehicle
    {
        //interface is not a class, but a contract!
        //when you agree to the contract, you must build the properties/methods as stated in the contract

        double MotorSize { get; set; } //simple property, basically a definition

        string FuelType { get; set; }

        string Color { get; set; }

        int NumOfWheels { get; set; }


        int GetSpeed();  //function signature
       
    }
}
