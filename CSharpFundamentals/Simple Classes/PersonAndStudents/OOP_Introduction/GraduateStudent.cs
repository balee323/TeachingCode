using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Introduction
{
    /// <summary>
    /// This class both Inherits from Student class and Implements ISudentBestPractices.
    /// This class implements IStudentBestPractices Interface and is thus required to have Study() and Rest() methods.
    /// </summary>
    class GraduateStudent : Student, IStudentBestPractices
        {

            /// <summary>
            /// This is the contructor.  Notice the base part.  This is sending the base class (Student) the studentNumber parameter to 
            /// the Student constructor. 
            /// </summary>
            /// <param name="studentNumber"></param>
            public GraduateStudent(int studentNumber) : base(studentNumber) { }


            public string Study()
            {
            //var thing = _studentNumber;
            return "Completed assignments. Exam week is too close!";
            }

            public string Rest()
            {
            return "Late to bed, no time to rest";
            }
        }
}