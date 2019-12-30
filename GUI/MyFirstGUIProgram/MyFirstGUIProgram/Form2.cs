using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyFirstGUIProgram.Class1;

namespace MyFirstGUIProgram
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Class1 class1 = new Class1();

            bool showAddionalMessage = checkBox1.Checked;
            bool showOptionalMessage = checkBox2.Checked;

            //for userType
            if (checkBox3.Checked)
            {

                UserType userType = GetUserType();

                class1.EveryOnesFavoriteFuntion(textBox1.Text, int.Parse(textBox2.Text), showAddionalMessage, userType, showOptionalMessage);

            }
            else
            {
               
                if (showOptionalMessage)
                {
                    class1.EveryOnesFavoriteFuntion(textBox1.Text, int.Parse(textBox2.Text), showAddionalMessage, showOptionalMessage);

                }
                else
                {
                    class1.EveryOnesFavoriteFuntion(textBox1.Text, int.Parse(textBox2.Text), showAddionalMessage);
                }

            }


           // showAddionalMessage = false;
           // showOptionalMessage = false;




        }

        private UserType GetUserType()
        {
            if (radioButton1.Checked)
            {
                return UserType.CoolUser;
            }
            if (radioButton2.Checked)
            {
                return UserType.SuperCoolUser;
            }
            if (radioButton3.Checked)
            {
                return UserType.SuperCoolUderFromTheFuture;
            }

            return UserType.CoolUser;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            radioButton1.Text = UserType.CoolUser.ToString();
            radioButton2.Text = UserType.SuperCoolUser.ToString();
            radioButton3.Text = UserType.SuperCoolUderFromTheFuture.ToString();


        }
    }
}
