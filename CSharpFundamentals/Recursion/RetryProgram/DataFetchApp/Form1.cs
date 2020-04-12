using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataFetchApp
{
    public partial class Form1 : Form
    {

        int _counter = 0;
        int _retrylimit = 100;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
          
            var data = FetchData();

            if (data != null)
            {
                var textData = data.MessageBody;
                var date = data.DataDate;

                var textToDisplay = date + Environment.NewLine + textData;
                MessageBox.Show("Tries before success: " + _counter);
                textBox1.Text = textToDisplay;
            }
            else
            {
                textBox1.Text = "Error fetching data." + Environment.NewLine +
                    "Retries has reached maxmium: " + _retrylimit;
            }

            _counter = 0;
        }



        private Data FetchData()
        {
            var data = FetchMessageData.FetchData();
            
            if (data == null && _counter < _retrylimit)
            {
                _counter++;
                System.Threading.Thread.Sleep(20);
                textBox1.Text = "retry : + " + _counter;
                textBox1.Refresh();
                data = FetchData();
            }

            return data;

        }


    }
}
