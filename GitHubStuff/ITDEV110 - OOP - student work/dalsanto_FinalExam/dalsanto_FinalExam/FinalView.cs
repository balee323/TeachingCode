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
    class FinalView
    {
        public FinalView() { }

        public void drawQuit()
        {
            Console.Clear();
            Console.SetCursorPosition(40, 10);
            Console.Write("Are you sure you want to quit?(Y/N)");
            Console.SetCursorPosition(0, 0);
        }

        public void drawLegend()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(10, 0);
            Console.Write("Press: (I)ndividual Students / (A)ll Students / (Q)uit");
            Console.SetCursorPosition(5, 25);
            Console.Write("Use Arrow Keys to navigate.");
            Console.SetCursorPosition(5, 26);
            Console.Write("Escape Key returns user to Student Selection.");
            Console.SetCursorPosition(5, 27);
            Console.Write("Press ENTER to edit any selection.  Selecting an ID will allow you to edit Grades.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
        }

        public void drawAllStudents(int num, int studentID, string name, string grade)
        {
            int x = 0;
            int y = 0;

            if ( num <= 9 )
            {
                x = 10;
                y = num + 3;
            }
            else if ( num <= 19 )
            {
                x = 45;
                y = num - 7;
            }
            else if ( num <= 29 )
            {
                x = 80;
                y = num - 17;
            }

            Console.SetCursorPosition(x, y);
            Console.Write(studentID + " / " + name + " / " + grade);
            Console.SetCursorPosition(0, 0);
        }

        public void drawStudentNumbers(int drawPos, int cursorPos, int studentID)
        {
            int x = 0;
            int y = 0;

            if (drawPos < 10) { x = drawPos * 10; y = 2; }
            else if (drawPos < 20) { x = (drawPos - 10) * 10; y = 4; }
            else if (drawPos <= 30) { x = (drawPos - 20) * 10; y = 6; }
            x = x + 10;

            if (drawPos == cursorPos)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.SetCursorPosition(x, y);
            Console.WriteLine(studentID);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(1, 1);
            Console.Write("Student Selection" + 
                "-----------------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(1, 7);
            Console.Write("Grade Selection" +
                "-------------------------------------------------------------------------------------------------------");

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
        }

        public void drawStudentInfo(int studentID, string name, string grade, int gradeTotal, int cursorPos)
        {
            if (cursorPos == 1)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.SetCursorPosition(10, 8);
            Console.Write("ID: " + studentID);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            if (cursorPos == 2)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.SetCursorPosition(40, 8);
            Console.Write("Name: " + name);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(70, 8);
            Console.Write("Grade[" + gradeTotal + "/1000]: " + grade);
            Console.SetCursorPosition(0, 0);
        }

        public void drawStudentAssignments(int drawPos, int cursorPos, int grade, int total)
        {
            int x = 0;
            int y = 0;

            Console.SetCursorPosition(10, 10);
            Console.Write("Assignments[" + total + "/500]");

            x = 10;
            y = drawPos + 12;
            if (drawPos + 3 == cursorPos)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.SetCursorPosition(x, y);
            Console.Write("Assignment " + (drawPos + 1) + ": " + grade);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
        }

        public void drawStudentDiscussions(int drawPos, int cursorPos, int grade, int total)
        {
            int x = 0;
            int y = 0;

            Console.SetCursorPosition(40, 10);
            Console.Write("Discussions[" + total + "/100]");

            x = 40;
            y = drawPos + 12;
            if (drawPos + 13 == cursorPos)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.SetCursorPosition(x, y);
            Console.Write("Discussion " + (drawPos + 1) + ": " + grade);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
        }

        public void drawStudentExams(int drawPos, int cursorPos, int grade, int total)
        {
            int x = 0;
            int y = 0;

            Console.SetCursorPosition(70, 10);
            Console.Write("Exams[" + total + "/300]");

            x = 70;
            y = drawPos + 12;
            if (drawPos + 23 == cursorPos)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.SetCursorPosition(x, y);
            Console.Write("Exam " + (drawPos + 1) + ": " + grade);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
        }

        public void drawStudentProject(int cursorPos, int grade)
        {
            Console.SetCursorPosition(70, 16);
            Console.Write("Individual Project[" + grade + "/100]");

            if (cursorPos == 25)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.SetCursorPosition(70, 18);
            Console.Write("Individual Project: " + grade);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
        }

    }
}
