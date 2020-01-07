using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSHARPalaga
{
    //Updated 12/16/2017

    class cSHARPalagaApp
    {
        //Matthew Dal Santo
        //ITDEV110
        //Final Project

        static void Main(string[] args)
        {
            //Main > Admin
            //Main > Tasks > Control
            //All other classes are accessed via Control

            Tasks TasksMain = new Tasks();

            TasksMain.RunTasks();

            
        }
    }
}
