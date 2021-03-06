﻿using System;
using System.Collections.Generic;
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
            InitializeDateBoxes();
            InitializeStateBox();

            #region Init Data Grid Views

            dgvSuites.AutoGenerateColumns = true;
            dgvSuites.AllowUserToAddRows = false;
            dgvSuites.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvSuites.AutoSize = true;
            dgvSuites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvSuitesToBook.AutoGenerateColumns = true;
            dgvSuitesToBook.AllowUserToAddRows = false;
            dgvSuitesToBook.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvSuitesToBook.AutoSize = true;
            dgvSuitesToBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvBooks.AutoGenerateColumns = true;
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvBooks.AutoSize = true;
            dgvBooks.AllowUserToDeleteRows = true;
            dgvBooks.MultiSelect = false;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.ScrollBars = ScrollBars.Both;

            #endregion

            #region Default Indexes

            cmbStates.SelectedIndex = 0;
            cmbSuiteType.SelectedIndex = 0;
            cmbAmountOfDays.SelectedIndex = 0;
            cmbAdults.SelectedIndex = 0;
            cmbChildren.SelectedIndex = 0;

            #endregion

            //Init Data Grid View for Books.
            dgvBooks.DataSource = DatabaseManager.GetAllBooked();
        }

        /// <summary>
        ///     Initializes the state box.
        /// </summary>
        private void InitializeStateBox()
        {
            object[] states =
            {
                "State",
                "Blekinge",
                "Dalarna",
                "Gotland",
                "Gävleborg",
                "Halland",
                "Jämtland",
                "Jönköping",
                "Kalmar",
                "Kronoberg",
                "Norrbotten",
                "Skåne",
                "Stockholm",
                "Södermanland",
                "Uppsala",
                "Värmland",
                "Västerbotten",
                "Västernorrlands",
                "Västmanland",
                "Västra Götaland",
                "Örebro",
                "Östergötlands"
            };

            cmbStates.Items.AddRange(states);
        }

        /// <summary>
        ///     Initializes the date boxes.
        /// </summary>
        private void InitializeDateBoxes()
        {
            int currentMonth = DateTime.Today.Month;

            cmbCheckInYear.Items.Add("Year");
            cmbCheckInYear.Items.Add(DateTime.Today.Year.ToString());

            cmbCheckInMonth.Items.Add("Month");

            for (int i = currentMonth; i <= 12; i++)
            {
                cmbCheckInMonth.Items.Add(i.ToString());
            }

            cmbCheckInYear.SelectedIndexChanged += AddCheckInDaysToComboBox;
            cmbCheckInMonth.SelectedIndexChanged += AddCheckInDaysToComboBox;

            cmbCheckInYear.SelectedIndex = 0;
            cmbCheckInMonth.SelectedIndex = 0;
        }

        /// <summary>
        ///     Adds the check in days to ComboBox.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void AddCheckInDaysToComboBox(object sender, EventArgs e)
        {
            //do not do anything before both comboboxes are selected
            if (cmbCheckInYear.SelectedIndex == 0 || cmbCheckInMonth.SelectedIndex == 0)
            {
                return;
            }

            //clear previous items
            cmbCheckInDay.Items.Clear();

            //how many days in month?
            int daysInMonth = DateTime.DaysInMonth(Convert.ToInt32(cmbCheckInYear.Text), cmbMonth.SelectedIndex + 1);

            if (DateTime.Today.Month == Convert.ToInt32(cmbCheckInMonth.SelectedItem.ToString()))
            {
                //current day
                int day = DateTime.Today.Day;

                //add all day items
                for (int i = day; i <= daysInMonth; i++)
                {
                    cmbCheckInDay.Items.Add(i);
                }
            }
            else
            {
                //add all day items
                for (int i = 1; i <= daysInMonth; i++)
                {
                    cmbCheckInDay.Items.Add(i);
                }
            }

            cmbCheckInDay.SelectedIndex = 0;
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

            cmbYear.Items.Add("Year");

            for (int i = 1950; i <= DateTime.Today.Year; i++)
            {
                cmbYear.Items.Add(i.ToString());
            }

            cmbMonth.Items.Add("Month");

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

            cmbDay.Items.Add("Day");

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

        /// <summary>
        ///     Shows all suites available.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnSearchButton_Click(object sender, EventArgs e)
        {
            if (MakeSureAllInputted())
            {
                return;
            }

            //extract values needed
            string suiteType = cmbSuiteType.SelectedItem.ToString();
            string checkInDate = $"{cmbCheckInYear.SelectedItem}-{cmbCheckInMonth.SelectedItem}-{cmbCheckInDay.SelectedItem}";
            string adults = cmbAdults.SelectedItem.ToString();
            string children = cmbChildren.SelectedItem.ToString();
            string daysToStay = cmbAmountOfDays.SelectedItem.ToString();

            //list to hold all suites
            IEnumerable<Suite> suitesAvailable = null;

            try
            {
                //reach out to database and get all suites available.
                suitesAvailable = DatabaseManager.GetAllAvailableSuites(suiteType,
                    checkInDate,
                    adults,
                    children,
                    daysToStay);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }

            //if suites are found, show them.
            if (suitesAvailable != null)
            {
                dgvSuitesToBook.DataSource = suitesAvailable;
            }
            //if no suites are foun, show error.
            else
            {
                MetroMessageBox.Show(this, $"No {suiteType} found. Try different date.");
            }
        }

        /// <summary>
        ///     Makes sure all input fields are inputted.
        /// </summary>
        /// <returns><c>True</c> if user missed an field - otherwise <c>false</c> </returns>
        private bool MakeSureAllInputted()
        {
            if (tbCity.Text == null || tbEmail.Text == null || tbStreet.Text == null || tbTelephone.Text == null ||
                tbZipCode.Text == null || tbFirstname.Text == null || tbSurname.Text == null)
            {
                MetroMessageBox.Show(this, "Please fill in all input fields before searching for a room!");
                return true;
            }

            if (cmbYear.SelectedIndex == 0 || cmbMonth.SelectedIndex == 0 || cmbDay.SelectedIndex == 0)
            {
                MetroMessageBox.Show(this, "Please fill in the customers birthday!");
                return true;
            }

            if (cmbStates.SelectedIndex == 0)
            {
                MetroMessageBox.Show(this, "Please select a state!");
                return true;
            }

            if (cmbSuiteType.SelectedIndex == 0)
            {
                MetroMessageBox.Show(this, "Please select a suite type!");
                return true;
            }

            if (cmbCheckInYear.SelectedIndex == 0 || cmbCheckInMonth.SelectedIndex == 0 || cmbCheckInDay.SelectedIndex == 0)
            {
                MetroMessageBox.Show(this, "Please select a check in date!");
                return true;
            }
            return false;
        }

        /// <summary>
        ///     Books a suite.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnBook_Click(object sender, EventArgs e)
        {
            if (dgvSuitesToBook.SelectedRows.Count != 1)
            {
                MetroMessageBox.Show(this,
                    "You have either selected too many rows, or none at all! Press on the row selecter on the left side of the row you want to book!");
                return;
            }

            var tempSuite = dgvSuitesToBook.SelectedRows[0].DataBoundItem as Suite;

            #region Customer info

            string checkInDate = $"{cmbCheckInYear.SelectedItem}-{cmbCheckInMonth.SelectedItem}-{cmbCheckInDay.SelectedItem}";
            string daysToStay = cmbAmountOfDays.SelectedItem.ToString();
            string fullName = tbFirstname.Text + " " + tbSurname.Text;
            string gender = "";

            if (cbMale.Checked)
            {
                gender = "Male";
            }
            else if (cbFemale.Checked)

            {
                gender = "Female";
            }
            else if (cbOther.Checked)
            {
                gender = "Other";
            }

            string telephone = tbTelephone.Text;
            string email = tbEmail.Text;
            string adress = tbStreet.Text;
            string city = tbCity.Text;
            string state = cmbStates.SelectedText;
            string zipcode = tbZipCode.Text;
            bool breakfast = cbBreakfast.Checked;

            #endregion

            if (tempSuite != null)
            {

                if (DatabaseManager.BookSuite(tempSuite,
                    checkInDate,
                    daysToStay,
                    fullName,
                    gender,
                    telephone,
                    email,
                    adress,
                    city,
                    state,
                    zipcode,
                    breakfast))
                {
                    MetroMessageBox.Show(this,
                        $"You have sucessfully booked suite {tempSuite.SuiteNumber} for customer {fullName}. Press OK to open the receipt!");

                    Receipt.CreateReceipt(tempSuite.SuiteNumber, checkInDate, fullName);


                }
                else
                {
                    MetroMessageBox.Show(this, $"Something went horrificly bad trying to book suite {tempSuite.SuiteNumber} for customer {fullName}. Try again!");
                    
                }

                


            }
        }

        /// <summary>
        ///     Handles the UserDeletingRow event of the dgvBooks control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewRowCancelEventArgs" /> instance containing the event data.</param>
        private void dgvBooks_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridViewRow row = dgvBooks.SelectedRows[0];

            int idToDelete = Convert.ToInt32(row.Cells[0].Value.ToString());

            DatabaseManager.DeleteSuite(idToDelete);
        }

        /// <summary>
        ///     Refreshes the data grid view of bookings.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvBooks.DataSource = DatabaseManager.GetAllBooked();
            dgvBooks.Refresh();
        }
    }
}