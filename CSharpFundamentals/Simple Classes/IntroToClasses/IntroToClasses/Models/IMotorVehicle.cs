using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToClasses.Models
{
    interface IMotorVehicle
    {

        double MotorSize { get; set; }

        string FuelType { get; set; }

        string Color { get; set; }

        int NumOfWheels { get; set; }


        int GetSpeed();
       
    }
}
