using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToClasses.Models
{
    class Transportation
    {

        //private int _speed; //private class member/variable/field  //internal mechanism of the class

        //you don't want to couple stuff too much.  cause that makes things too dependent on each other...
        // limits flexiablity 


        //public int GetSpeed()
        //{
        //    return _speed;
        //}


        //public void SetSpeed(int speed)
        //{
        //    _speed = speed;
        //}


        public int Speed {get; set;}  //property  (field, getter and setter function all in one)

        public int SeatingCapacity { get; set; }

        public decimal Cost { get; set; } 

    }
}
