using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.DoubleBuffered = true; // to reduce/prevent flickering
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Pen pen = new Pen(Color.Black);

            graphics.DrawLine(pen, 0, 0, 500, 500);
        }
    }
}
