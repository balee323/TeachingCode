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

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            class1.EveryOnesFavoriteFuntion("hi", 54);
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (chk1.Checked == true)
            //{
            //    MessageBox.Show("You checked box 1");
            //}
            //else if (chk2.Checked == true)
            //{
            //    MessageBox.Show("You checked box 2");
            //}
            //else if (chk3.Checked == true)
            //{
            //    MessageBox.Show("You checked box 3");
            //}
        }


        private void btn1_Click(object sender, EventArgs e)
        {


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
            //txtResult.Text = "";

            txtResult.Clear();
            txtInput.Clear();
        }
    }
}
