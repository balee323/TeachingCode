using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexadecimalConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (RadioToBase16.Checked)
                {
                   TxtOutPut.Text = HexadecimalConvert.ConvertToHexaDecimal(int.Parse(txtInput.Text));
                }
                else
                {
                   TxtOutPut.Text = HexadecimalConvert.ConvertHexToDecimal(txtInput.Text).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          

        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.calculator.net/hex-calculator.html?d2bnumber1=97855&calctype=d2b&x=79&y=25#decimal2hex");
        }
    }
}
