using System;
using System.Windows.Forms;

namespace winAbstractClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stud = new Student();
            stud.Class = "TE13";
            stud.Gender = Gender.Other;

            float area1 = MathGeo.CircleArea(20.0);
            float area2 = MathGeo.CircleArea(40.0f);
        }
    }
}