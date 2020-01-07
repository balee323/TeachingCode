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
    class FinalControl
    {
        public FinalControl() { }

        FinalModel Model = new FinalModel();
        FinalView View = new FinalView();
        FinalSound Sound = new FinalSound();

        //30 students as per class instructions
        FinalStudent[] students = new FinalStudent[30];

        ConsoleKeyInfo key = new ConsoleKeyInfo();

        public void Core()
        {
            //initialize object array
            for(int i = 0; i < 30; i++)
            {
                students[i] = new FinalStudent();
            }

            populateStudents();
            CoreDrawAll();
            Sound.playIntro();

            while (Model.CoreOn)
            {
                //Key Input for Individual Students View
                if (Model.EditOn)
                {
                    key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            if (Model.CursorPos == 0)
                            {
                                if (Model.CursorStudent > 9)
                                {
                                    Model.CursorStudent = Model.CursorStudent - 10;
                                }
                            }
                            else if (Model.CursorPos > 0)
                            {
                                if (Model.CursorPos == 13) { Model.CursorPos = 2; }
                                else if (Model.CursorPos == 3) { Model.CursorPos = 1; }
                                else if (Model.CursorPos == 2) { Model.CursorPos = 12; }
                                else if (Model.CursorPos > 1)
                                {
                                    Model.CursorPos = Model.CursorPos - 1;
                                }
                                else { Model.CursorPos = 25; }
                            }
                            break;

                        case ConsoleKey.DownArrow:
                            if (Model.CursorPos == 0)
                            {
                                if (Model.CursorStudent < 20)
                                {
                                    Model.CursorStudent = Model.CursorStudent + 10;
                                }
                            }
                            else if (Model.CursorPos > 0)
                            {
                                if (Model.CursorPos == 1) { Model.CursorPos = 3; }
                                else if (Model.CursorPos == 2) { Model.CursorPos = 13; }
                                else if (Model.CursorPos < 25)
                                {
                                    Model.CursorPos = Model.CursorPos + 1;
                                }
                                else { Model.CursorPos = 3; }
                            }
                            break;

                        case ConsoleKey.RightArrow:
                            if (Model.CursorPos == 0)
                            {
                                if (Model.CursorStudent < 29) { Model.CursorStudent++; }
                                else { Model.CursorStudent = 0; }
                            }
                            else if (Model.CursorPos > 0)
                            {
                                if (Model.CursorPos == 1) { Model.CursorPos = 2; }
                                else if (Model.CursorPos == 13) { Model.CursorPos = 23; }
                                else if (Model.CursorPos == 14) { Model.CursorPos = 24; }
                                else if (Model.CursorPos == 19) { Model.CursorPos = 25; }
                                else if (Model.CursorPos > 2 && Model.CursorPos <= 12)
                                { Model.CursorPos = Model.CursorPos + 10; }
                            }
                            break;

                        case ConsoleKey.LeftArrow:
                            if (Model.CursorPos == 0)
                            {
                                if (Model.CursorStudent > 0) { Model.CursorStudent--; }
                                else { Model.CursorStudent = 29; }
                            }
                            else if (Model.CursorPos > 0)
                            {
                                if (Model.CursorPos == 2) { Model.CursorPos = 1; }
                                else if (Model.CursorPos == 23) { Model.CursorPos = 13; }
                                else if (Model.CursorPos == 24) { Model.CursorPos = 14; }
                                else if (Model.CursorPos == 25) { Model.CursorPos = 19; }
                                else if (Model.CursorPos > 12 && Model.CursorPos <= 23)
                                { Model.CursorPos = Model.CursorPos - 10; }
                            }
                            break;

                        case ConsoleKey.Q:
                            Model.QuitOn = true;
                            View.drawQuit();
                            break;

                        case ConsoleKey.A:
                            Model.EditOn = false;
                            CoreDrawAllStudents();
                            break;

                        case ConsoleKey.Enter:
                            if (Model.CursorPos == 0)
                            {
                                Model.CursorPos = 1;
                            }
                            else if (Model.CursorPos > 0)
                            {
                                CoreGetInput();
                            }
                            break;

                        case ConsoleKey.Escape:
                            if (Model.CursorPos > 0)
                            {
                                Model.CursorPos = 0;
                            }
                            break;

                        default:
                            break;
                    }//ReadKey Case
                }//EditOn if

                //Key Input for All Students View
                if (Model.EditOn == false && Model.QuitOn == false)
                {
                    key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.I:
                            Model.EditOn = true;
                            break;

                        case ConsoleKey.Q:
                            Model.QuitOn = true;
                            View.drawQuit();
                            break;

                        default:
                            break;
                    }
                }

                //Quit Confirm
                if (Model.QuitOn)
                {
                    key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.Y:
                            Model.CoreOn = false;
                            break;

                        case ConsoleKey.N:
                            Model.QuitOn = false;
                            break;

                        default:
                            break;
                    }
                }

                //redraw after Key input
                if (Model.QuitOn) { View.drawQuit(); }
                else if (Model.EditOn) { CoreDrawAll(); }
                else { CoreDrawAllStudents(); }

            }//CoreOn loop
        }//Core method

        public void populateStudents()
        {
            students[0].Name = "Billy Bob";
            students[2].Name = "James Dean";
            students[3].Name = "Miles Davis";
            students[16].Name = "Cathy Hart";
            students[23].Name = "Mighty Mouse";
            students[0].StudentID = 1111;
            students[2].StudentID = 2222;
            students[3].StudentID = 3333;
            students[16].StudentID = 123456789;
            students[23].StudentID = 2875458;
            students[0].Assignments[0] = 1;
            students[2].Assignments[0] = 30;
            students[3].Assignments[0] = 40;
            students[16].Assignments[0] = 50;
            students[23].Assignments[0] = 50;
            students[0].Assignments[1] = 10;
            students[2].Assignments[1] = 30;
            students[3].Assignments[1] = 40;
            students[16].Assignments[1] = 50;
            students[23].Assignments[1] = 50;
            students[0].Assignments[2] = 10;
            students[2].Assignments[2] = 30;
            students[3].Assignments[2] = 40;
            students[16].Assignments[2] = 50;
            students[23].Assignments[2] = 50;
            students[0].Assignments[3] = 10;
            students[2].Assignments[3] = 30;
            students[3].Assignments[3] = 40;
            students[16].Assignments[3] = 50;
            students[23].Assignments[3] = 50;
            students[0].Assignments[4] = 10;
            students[2].Assignments[4] = 30;
            students[3].Assignments[4] = 40;
            students[16].Assignments[4] = 50;
            students[23].Assignments[4] = 50;
            students[0].Assignments[5] = 10;
            students[2].Assignments[5] = 30;
            students[3].Assignments[5] = 40;
            students[16].Assignments[5] = 50;
            students[23].Assignments[5] = 50;
            students[0].Assignments[6] = 10;
            students[2].Assignments[6] = 30;
            students[3].Assignments[6] = 40;
            students[16].Assignments[6] = 50;
            students[23].Assignments[6] = 50;
            students[0].Assignments[7] = 10;
            students[2].Assignments[7] = 30;
            students[3].Assignments[7] = 40;
            students[16].Assignments[7] = 50;
            students[23].Assignments[7] = 50;
            students[0].Assignments[8] = 10;
            students[2].Assignments[8] = 30;
            students[3].Assignments[8] = 40;
            students[16].Assignments[8] = 50;
            students[23].Assignments[8] = 50;
            students[0].Assignments[9] = 10;
            students[2].Assignments[9] = 30;
            students[3].Assignments[9] = 40;
            students[16].Assignments[9] = 50;
            students[23].Assignments[9] = 50;
            students[0].Discussions[0] = 1;
            students[2].Discussions[0] = 3;
            students[3].Discussions[0] = 4;
            students[16].Discussions[0] = 5;
            students[23].Discussions[0] = 5;
            students[0].Discussions[1] = 1;
            students[2].Discussions[1] = 3;
            students[3].Discussions[1] = 4;
            students[16].Discussions[1] = 5;
            students[23].Discussions[1] = 5;
            students[0].Discussions[2] = 1;
            students[2].Discussions[2] = 3;
            students[3].Discussions[2] = 4;
            students[16].Discussions[2] = 5;
            students[23].Discussions[2] = 5;
            students[0].Discussions[3] = 1;
            students[2].Discussions[3] = 3;
            students[3].Discussions[3] = 4;
            students[16].Discussions[3] = 5;
            students[23].Discussions[3] = 5;
            students[0].Discussions[4] = 1;
            students[2].Discussions[4] = 3;
            students[3].Discussions[4] = 4;
            students[16].Discussions[4] = 5;
            students[23].Discussions[4] = 5;
            students[0].Discussions[5] = 1;
            students[2].Discussions[5] = 3;
            students[3].Discussions[5] = 4;
            students[16].Discussions[5] = 5;
            students[23].Discussions[5] = 5;
            students[0].Discussions[6] = 1;
            students[2].Discussions[6] = 3;
            students[3].Discussions[6] = 4;
            students[16].Discussions[6] = 5;
            students[23].Discussions[6] = 5;
            students[0].Discussions[7] = 1;
            students[2].Discussions[7] = 3;
            students[3].Discussions[7] = 4;
            students[16].Discussions[7] = 5;
            students[23].Discussions[7] = 5;
            students[0].Discussions[8] = 1;
            students[2].Discussions[8] = 3;
            students[3].Discussions[8] = 4;
            students[16].Discussions[8] = 5;
            students[23].Discussions[8] = 5;
            students[0].Discussions[9] = 1;
            students[2].Discussions[9] = 3;
            students[3].Discussions[9] = 4;
            students[16].Discussions[9] = 5;
            students[23].Discussions[9] = 5;
            students[0].Exams[0] = 100;
            students[2].Exams[0] = 130;
            students[3].Exams[0] = 140;
            students[16].Exams[0] = 150;
            students[23].Exams[0] = 150;
            students[0].Exams[1] = 100;
            students[2].Exams[1] = 130;
            students[3].Exams[1] = 140;
            students[16].Exams[1] = 150;
            students[23].Exams[1] = 150;
            students[0].Project = 10;
            students[2].Project = 30;
            students[3].Project = 40;
            students[16].Project = 50;
            students[23].Project = 50;
        }

        //All input validated.  Will not allow any values above the maximum score.
        public void CoreGetInput()
        {
            string tempString = "";
            int tempInt = 0;

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            //Student Name
            if (Model.CursorPos == 2)
            {
                Console.SetCursorPosition(40, 8);
                Console.Write("Name:                                  ");
                Console.SetCursorPosition(46, 8);
                students[Model.CursorStudent].Name = Console.ReadLine();
            }
            //Student ID
            else if (Model.CursorPos == 1)
            {
                Console.SetCursorPosition(10, 8);
                Console.Write("ID:               ");
                Console.SetCursorPosition(14, 8);
                tempString = Console.ReadLine();
                if (Int32.TryParse(tempString, out tempInt)) { tempInt = Int32.Parse(tempString); }
                students[Model.CursorStudent].StudentID = tempInt;
            }
            //Assignments
            else if (Model.CursorPos > 2 && Model.CursorPos <= 12)
            {
                Console.SetCursorPosition(10, Model.CursorPos + 9);
                Console.Write("Assignment " + (Model.CursorPos - 2) + ":    ");
                Console.SetCursorPosition(24, Model.CursorPos + 9);
                tempString = Console.ReadLine();
                if (Int32.TryParse(tempString, out tempInt)) { tempInt = Int32.Parse(tempString); }
                if (tempInt >= 0 && tempInt <= 50)
                    { students[Model.CursorStudent].Assignments[Model.CursorPos - 3] = tempInt; }
            }
            //Discussion Topics
            else if (Model.CursorPos > 12 && Model.CursorPos <= 22)
            {
                Console.SetCursorPosition(40, Model.CursorPos - 1);
                Console.Write("Discussion " + (Model.CursorPos - 12) + ":     ");
                Console.SetCursorPosition(54, Model.CursorPos - 1);
                tempString = Console.ReadLine();
                if (Int32.TryParse(tempString, out tempInt)) { tempInt = Int32.Parse(tempString); }
                if (tempInt >= 0 && tempInt <= 10)
                { students[Model.CursorStudent].Discussions[Model.CursorPos - 13] = tempInt; }
            }
            //Exams
            else if (Model.CursorPos > 22 && Model.CursorPos <= 24)
            {
                Console.SetCursorPosition(70, Model.CursorPos - 11);
                Console.Write("Exam " + (Model.CursorPos - 22) + ":     ");
                Console.SetCursorPosition(78, Model.CursorPos - 11);
                tempString = Console.ReadLine();
                if (Int32.TryParse(tempString, out tempInt)) { tempInt = Int32.Parse(tempString); }
                if (tempInt >= 0 && tempInt <= 150)
                { students[Model.CursorStudent].Exams[Model.CursorPos - 23] = tempInt; }
            }
            //Individual Project
            else if (Model.CursorPos == 25)
            {
                Console.SetCursorPosition(70, 18);
                Console.Write("Individual Project:     ");
                Console.SetCursorPosition(90, 18);
                tempString = Console.ReadLine();
                if (Int32.TryParse(tempString, out tempInt)) { tempInt = Int32.Parse(tempString); }
                if (tempInt >= 0 && tempInt <= 100)
                { students[Model.CursorStudent].Project = tempInt; }
            }
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            CoreDrawAll();
        }

        //All Students View
        public void CoreDrawAllStudents()
        {
            Console.Clear();
            for (int i = 0; i < 30; i++)
            {
                View.drawAllStudents(i, students[i].StudentID, students[i].Name, students[i].Grade);
            }
            View.drawLegend();
        }

        //all grade sections broken out to make it easier to account for code
        public void CoreDrawAll()
        {
            Console.Clear();
            View.drawLegend();
            CoreDrawStudentNumbers();
            CoreDrawStudentInfo();
            CoreDrawStudentAssignments();
            CoreDrawStudentDiscussions();
            CoreDrawStudentExams();
            CoreDrawStudentProject();
        }

        public void CoreDrawStudentNumbers()
        {
            for (int i = 0; i < 30; i++)
            {
                View.drawStudentNumbers(i, Model.CursorStudent, students[i].StudentID);
            }
        }

        public void CoreDrawStudentInfo()
        {
            View.drawStudentInfo(students[Model.CursorStudent].StudentID, 
                students[Model.CursorStudent].Name, students[Model.CursorStudent].Grade,
                students[Model.CursorStudent].GradeTotal, Model.CursorPos);
        }

        public void CoreDrawStudentAssignments()
        {
            for (int i = 0; i < 10; i++)
            {
                View.drawStudentAssignments(i, Model.CursorPos, students[Model.CursorStudent].Assignments[i],
                    students[Model.CursorStudent].AssignmentsTotal);
            }
        }

        public void CoreDrawStudentDiscussions()
        {
            for (int i = 0; i < 10; i++)
            {
                View.drawStudentDiscussions(i, Model.CursorPos, students[Model.CursorStudent].Discussions[i],
                    students[Model.CursorStudent].DiscussionsTotal);
            }
        }

        public void CoreDrawStudentExams()
        {
            for (int i = 0; i < 2; i++)
            {
                View.drawStudentExams(i, Model.CursorPos, students[Model.CursorStudent].Exams[i],
                    students[Model.CursorStudent].ExamsTotal);
            }
        }

        public void CoreDrawStudentProject()
        {
            View.drawStudentProject(Model.CursorPos, students[Model.CursorStudent].Project);
        }


    }//FinalControl class
}//namespace
