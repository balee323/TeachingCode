using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToClasses.Models
{
    class Car : Transportation, IMotorVehicle
    {

        public double MotorSize { get; set; }

        public string FuelType { get; set; }

        public string Color { get; set; }

        public int NumOfWheels { get; set; }


        public int GetSpeed()
        {
            return base.Speed;
        }
    }
}
