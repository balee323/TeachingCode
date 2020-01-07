using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hire_Car_Assignment
{
    class Car
    {
        public int carID;
        public string make;
        public string reg;
        public string fuel;
        public string service;
        public string comment;

        public Car(int CarID, string Make_Model, string Reg, string Fuel, string Service_Date, string Comments)
        {
            carID = CarID;
            make = Make_Model;
            reg = Reg;
            fuel = Fuel;
            service = Service_Date;
            comment = Comments;
        }
        public Car()
        {

        }
        public string getCar()
        {
            string Output = "";
            Output = string.Format("{0}, {1}, {2}, {3}, {4}, {5}", carID, make, reg, fuel, service, comment);
            return Output;
        }
        //Get Methods

        public int getCarID()
        {
            return carID;
        }
        public string getMake()
        {
            return make;
        }
        public string getReg()
        {
            return reg;
        }
        public string getFuel()
        {
            return fuel;
        }
        public string getService()
        {
            return service;
        }
        public string getComments()
        {
            return comment;
        }
        //Set Methods
        public void setCarID(int ID)
        {
            carID = ID;
        }
        public void setMake(string Make)
        {
            make = Make;
        }
        public void setReg(string Reg)
        {
            reg = Reg;
        }
        public void setFuel(string Fuel)
        {
            fuel = Fuel;
        }
        public void setServiceDate(string serviceDate)
        {
            service = serviceDate;
        }
        public void setComments(string Comments)
        {
            comment = Comments;
        }
    }
}
