using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_point
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int syc;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point k = new Point();
            Random r = new Random();
            k.X = r.Next(1, 817);
            k.Y = r.Next(1, 890);
            syc++;
            pictureBox1.Location = k;
            
            
        }
    }
}

