using System;

namespace OOP_Introduction
{
    /// <summary>
    /// Advisor simply inherits from Person class.
    /// </summary>
    public class Advisor : Person
    {
      
        /// <summary>
        /// this constructor randomly sets the Person 
        /// </summary>
        public Advisor()
        {
            AssignRandomAdvisor();
        }

        public Advisor(Person person) { this.LastName = person.LastName; this.FirstName = person.FirstName; }


        private void AssignRandomAdvisor()
        {
            Tuple<string, string>[] persons = new Tuple<string, string>[3];
            persons[0] = new Tuple<string, string>("Stephen", "Hawking");
            persons[1] = new Tuple<string, string>("Indiana", "Jones");
            persons[2] = new Tuple<string, string>("Peter", "Griffin");

            var random = new System.Random(DateTime.Now.Millisecond);

            var tempPersonHolder = persons[random.Next(0, 2)];
            
            ///setting base class (Person) FirstName and LastName properties
            this.LastName = tempPersonHolder.Item1;
            this.FirstName = tempPersonHolder.Item2;
           
        }


    }
}