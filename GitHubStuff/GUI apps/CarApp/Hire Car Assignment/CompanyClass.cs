using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hire_Car_Assignment
{
    class Company
    {
        public int IDnum;
        public string Name;
        public string address;
        public string postcode;
        public int numCars;
        public ArrayList theirCars;
        
        public Company(int ID, string name, string Address, string Postcode, int Number_Of_Cars, ArrayList getTheirCars)
        {
            IDnum = ID;
            Name = name;
            address = Address;
            postcode = Postcode;
            numCars = Number_Of_Cars;//Input Number
            theirCars = getTheirCars; //Array
            
        }
        public Company()
        {

        }
        public string compsearch()
        {
            string output = string.Format("{0} {1} {2} {3}", IDnum, Name, address, postcode);
            return output;

        }
        public string getCompany()
        {
            string Output = string.Format("Name: {0}, Address: {1}, Postcode: {2}, Has {3} amount of cars", Name, address, postcode, numCars);
            return Output;
        }
        public int getID()
        {
           return IDnum;            
        }
        public string getCompanyName()
        {
                return Name;
        }
        public string getAddress()
        {
            return address;
        }
        public string getPostcode()
        {
            return postcode;
        }
        public int getCarNumbers()
        {
            return numCars;
        }
        public ArrayList getCars()
        {
            return theirCars;
        }
        //Set Methods
        public void setID(int ID)
        {
            IDnum = ID;
        }
        public void setCompanyName(string CompanyName)
        {
            Name = CompanyName;
        }
        public void setAddress(string CompanyAddress)
        {
            address = CompanyAddress;
        }
        public void setPostcode(string Postcode)
        {
            postcode = Postcode;
        }
        public void setNumCars(int NumbCars)
        {
            numCars = NumbCars;
        }
        public void setCars(ArrayList CompanyCarList)
        {
            theirCars = CompanyCarList;
        }
    }
}
