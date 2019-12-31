using System;

namespace OOP_Introduction
{
    public class Person
    {
        /// <summary>
        /// These private fields are redundant. These are here for instructional purposes. 
        /// Properties vs private fields/setters/getters.
        /// </summary>
        private string _firstName;  //global to the class
        private string _lastName;
        private Salutation _salutation;

        /// <summary>
        /// Property -- functions as field, setter funtion, and getter function.
        /// </summary>
        public Salutation Salutation
        {
            get { return _salutation; }
            set { _salutation = value; }
        }

        /// <summary>
        /// property for FirstName
        /// </summary>
        public string FirstName { get => _firstName; set => _firstName = value; }
        /// <summary>
        /// property for LastName
        /// </summary>
        public string LastName { get => _lastName; set => _lastName = value; }



        /// <summary>
        /// Default constructor, no parameters
        /// </summary>
        public Person() { }


        /// <summary>
        /// A simple parametrized constructor
        /// </summary>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        public Person(string fname, string lname)
        {
            _firstName = fname;
            _lastName = lname;

        }

        /// <summary>
        /// A simple parametrized constructor
        /// </summary>
        /// <param name="lname">last name of the person</param>
        public Person(string lname)
        {
            _lastName = lname;
        }

        /// <summary>
        /// A simple parametrized constructor
        /// </summary>
        /// <param name="salutation"></param>
        public Person(Salutation salutation)
        {
            _salutation = salutation;
        }



        /// <summary>
        /// Setter for LastName
        /// </summary>
        /// <param name="lastName"></param>
        public void SetLastName(string lastName)
        {
            _lastName = lastName;

        }

        /// <summary>
        /// Getter for LastName
        /// </summary>
        /// <returns></returns>
        public string GetLastName()
        {
            return _lastName;
        }

        /// <summary>
        /// Setter for Firstname
        /// </summary>
        /// <param name="firstName"></param>
        public void SetFirstName(string firstName)
        {
            _firstName = firstName;

        }


        /// <summary>
        /// Getter for FirstName
        /// </summary>
        /// <param name="firstName"></param>
        public string GetFirstName()
        {
            return _firstName;

        }


        /// <summary>
        /// This public Method to return the person's name
        ///   in a printable version
        /// </summary>
        /// <returns>Person's full name</returns>
        public string GetName()
        {
            var output = _firstName + " " + _lastName;
            Console.WriteLine(output);
            return output;
        }

    }
}