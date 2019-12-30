using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstGUIProgram
{
    public partial class CoolForm : Form
    {
        public CoolForm()
        {
            InitializeComponent();
        }
        

        //this function is not currently tied to a gui control 
        private void button1_Click(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            class1.EveryOnesFavoriteFuntion("hi", 54);
   
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            //if statements are looking for a true statement
            //if (rd1.Checked) --- becomes if(true)
            //if(rd1.Checked==true) also equates to true   --- becomes if(true)

            if (rd1.Checked)
            {
                txtResult.Text = txtInput.Text;
            }

            if (rd5.Checked)
            {
                for(int i = 0; i < 6; i++)
                {
                    txtResult.Text = txtResult.Text + txtInput.Text + Environment.NewLine;
                }               
            }

            if (rd10.Checked)
            {
                for (int i = 0; i < 11; i++)
                {
                    txtResult.Text = txtResult.Text + txtInput.Text + Environment.NewLine;
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //txtResult.Text = "";  //Clear() does same thing
            txtResult.Clear();
            txtInput.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();       
        }
    }
}
