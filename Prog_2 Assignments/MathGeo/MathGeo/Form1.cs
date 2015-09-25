using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGeo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = int.Parse(textBox1.Text);
            int s2 = int.Parse(textBox2.Text);
            MessageBox.Show(@"Area is: " + MathGeo.RectangleArea(s1, s2));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s1 = int.Parse(textBox1.Text);
            int s2 = int.Parse(textBox2.Text);
            MessageBox.Show(@"Perimeter is: " + MathGeo.RectanglePerimeter(s1, s2));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int r = int.Parse(textBox3.Text);
            MessageBox.Show(@"Circle area: " + MathGeo.CircleArea(r));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int r = int.Parse(textBox3.Text);
            MessageBox.Show(@"Circle perimeter: " + MathGeo.CirclePerimeter(r));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int r = int.Parse(textBox3.Text);
            int angle = int.Parse(textBox4.Text);
            MessageBox.Show(@"Circle sector area: " + MathGeo.CircleSectorArea(angle, r));
        }
    }
}
