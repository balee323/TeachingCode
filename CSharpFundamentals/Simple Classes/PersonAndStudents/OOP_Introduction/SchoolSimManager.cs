using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Introduction
{
    /// <summary>
    /// All the code that would have been in Program.cs Main() has been moved to here.  We are focusing on modularity.
    /// </summary>
    public class SchoolSimManager
    {

        private string _sectionBreak = "*********************************************************************\r\n";


        public SchoolSimManager()
        {
            Console.WriteLine("School Sim is running... \r\n");
        }


        public void RegisterStudents()
        {
            Console.WriteLine($"Showing object creation and maipulation of Salutation property.\r\n {_sectionBreak} \r\n");

            Person person = new Person("Brian", "Lee");
            person.Salutation = Salutation.Mr;

            //This is manipulating a static variable
            Console.WriteLine(person.Salutation);

            person.Salutation = Salutation.Mrs;
            Console.WriteLine(person.Salutation);

            person.Salutation = Salutation.SuperCool;
            Console.WriteLine(person.Salutation);

            Console.WriteLine(_sectionBreak + Environment.NewLine);

            Console.WriteLine("Now viewing children objects created from abstract parent class.\r\n " +
                "Also use of interface reference type. Press any key to continue.");
            Console.WriteLine(_sectionBreak);
            Console.ReadKey();


            //creating a student object using parent reference variable
            Person underGradstudent1 = new UndergraduateStudent(12345);
            //ShowAdvisor(underGradstudent1); //this is a no-go
            //notice only the Person properties and methods are avaliable

            Student underGradstudent2 = new UndergraduateStudent(11111);
            underGradstudent2.Salutation = Salutation.SuperCool;
            Console.WriteLine($"Student's full name: {underGradstudent2.Salutation} {underGradstudent2.FirstName} {underGradstudent2.LastName}");
            //GetStudentsBehavior(underGradstudent2);  //--that's a no-go, Student does not implement IStudentBestPractices
            ShowAdvisor(underGradstudent2);
            Console.WriteLine(_sectionBreak);

            UndergraduateStudent underGradstudent3 = new UndergraduateStudent(12256);
            underGradstudent3.Salutation = Salutation.SuperCool;
            Console.WriteLine($"Student's full name: {underGradstudent3.Salutation} {underGradstudent3.FirstName} {underGradstudent3.LastName}");
            //Console.WriteLine($"Student's behavior: \r\n {underGradstudent3.Study()} \r\n {underGradstudent3.Rest()}");
            GetStudentsBehavior(underGradstudent3);
            ShowAdvisor(underGradstudent3);
            Console.WriteLine(_sectionBreak);

            GraduateStudent graduateStudent1 = new GraduateStudent(5555);
            graduateStudent1.Salutation = Salutation.SuperCool;
            Console.WriteLine($"Student's full name: {graduateStudent1.Salutation} {graduateStudent1.FirstName} {graduateStudent1.LastName}");
            GetStudentsBehavior(graduateStudent1);
            ShowAdvisor(graduateStudent1);
            Console.WriteLine(_sectionBreak);


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }

        /// <summary>
        /// You can see the power of using an interface and passing an interface reference type
        /// Also this function, and the other below, are private as only the SchoolSimManager class needs to see them.
        /// </summary>
        /// <param name="studentBestPractices"></param>
        private void GetStudentsBehavior(IStudentBestPractices studentBestPractices)
        {
            Console.WriteLine($"Student's behavior: \r\n {studentBestPractices.Study()} \r\n {studentBestPractices.Rest()} \r\n");
        }

        private void ShowAdvisor(Student student)
        {
            Console.WriteLine($"Student's Advisor: {student.GetAdvisorsName()} \r\n");
        }



    }
}
