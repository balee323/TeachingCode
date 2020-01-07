using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstGUIProgram
{
    public class Class1
    {


        // Example overloaded functions (polymorphism)


        /// <summary>
        /// no paramter function
        /// </summary>
        public void EveryOnesFavoriteFuntion()
        {
            MessageBox.Show($"showing: Hello! and {5}");
        }


        /// <summary>
        /// 2 parameter function
        /// </summary>
        /// <param name="str"></param>
        /// <param name="num"></param>
        public void EveryOnesFavoriteFuntion(string str, int num)
        {          
            MessageBox.Show($"showing: {str} and {num}");                 
        }


        /// <summary>
        /// 3 parameter function with same name
        /// </summary>
        /// <param name="str"></param>
        /// <param name="num"></param>
        /// <param name="ShowAdditonalMessage"></param>
        public void EveryOnesFavoriteFuntion(string str, int num, bool ShowAdditonalMessage)
        {

            MessageBox.Show($"showing: {str} and {num}");

            if (ShowAdditonalMessage == true)
            {
                MessageBox.Show($"showing addional message!");
            }

        }



        //3 parameter, 1 parameter optional function with same name
        public void EveryOnesFavoriteFuntion(string str, int num, bool ShowAdditonalMessage, bool ShowOptionalMessage = false)
        {

            MessageBox.Show($"showing: {str} and {num}");

            if (ShowAdditonalMessage == true)
            {
                MessageBox.Show($"showing addional message!");
            }

            if (ShowOptionalMessage == true)
            {
                MessageBox.Show($"showing optional message!");
            }

        }


        //5 parameter function that calls other function above
        public void EveryOnesFavoriteFuntion(string str, int num, bool showAdditonalMessage, UserType userType, bool showOptionalMessage = false)
        {

            if(userType == UserType.CoolUser || userType == UserType.SuperCoolUser)
            {
                EveryOnesFavoriteFuntion(str, num, showAdditonalMessage, showOptionalMessage);
            }
            else if(userType == UserType.SuperCoolUderFromTheFuture)
            {
                SecretFunction("You are too cool to use these public methods!");
            }
           
         
        }


        private void SecretFunction(string secretMessage)
        {
            MessageBox.Show(secretMessage);
        }



        public enum UserType
        {
           CoolUser = 1,
           SuperCoolUser = 2,
           SuperCoolUderFromTheFuture = 500
        }


    }
}
