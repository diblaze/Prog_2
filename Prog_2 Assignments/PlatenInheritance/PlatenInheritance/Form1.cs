using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatenInheritance
{
    public partial class Form1 : Form
    {
        private char _gender;
        private bool _citizen;

        public Form1()
        {
            InitializeComponent();
        }

        private void GenderChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton?.Name == "radioFemale" && radioButton.Checked)
            {
                _gender = 'K';
            }
            if (radioButton?.Name == "radioMale" && radioButton.Checked)
            {
                _gender = 'M';
            }
        }

        private void CitizenChanged(object sender, EventArgs e)
        {

            RadioButton radioButton = sender as RadioButton;

            if (radioButton?.Name == "radioYes" && radioButton.Checked)
            {
                _citizen = true;
            }
            if (radioButton?.Name == "radioNo" && radioButton.Checked)
            {
                _citizen = false;
            }
        }
    }
}
