using System;
using MetroFramework.Forms;

namespace winHotelManagement
{
    public partial class FrontDesk : MetroForm
    {
        public FrontDesk()
        {
            InitializeComponent();

            InitializeBirthdayBoxes();
            InitializeGenderBoxes();
        }

        /// <summary>
        /// Initialize gender boxes.
        /// </summary>
        private void InitializeGenderBoxes()
        {
            cbFemale.CheckedChanged += GenderCheckedChanged;
            cbMale.CheckedChanged += GenderCheckedChanged;
            cbOther.CheckedChanged += GenderCheckedChanged;
        }

        /// <summary>
        /// Makes sure only one gender box is checked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenderCheckedChanged(object sender, EventArgs e)
        {
            if (cbFemale.Checked)
            {
                cbMale.Checked = false;
                cbOther.Checked = false;
            }
            else if (cbMale.Checked)
            {
                cbFemale.Checked = false;
                cbOther.Checked = false;
            }
            else if(cbOther.Checked)
            {
                cbMale.Checked = false;
                cbFemale.Checked = false;
            }
        }

        /// <summary>
        /// Initializes the birthday boxes.
        /// </summary>
        private void InitializeBirthdayBoxes()
        {
            cmbYear.SelectedIndexChanged += AddDaysToComboBox;
            cmbMonth.SelectedIndexChanged += AddDaysToComboBox;

            for (var i = 1950; i <= DateTime.Today.Year; i++)
            {
                cmbYear.Items.Add(i.ToString());
            }

            for (var i = 1; i <= 12; i++)
            {
                cmbMonth.Items.Add(i.ToString());
            }

            cmbYear.SelectedIndex = 0;
            cmbMonth.SelectedIndex = 0;
        }

        /// <summary>
        /// Adds the correct amount of days to the day combobox, when month and year is picked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDaysToComboBox(object sender, EventArgs e)
        {
            if (cmbYear.SelectedIndex == 0 || cmbMonth.SelectedIndex == 0)
            {
                return;
            }

            cmbDay.Items.Clear();

            int daysInMonth = DateTime.DaysInMonth(Convert.ToInt32(cmbYear.Text), cmbMonth.SelectedIndex + 1);

            for (var i = 1; i <= daysInMonth; i++)
            {
                cmbDay.Items.Add(i);
            }

            cmbDay.SelectedIndex = 0;
        }
    }
}