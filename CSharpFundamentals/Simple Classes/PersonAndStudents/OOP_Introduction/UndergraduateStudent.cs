using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Introduction
{
    /// <summary>
    /// This class both Inherits from Student class and Implements ISudentBestPractices.
    /// This class implements IStudentBestPractices Interface and is thus required to have Study() and Rest() methods.
    /// </summary>
    class UndergraduateStudent : Student, IStudentBestPractices
        {

            /// <summary>
            /// This is the contructor.  Notice the base part.  This is sending the base class (Student) the studentNumber parameter to 
            /// the Student constructor. 
            /// </summary>
            public UndergraduateStudent(int studentNumber) : base(studentNumber) { }

      
            public string Study()
            {
                return "Great party last night. All set for the exam!";
            }

            public string Rest()
            {
                return "Great friends, great movies, great parties. Well rested";
            }
        }
}