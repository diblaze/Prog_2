using System;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
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

            dgvSuites.AutoGenerateColumns = true;
            dgvSuites.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvSuites.AutoSize = true;

            #region Default Values
            
            #endregion

        }

        /// <summary>
        ///     Initialize gender boxes.
        /// </summary>
        private void InitializeGenderBoxes()
        {
            cbFemale.CheckedChanged += GenderCheckedChanged;
            cbMale.CheckedChanged += GenderCheckedChanged;
            cbOther.CheckedChanged += GenderCheckedChanged;
        }

        /// <summary>
        ///     Makes sure only one gender box is checked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenderCheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as MetroCheckBox;

            if (checkBox?.Name == "cbFemale" && checkBox.Checked)
            {
                cbMale.Checked = false;
                cbOther.Checked = false;
            }
            else if (checkBox?.Name == "cbMale" && checkBox.Checked)
            {
                cbFemale.Checked = false;
                cbOther.Checked = false;
            }
            else if (checkBox?.Name == "cbOther" && checkBox.Checked)
            {
                cbMale.Checked = false;
                cbFemale.Checked = false;
            }
        }

        /// <summary>
        ///     Initializes the birthday boxes.
        /// </summary>
        private void InitializeBirthdayBoxes()
        {
            cmbYear.SelectedIndexChanged += AddDaysToComboBox;
            cmbMonth.SelectedIndexChanged += AddDaysToComboBox;

            for (int i = 1950; i <= DateTime.Today.Year; i++)
            {
                cmbYear.Items.Add(i.ToString());
            }

            for (int i = 1; i <= 12; i++)
            {
                cmbMonth.Items.Add(i.ToString());
            }

            cmbYear.SelectedIndex = 0;
            cmbMonth.SelectedIndex = 0;
        }

        /// <summary>
        ///     Adds the correct amount of days to the day combobox, when month and year is picked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDaysToComboBox(object sender, EventArgs e)
        {
            //do not do anything before both comboboxes are selected
            if (cmbYear.SelectedIndex == 0 || cmbMonth.SelectedIndex == 0)
            {
                return;
            }

            //clear previous items
            cmbDay.Items.Clear();

            //how many days in month?
            int daysInMonth = DateTime.DaysInMonth(Convert.ToInt32(cmbYear.Text), cmbMonth.SelectedIndex + 1);

            //add all day items
            for (int i = 1; i <= daysInMonth; i++)
            {
                cmbDay.Items.Add(i);
            }

            cmbDay.SelectedIndex = 0;
        }

        /// <summary>
        ///     Refreshes the DataGridView to show all suites.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnShowAllSuites_Click(object sender, EventArgs e)
        {
            var binding = new BindingSource {DataSource = DatabaseManager.GetAllSuites()};
            dgvSuites.DataSource = binding;
        }

        /// <summary>
        ///     Refreshes the DataGridView to show all regular suites.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnShowAllRegular_Click(object sender, EventArgs e)
        {
            var binding = new BindingSource {DataSource = DatabaseManager.GetAllRegularSuites()};
            dgvSuites.DataSource = binding;
        }

        /// <summary>
        ///     Refreshes the DataGridView to show all high-end suites.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnShowAllHighEnd_Click(object sender, EventArgs e)
        {
            var binding = new BindingSource {DataSource = DatabaseManager.GetAllHighEndSuites()};
            dgvSuites.DataSource = binding;
        }

        /// <summary>
        ///     Refreshes the DataGridView to show all luxury suites.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnShowAllLuxury_Click(object sender, EventArgs e)
        {
            var binding = new BindingSource {DataSource = DatabaseManager.GetAllLuxurySuites()};
            dgvSuites.DataSource = binding;
        }

        private void btnSearchButton_Click(object sender, EventArgs e)
        {
            //Make sure the employee has entered all information required.
            if (tabReservation.Controls.Cast<MetroTextBox>().Any(tb => tb.Text == null))
            {
                MetroMessageBox.Show(this, "Please fill in all input fields before searching for a room!");
                return;
            }

            try
            {
                DatabaseManager.GetAllAvailableSuites(cmbSuiteType.SelectedText,
                    cmbCheckInYear.SelectedText,
                    cmbCheckInMonth.SelectedText,
                    cmbCheckInDay.SelectedText,cmbAdults.SelectedText, cmbChildren.SelectedText);

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }

            
        }
    }
}