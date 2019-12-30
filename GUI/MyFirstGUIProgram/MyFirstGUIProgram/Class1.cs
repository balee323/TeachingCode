using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstGUIProgram
{
    class Class1
    {

        public void EveryOnesFavoriteFuntion(string str, int num)
        {
           
            MessageBox.Show($"showing: {str} and {num}");

                   
        }


        public void EveryOnesFavoriteFuntion(string str, int num, bool ShowAdditonalMessage)
        {

            MessageBox.Show($"showing: {str} and {num}");

            if (ShowAdditonalMessage == true)
            {
                MessageBox.Show($"showing addional message!");
            }





        }

    }
}
