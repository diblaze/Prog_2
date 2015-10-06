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
        private List<Person> _personList; 

        public Form1()
        {
            InitializeComponent();
            _personList = new List<Person>();
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

        private void btnCreatePerson_Click(object sender, EventArgs e)
        {
            if (grpPerson.Controls.Cast<TextBox>().Any(txtbox => txtbox.Text == null))
            {
                MessageBox.Show(@"Fyll in alla fält!");
            }
            Person pers = new Person(
                txtFirstName.Text, txtLastName.Text, _gender, txtSocialSecurityNumber.Text, txtCity.Text, txtAdress.Text,
                txtZipCode.Text, _citizen, txtTelephone.Text, txtEmail.Text);
            _personList.Add(pers);
        }
    }
}
