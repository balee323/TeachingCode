using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToClasses.Models
{
    class Transportation
    {

       

        //private int _speed;

        //public int GetSpeed()
        //{
        //    return _speed;
        //}

        //public void SetSpeed(int speed)
        //{

        //    _speed = speed;

        //}
        
        public int Speed { get; set; }

        public int SeatingCapacity { get; set; }

        public decimal Cost { get; set; }


    }
}
