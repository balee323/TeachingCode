using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Final

namespace dalsanto_FinalExam
{
    class FinalStudent
    {
        public FinalStudent() { }

        private int[] assignments = new int[10];
        public int[] Assignments { get { return assignments; } set { assignments = value; } }
        private int assignmentsTotal = 0;
        public int AssignmentsTotal
        {
            get
            {
                assignmentsTotal = 0;
                for (int i = 0; i < assignments.Length; i++)
                {
                    assignmentsTotal = assignmentsTotal + assignments[i];
                }
                return assignmentsTotal;
            }
            set { assignmentsTotal = value; }
        }

        private int[] discussions = new int[10];
        public int[] Discussions { get { return discussions; } set { discussions = value; } }
        private int discussionsTotal = 0;
        public int DiscussionsTotal
        {
            get
            {
                discussionsTotal = 0;
                for (int i = 0; i < discussions.Length; i++)
                {
                    discussionsTotal = discussionsTotal + discussions[i];
                }
                return discussionsTotal;
            }
            set { discussionsTotal = value; }
        }

        private int[] exams = new int[2];
        public int[] Exams { get { return exams; } set { exams = value; } }
        private int examsTotal = 0;
        public int ExamsTotal
        {
            get
            {
                examsTotal = 0;
                for (int i = 0; i < exams.Length; i++)
                {
                    examsTotal = examsTotal + exams[i];
                }
                return examsTotal;
            }
            set { examsTotal = value; }
        }

        private int project = 0;
        public int Project { get { return project; } set { project = value; } }

        //GradeTotal calculates on get
        private int gradeTotal = 0;
        public int GradeTotal
        {
            get
            {
                gradeTotal = AssignmentsTotal + DiscussionsTotal + ExamsTotal + Project;
                return gradeTotal;
            }
            set { gradeTotal = value; }
        }

        //Grade calculates on get
        private string grade = "";
        public string Grade
        {
            get
            {
                double tempDouble = ((double)GradeTotal / 1000) * 100;
                if (tempDouble >= 95) { grade = "A"; }
                else if (tempDouble >= 90) { grade = "A-"; }
                else if (tempDouble >= 85) { grade = "B+"; }
                else if (tempDouble >= 80) { grade = "B"; }
                else if (tempDouble >= 75) { grade = "B-"; }
                else if (tempDouble >= 70) { grade = "C+"; }
                else if (tempDouble >= 65) { grade = "C"; }
                else if (tempDouble >= 60) { grade = "D"; }
                else { grade = "F"; }
                return grade;
            }
            set { grade = value; }
        }

        private int studentID = 0;
        public int StudentID { get { return studentID; } set { studentID = value; } }

        private string name = "none";
        public string Name { get { return name; } set { name = value; } }

    }
}
