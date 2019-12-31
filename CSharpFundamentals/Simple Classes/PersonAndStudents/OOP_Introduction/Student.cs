using System;

namespace OOP_Introduction
{
        /// <summary>
        /// The abstract keyword keeps this class from becoming an object (not an instance class)
        /// BUT the functions are properties can be used by any children classes that inherit from this class.
        /// </summary>
        public abstract class Student : Person
        {
        private static int _studentNumber;
        private Advisor _advisor = null;


        /// <summary>
        /// Default constructor attempt 1
        /// </summary>
        public Student()
        {
            _studentNumber = 1234;
            SetFirstName("John");
            SetLastName("Doe");
            AssignAdvisor();
        }

        /// <summary>
        /// Default constructor that uses inheritance
        /// </summary>
        public Student(int studentNumber) : base("John", "Doe")
        {
            _studentNumber = studentNumber;
            AssignAdvisor();

        }


        public int StudentNumber { 
            get { return _studentNumber; } 
            set { _studentNumber = value; } 
        }


        public string GetAdvisorsName()
        {
            return _advisor.GetName();
        }


        private void AssignAdvisor()
        {
            _advisor = new Advisor();
        }

        }
}
