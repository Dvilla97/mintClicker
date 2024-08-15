using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstProject
{
    public partial class Form1 : Form
    {

        int clicks = 0;
        
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 10000; // 10 seconds
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clicks++;
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked " + clicks);
            this.Close();
        }
    }
}
