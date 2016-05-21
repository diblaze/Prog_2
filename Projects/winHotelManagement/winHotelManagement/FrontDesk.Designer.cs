using System.Drawing;
using MetroFramework;

namespace winHotelManagement
{
    partial class FrontDesk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControls = new MetroFramework.Controls.MetroTabControl();
            this.tabReservation = new MetroFramework.Controls.MetroTabPage();
            this.pnlReservationRight = new MetroFramework.Controls.MetroPanel();
            this.dgvSuitesToBook = new System.Windows.Forms.DataGridView();
            this.btnBook = new MetroFramework.Controls.MetroButton();
            this.pnlReservationMiddle = new MetroFramework.Controls.MetroPanel();
            this.lblChildren = new MetroFramework.Controls.MetroLabel();
            this.lblAdults = new MetroFramework.Controls.MetroLabel();
            this.cmbChildren = new MetroFramework.Controls.MetroComboBox();
            this.cmbAdults = new MetroFramework.Controls.MetroComboBox();
            this.btnSearchButton = new MetroFramework.Controls.MetroButton();
            this.cbBreakfast = new MetroFramework.Controls.MetroCheckBox();
            this.cmbAmountOfDays = new MetroFramework.Controls.MetroComboBox();
            this.lblCheckOut = new MetroFramework.Controls.MetroLabel();
            this.cmbCheckInDay = new MetroFramework.Controls.MetroComboBox();
            this.cmbCheckInMonth = new MetroFramework.Controls.MetroComboBox();
            this.cmbCheckInYear = new MetroFramework.Controls.MetroComboBox();
            this.lblCheckIn = new MetroFramework.Controls.MetroLabel();
            this.cmbSuiteType = new MetroFramework.Controls.MetroComboBox();
            this.lblSuiteType = new MetroFramework.Controls.MetroLabel();
            this.panelReservationLeft = new MetroFramework.Controls.MetroPanel();
            this.tbZipCode = new MetroFramework.Controls.MetroTextBox();
            this.labelZipCode = new MetroFramework.Controls.MetroLabel();
            this.cmbStates = new MetroFramework.Controls.MetroComboBox();
            this.labelState = new MetroFramework.Controls.MetroLabel();
            this.tbCity = new MetroFramework.Controls.MetroTextBox();
            this.labelCity = new MetroFramework.Controls.MetroLabel();
            this.tbStreet = new MetroFramework.Controls.MetroTextBox();
            this.labelAddress = new MetroFramework.Controls.MetroLabel();
            this.tbEmail = new MetroFramework.Controls.MetroTextBox();
            this.labelEmail = new MetroFramework.Controls.MetroLabel();
            this.tbTelephone = new MetroFramework.Controls.MetroTextBox();
            this.labelTelephone = new MetroFramework.Controls.MetroLabel();
            this.cbOther = new MetroFramework.Controls.MetroCheckBox();
            this.cbFemale = new MetroFramework.Controls.MetroCheckBox();
            this.cbMale = new MetroFramework.Controls.MetroCheckBox();
            this.labelGender = new MetroFramework.Controls.MetroLabel();
            this.cmbDay = new MetroFramework.Controls.MetroComboBox();
            this.cmbMonth = new MetroFramework.Controls.MetroComboBox();
            this.cmbYear = new MetroFramework.Controls.MetroComboBox();
            this.labelBirthday = new MetroFramework.Controls.MetroLabel();
            this.tbSurname = new MetroFramework.Controls.MetroTextBox();
            this.tbFirstname = new MetroFramework.Controls.MetroTextBox();
            this.labelReservationName = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.pnl = new MetroFramework.Controls.MetroPanel();
            this.btnShowAllLuxury = new System.Windows.Forms.Button();
            this.btnShowAllRegular = new System.Windows.Forms.Button();
            this.BtnShowAllHighEnd = new System.Windows.Forms.Button();
            this.btnShowAllSuites = new System.Windows.Forms.Button();
            this.dgvSuites = new System.Windows.Forms.DataGridView();
            this.tabControls.SuspendLayout();
            this.tabReservation.SuspendLayout();
            this.pnlReservationRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuitesToBook)).BeginInit();
            this.pnlReservationMiddle.SuspendLayout();
            this.panelReservationLeft.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuites)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControls
            // 
            this.tabControls.Controls.Add(this.tabReservation);
            this.tabControls.Controls.Add(this.metroTabPage2);
            this.tabControls.Controls.Add(this.metroTabPage3);
            this.tabControls.Location = new System.Drawing.Point(24, 74);
            this.tabControls.Name = "tabControls";
            this.tabControls.SelectedIndex = 1;
            this.tabControls.Size = new System.Drawing.Size(1041, 605);
            this.tabControls.TabIndex = 0;
            this.tabControls.UseSelectable = true;
            // 
            // tabReservation
            // 
            this.tabReservation.Controls.Add(this.pnlReservationRight);
            this.tabReservation.Controls.Add(this.pnlReservationMiddle);
            this.tabReservation.Controls.Add(this.panelReservationLeft);
            this.tabReservation.HorizontalScrollbarBarColor = true;
            this.tabReservation.HorizontalScrollbarHighlightOnWheel = false;
            this.tabReservation.HorizontalScrollbarSize = 10;
            this.tabReservation.Location = new System.Drawing.Point(4, 39);
            this.tabReservation.Name = "tabReservation";
            this.tabReservation.Size = new System.Drawing.Size(1033, 562);
            this.tabReservation.TabIndex = 0;
            this.tabReservation.Text = "Reservation";
            this.tabReservation.VerticalScrollbarBarColor = true;
            this.tabReservation.VerticalScrollbarHighlightOnWheel = false;
            this.tabReservation.VerticalScrollbarSize = 10;
            // 
            // pnlReservationRight
            // 
            this.pnlReservationRight.BackColor = System.Drawing.Color.LightBlue;
            this.pnlReservationRight.Controls.Add(this.dgvSuitesToBook);
            this.pnlReservationRight.Controls.Add(this.btnBook);
            this.pnlReservationRight.HorizontalScrollbarBarColor = true;
            this.pnlReservationRight.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlReservationRight.HorizontalScrollbarSize = 10;
            this.pnlReservationRight.Location = new System.Drawing.Point(740, 19);
            this.pnlReservationRight.Name = "pnlReservationRight";
            this.pnlReservationRight.Size = new System.Drawing.Size(293, 433);
            this.pnlReservationRight.TabIndex = 4;
            this.pnlReservationRight.UseCustomBackColor = true;
            this.pnlReservationRight.VerticalScrollbarBarColor = true;
            this.pnlReservationRight.VerticalScrollbarHighlightOnWheel = false;
            this.pnlReservationRight.VerticalScrollbarSize = 10;
            // 
            // dgvSuitesToBook
            // 
            this.dgvSuitesToBook.AllowUserToAddRows = false;
            this.dgvSuitesToBook.AllowUserToDeleteRows = false;
            this.dgvSuitesToBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuitesToBook.Location = new System.Drawing.Point(3, 3);
            this.dgvSuitesToBook.Name = "dgvSuitesToBook";
            this.dgvSuitesToBook.ReadOnly = true;
            this.dgvSuitesToBook.Size = new System.Drawing.Size(287, 386);
            this.dgvSuitesToBook.TabIndex = 4;
            // 
            // btnBook
            // 
            this.btnBook.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnBook.Location = new System.Drawing.Point(105, 395);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 23);
            this.btnBook.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnBook.TabIndex = 3;
            this.btnBook.Text = "Book";
            this.btnBook.UseSelectable = true;
            this.btnBook.UseStyleColors = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // pnlReservationMiddle
            // 
            this.pnlReservationMiddle.BackColor = System.Drawing.Color.LightBlue;
            this.pnlReservationMiddle.Controls.Add(this.lblChildren);
            this.pnlReservationMiddle.Controls.Add(this.lblAdults);
            this.pnlReservationMiddle.Controls.Add(this.cmbChildren);
            this.pnlReservationMiddle.Controls.Add(this.cmbAdults);
            this.pnlReservationMiddle.Controls.Add(this.btnSearchButton);
            this.pnlReservationMiddle.Controls.Add(this.cbBreakfast);
            this.pnlReservationMiddle.Controls.Add(this.cmbAmountOfDays);
            this.pnlReservationMiddle.Controls.Add(this.lblCheckOut);
            this.pnlReservationMiddle.Controls.Add(this.cmbCheckInDay);
            this.pnlReservationMiddle.Controls.Add(this.cmbCheckInMonth);
            this.pnlReservationMiddle.Controls.Add(this.cmbCheckInYear);
            this.pnlReservationMiddle.Controls.Add(this.lblCheckIn);
            this.pnlReservationMiddle.Controls.Add(this.cmbSuiteType);
            this.pnlReservationMiddle.Controls.Add(this.lblSuiteType);
            this.pnlReservationMiddle.HorizontalScrollbarBarColor = true;
            this.pnlReservationMiddle.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlReservationMiddle.HorizontalScrollbarSize = 10;
            this.pnlReservationMiddle.Location = new System.Drawing.Point(366, 19);
            this.pnlReservationMiddle.Name = "pnlReservationMiddle";
            this.pnlReservationMiddle.Size = new System.Drawing.Size(293, 433);
            this.pnlReservationMiddle.TabIndex = 3;
            this.pnlReservationMiddle.UseCustomBackColor = true;
            this.pnlReservationMiddle.VerticalScrollbarBarColor = true;
            this.pnlReservationMiddle.VerticalScrollbarHighlightOnWheel = false;
            this.pnlReservationMiddle.VerticalScrollbarSize = 10;
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.BackColor = System.Drawing.Color.LightBlue;
            this.lblChildren.Location = new System.Drawing.Point(184, 126);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(58, 19);
            this.lblChildren.TabIndex = 20;
            this.lblChildren.Text = "Children";
            this.lblChildren.UseCustomBackColor = true;
            // 
            // lblAdults
            // 
            this.lblAdults.AutoSize = true;
            this.lblAdults.BackColor = System.Drawing.Color.LightBlue;
            this.lblAdults.Location = new System.Drawing.Point(114, 126);
            this.lblAdults.Name = "lblAdults";
            this.lblAdults.Size = new System.Drawing.Size(45, 19);
            this.lblAdults.TabIndex = 19;
            this.lblAdults.Text = "Adults";
            this.lblAdults.UseCustomBackColor = true;
            // 
            // cmbChildren
            // 
            this.cmbChildren.FormattingEnabled = true;
            this.cmbChildren.ItemHeight = 23;
            this.cmbChildren.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cmbChildren.Location = new System.Drawing.Point(184, 148);
            this.cmbChildren.Name = "cmbChildren";
            this.cmbChildren.Size = new System.Drawing.Size(64, 29);
            this.cmbChildren.TabIndex = 18;
            this.cmbChildren.UseSelectable = true;
            // 
            // cmbAdults
            // 
            this.cmbAdults.FormattingEnabled = true;
            this.cmbAdults.ItemHeight = 23;
            this.cmbAdults.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbAdults.Location = new System.Drawing.Point(114, 148);
            this.cmbAdults.Name = "cmbAdults";
            this.cmbAdults.Size = new System.Drawing.Size(64, 29);
            this.cmbAdults.TabIndex = 17;
            this.cmbAdults.UseSelectable = true;
            // 
            // btnSearchButton
            // 
            this.btnSearchButton.BackColor = System.Drawing.Color.White;
            this.btnSearchButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSearchButton.Location = new System.Drawing.Point(73, 220);
            this.btnSearchButton.Name = "btnSearchButton";
            this.btnSearchButton.Size = new System.Drawing.Size(144, 23);
            this.btnSearchButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnSearchButton.TabIndex = 16;
            this.btnSearchButton.Text = "Search for rooms";
            this.btnSearchButton.UseCustomBackColor = true;
            this.btnSearchButton.UseSelectable = true;
            this.btnSearchButton.UseStyleColors = true;
            this.btnSearchButton.Click += new System.EventHandler(this.btnSearchButton_Click);
            // 
            // cbBreakfast
            // 
            this.cbBreakfast.AutoSize = true;
            this.cbBreakfast.BackColor = System.Drawing.Color.LightBlue;
            this.cbBreakfast.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.cbBreakfast.Location = new System.Drawing.Point(165, 30);
            this.cbBreakfast.Name = "cbBreakfast";
            this.cbBreakfast.Size = new System.Drawing.Size(100, 25);
            this.cbBreakfast.Style = MetroFramework.MetroColorStyle.Orange;
            this.cbBreakfast.TabIndex = 15;
            this.cbBreakfast.Text = "Breakfast";
            this.cbBreakfast.UseCustomBackColor = true;
            this.cbBreakfast.UseCustomForeColor = true;
            this.cbBreakfast.UseSelectable = true;
            this.cbBreakfast.UseStyleColors = true;
            // 
            // cmbAmountOfDays
            // 
            this.cmbAmountOfDays.FormattingEnabled = true;
            this.cmbAmountOfDays.ItemHeight = 23;
            this.cmbAmountOfDays.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbAmountOfDays.Location = new System.Drawing.Point(20, 148);
            this.cmbAmountOfDays.Name = "cmbAmountOfDays";
            this.cmbAmountOfDays.PromptText = "Days";
            this.cmbAmountOfDays.Size = new System.Drawing.Size(88, 29);
            this.cmbAmountOfDays.TabIndex = 13;
            this.cmbAmountOfDays.UseSelectable = true;
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.BackColor = System.Drawing.Color.LightBlue;
            this.lblCheckOut.Location = new System.Drawing.Point(20, 126);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(81, 19);
            this.lblCheckOut.TabIndex = 12;
            this.lblCheckOut.Text = "Days To Stay";
            this.lblCheckOut.UseCustomBackColor = true;
            // 
            // cmbCheckInDay
            // 
            this.cmbCheckInDay.FormattingEnabled = true;
            this.cmbCheckInDay.ItemHeight = 23;
            this.cmbCheckInDay.Location = new System.Drawing.Point(213, 86);
            this.cmbCheckInDay.Name = "cmbCheckInDay";
            this.cmbCheckInDay.PromptText = "Day";
            this.cmbCheckInDay.Size = new System.Drawing.Size(65, 29);
            this.cmbCheckInDay.TabIndex = 11;
            this.cmbCheckInDay.UseSelectable = true;
            // 
            // cmbCheckInMonth
            // 
            this.cmbCheckInMonth.FormattingEnabled = true;
            this.cmbCheckInMonth.ItemHeight = 23;
            this.cmbCheckInMonth.Location = new System.Drawing.Point(114, 86);
            this.cmbCheckInMonth.Name = "cmbCheckInMonth";
            this.cmbCheckInMonth.PromptText = "Month";
            this.cmbCheckInMonth.Size = new System.Drawing.Size(93, 29);
            this.cmbCheckInMonth.TabIndex = 10;
            this.cmbCheckInMonth.UseSelectable = true;
            // 
            // cmbCheckInYear
            // 
            this.cmbCheckInYear.FormattingEnabled = true;
            this.cmbCheckInYear.ItemHeight = 23;
            this.cmbCheckInYear.Location = new System.Drawing.Point(20, 86);
            this.cmbCheckInYear.Name = "cmbCheckInYear";
            this.cmbCheckInYear.PromptText = "Year";
            this.cmbCheckInYear.Size = new System.Drawing.Size(88, 29);
            this.cmbCheckInYear.TabIndex = 9;
            this.cmbCheckInYear.UseSelectable = true;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.BackColor = System.Drawing.Color.LightBlue;
            this.lblCheckIn.Location = new System.Drawing.Point(20, 64);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(58, 19);
            this.lblCheckIn.TabIndex = 6;
            this.lblCheckIn.Text = "Check In";
            this.lblCheckIn.UseCustomBackColor = true;
            // 
            // cmbSuiteType
            // 
            this.cmbSuiteType.FormattingEnabled = true;
            this.cmbSuiteType.ItemHeight = 23;
            this.cmbSuiteType.Items.AddRange(new object[] {
            "Suite Type",
            "Regular",
            "High-End",
            "Luxury"});
            this.cmbSuiteType.Location = new System.Drawing.Point(20, 28);
            this.cmbSuiteType.Name = "cmbSuiteType";
            this.cmbSuiteType.Size = new System.Drawing.Size(122, 29);
            this.cmbSuiteType.TabIndex = 3;
            this.cmbSuiteType.UseSelectable = true;
            // 
            // lblSuiteType
            // 
            this.lblSuiteType.AutoSize = true;
            this.lblSuiteType.BackColor = System.Drawing.Color.LightBlue;
            this.lblSuiteType.Location = new System.Drawing.Point(20, 5);
            this.lblSuiteType.Name = "lblSuiteType";
            this.lblSuiteType.Size = new System.Drawing.Size(68, 19);
            this.lblSuiteType.TabIndex = 2;
            this.lblSuiteType.Text = "Suite Type";
            this.lblSuiteType.UseCustomBackColor = true;
            // 
            // panelReservationLeft
            // 
            this.panelReservationLeft.BackColor = System.Drawing.Color.LightBlue;
            this.panelReservationLeft.Controls.Add(this.tbZipCode);
            this.panelReservationLeft.Controls.Add(this.labelZipCode);
            this.panelReservationLeft.Controls.Add(this.cmbStates);
            this.panelReservationLeft.Controls.Add(this.labelState);
            this.panelReservationLeft.Controls.Add(this.tbCity);
            this.panelReservationLeft.Controls.Add(this.labelCity);
            this.panelReservationLeft.Controls.Add(this.tbStreet);
            this.panelReservationLeft.Controls.Add(this.labelAddress);
            this.panelReservationLeft.Controls.Add(this.tbEmail);
            this.panelReservationLeft.Controls.Add(this.labelEmail);
            this.panelReservationLeft.Controls.Add(this.tbTelephone);
            this.panelReservationLeft.Controls.Add(this.labelTelephone);
            this.panelReservationLeft.Controls.Add(this.cbOther);
            this.panelReservationLeft.Controls.Add(this.cbFemale);
            this.panelReservationLeft.Controls.Add(this.cbMale);
            this.panelReservationLeft.Controls.Add(this.labelGender);
            this.panelReservationLeft.Controls.Add(this.cmbDay);
            this.panelReservationLeft.Controls.Add(this.cmbMonth);
            this.panelReservationLeft.Controls.Add(this.cmbYear);
            this.panelReservationLeft.Controls.Add(this.labelBirthday);
            this.panelReservationLeft.Controls.Add(this.tbSurname);
            this.panelReservationLeft.Controls.Add(this.tbFirstname);
            this.panelReservationLeft.Controls.Add(this.labelReservationName);
            this.panelReservationLeft.HorizontalScrollbarBarColor = true;
            this.panelReservationLeft.HorizontalScrollbarHighlightOnWheel = false;
            this.panelReservationLeft.HorizontalScrollbarSize = 10;
            this.panelReservationLeft.Location = new System.Drawing.Point(3, 19);
            this.panelReservationLeft.Name = "panelReservationLeft";
            this.panelReservationLeft.Size = new System.Drawing.Size(293, 433);
            this.panelReservationLeft.TabIndex = 2;
            this.panelReservationLeft.UseCustomBackColor = true;
            this.panelReservationLeft.VerticalScrollbarBarColor = true;
            this.panelReservationLeft.VerticalScrollbarHighlightOnWheel = false;
            this.panelReservationLeft.VerticalScrollbarSize = 10;
            // 
            // tbZipCode
            // 
            // 
            // 
            // 
            this.tbZipCode.CustomButton.Image = null;
            this.tbZipCode.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.tbZipCode.CustomButton.Name = "";
            this.tbZipCode.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbZipCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbZipCode.CustomButton.TabIndex = 1;
            this.tbZipCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbZipCode.CustomButton.UseSelectable = true;
            this.tbZipCode.CustomButton.Visible = false;
            this.tbZipCode.Lines = new string[0];
            this.tbZipCode.Location = new System.Drawing.Point(141, 376);
            this.tbZipCode.MaxLength = 32767;
            this.tbZipCode.Name = "tbZipCode";
            this.tbZipCode.PasswordChar = '\0';
            this.tbZipCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbZipCode.SelectedText = "";
            this.tbZipCode.SelectionLength = 0;
            this.tbZipCode.SelectionStart = 0;
            this.tbZipCode.Size = new System.Drawing.Size(132, 29);
            this.tbZipCode.TabIndex = 24;
            this.tbZipCode.UseSelectable = true;
            this.tbZipCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbZipCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.BackColor = System.Drawing.Color.LightBlue;
            this.labelZipCode.Location = new System.Drawing.Point(143, 352);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(64, 19);
            this.labelZipCode.TabIndex = 23;
            this.labelZipCode.Text = "Zip Code";
            this.labelZipCode.UseCustomBackColor = true;
            // 
            // cmbStates
            // 
            this.cmbStates.FormattingEnabled = true;
            this.cmbStates.ItemHeight = 23;
            this.cmbStates.Location = new System.Drawing.Point(17, 376);
            this.cmbStates.Name = "cmbStates";
            this.cmbStates.Size = new System.Drawing.Size(118, 29);
            this.cmbStates.TabIndex = 22;
            this.cmbStates.UseSelectable = true;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.BackColor = System.Drawing.Color.LightBlue;
            this.labelState.Location = new System.Drawing.Point(15, 352);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(38, 19);
            this.labelState.TabIndex = 21;
            this.labelState.Text = "State";
            this.labelState.UseCustomBackColor = true;
            // 
            // tbCity
            // 
            // 
            // 
            // 
            this.tbCity.CustomButton.Image = null;
            this.tbCity.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.tbCity.CustomButton.Name = "";
            this.tbCity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbCity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCity.CustomButton.TabIndex = 1;
            this.tbCity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCity.CustomButton.UseSelectable = true;
            this.tbCity.CustomButton.Visible = false;
            this.tbCity.Lines = new string[0];
            this.tbCity.Location = new System.Drawing.Point(16, 323);
            this.tbCity.MaxLength = 32767;
            this.tbCity.Name = "tbCity";
            this.tbCity.PasswordChar = '\0';
            this.tbCity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCity.SelectedText = "";
            this.tbCity.SelectionLength = 0;
            this.tbCity.SelectionStart = 0;
            this.tbCity.Size = new System.Drawing.Size(257, 23);
            this.tbCity.TabIndex = 20;
            this.tbCity.UseSelectable = true;
            this.tbCity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.BackColor = System.Drawing.Color.LightBlue;
            this.labelCity.Location = new System.Drawing.Point(15, 301);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(31, 19);
            this.labelCity.TabIndex = 19;
            this.labelCity.Text = "City";
            this.labelCity.UseCustomBackColor = true;
            // 
            // tbStreet
            // 
            // 
            // 
            // 
            this.tbStreet.CustomButton.Image = null;
            this.tbStreet.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.tbStreet.CustomButton.Name = "";
            this.tbStreet.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbStreet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbStreet.CustomButton.TabIndex = 1;
            this.tbStreet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbStreet.CustomButton.UseSelectable = true;
            this.tbStreet.CustomButton.Visible = false;
            this.tbStreet.Lines = new string[0];
            this.tbStreet.Location = new System.Drawing.Point(18, 270);
            this.tbStreet.MaxLength = 32767;
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.PasswordChar = '\0';
            this.tbStreet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbStreet.SelectedText = "";
            this.tbStreet.SelectionLength = 0;
            this.tbStreet.SelectionStart = 0;
            this.tbStreet.Size = new System.Drawing.Size(257, 23);
            this.tbStreet.TabIndex = 18;
            this.tbStreet.UseSelectable = true;
            this.tbStreet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbStreet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.LightBlue;
            this.labelAddress.Location = new System.Drawing.Point(15, 248);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(56, 19);
            this.labelAddress.TabIndex = 17;
            this.labelAddress.Text = "Address";
            this.labelAddress.UseCustomBackColor = true;
            // 
            // tbEmail
            // 
            // 
            // 
            // 
            this.tbEmail.CustomButton.Image = null;
            this.tbEmail.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.tbEmail.CustomButton.Name = "";
            this.tbEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbEmail.CustomButton.TabIndex = 1;
            this.tbEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbEmail.CustomButton.UseSelectable = true;
            this.tbEmail.CustomButton.Visible = false;
            this.tbEmail.Lines = new string[0];
            this.tbEmail.Location = new System.Drawing.Point(18, 220);
            this.tbEmail.MaxLength = 32767;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbEmail.SelectedText = "";
            this.tbEmail.SelectionLength = 0;
            this.tbEmail.SelectionStart = 0;
            this.tbEmail.Size = new System.Drawing.Size(257, 23);
            this.tbEmail.TabIndex = 16;
            this.tbEmail.UseSelectable = true;
            this.tbEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.LightBlue;
            this.labelEmail.Location = new System.Drawing.Point(15, 198);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 19);
            this.labelEmail.TabIndex = 15;
            this.labelEmail.Text = "Email";
            this.labelEmail.UseCustomBackColor = true;
            // 
            // tbTelephone
            // 
            // 
            // 
            // 
            this.tbTelephone.CustomButton.Image = null;
            this.tbTelephone.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.tbTelephone.CustomButton.Name = "";
            this.tbTelephone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbTelephone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTelephone.CustomButton.TabIndex = 1;
            this.tbTelephone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTelephone.CustomButton.UseSelectable = true;
            this.tbTelephone.CustomButton.Visible = false;
            this.tbTelephone.Lines = new string[0];
            this.tbTelephone.Location = new System.Drawing.Point(18, 170);
            this.tbTelephone.MaxLength = 32767;
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.PasswordChar = '\0';
            this.tbTelephone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTelephone.SelectedText = "";
            this.tbTelephone.SelectionLength = 0;
            this.tbTelephone.SelectionStart = 0;
            this.tbTelephone.Size = new System.Drawing.Size(257, 23);
            this.tbTelephone.TabIndex = 14;
            this.tbTelephone.UseSelectable = true;
            this.tbTelephone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTelephone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.BackColor = System.Drawing.Color.LightBlue;
            this.labelTelephone.Location = new System.Drawing.Point(15, 148);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(68, 19);
            this.labelTelephone.TabIndex = 13;
            this.labelTelephone.Text = "Telephone";
            this.labelTelephone.UseCustomBackColor = true;
            // 
            // cbOther
            // 
            this.cbOther.AutoSize = true;
            this.cbOther.BackColor = System.Drawing.Color.LightBlue;
            this.cbOther.Location = new System.Drawing.Point(210, 130);
            this.cbOther.Name = "cbOther";
            this.cbOther.Size = new System.Drawing.Size(53, 15);
            this.cbOther.Style = MetroFramework.MetroColorStyle.Orange;
            this.cbOther.TabIndex = 12;
            this.cbOther.Text = "Other";
            this.cbOther.UseCustomBackColor = true;
            this.cbOther.UseCustomForeColor = true;
            this.cbOther.UseSelectable = true;
            this.cbOther.UseStyleColors = true;
            // 
            // cbFemale
            // 
            this.cbFemale.AutoSize = true;
            this.cbFemale.BackColor = System.Drawing.Color.LightBlue;
            this.cbFemale.Location = new System.Drawing.Point(111, 130);
            this.cbFemale.Name = "cbFemale";
            this.cbFemale.Size = new System.Drawing.Size(61, 15);
            this.cbFemale.Style = MetroFramework.MetroColorStyle.Orange;
            this.cbFemale.TabIndex = 11;
            this.cbFemale.Text = "Female";
            this.cbFemale.UseCustomBackColor = true;
            this.cbFemale.UseCustomForeColor = true;
            this.cbFemale.UseSelectable = true;
            this.cbFemale.UseStyleColors = true;
            // 
            // cbMale
            // 
            this.cbMale.AutoSize = true;
            this.cbMale.BackColor = System.Drawing.Color.LightBlue;
            this.cbMale.Checked = true;
            this.cbMale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbMale.Location = new System.Drawing.Point(24, 130);
            this.cbMale.Name = "cbMale";
            this.cbMale.Size = new System.Drawing.Size(49, 15);
            this.cbMale.Style = MetroFramework.MetroColorStyle.Orange;
            this.cbMale.TabIndex = 10;
            this.cbMale.Text = "Male";
            this.cbMale.UseCustomBackColor = true;
            this.cbMale.UseCustomForeColor = true;
            this.cbMale.UseSelectable = true;
            this.cbMale.UseStyleColors = true;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.BackColor = System.Drawing.Color.LightBlue;
            this.labelGender.Location = new System.Drawing.Point(15, 108);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(52, 19);
            this.labelGender.TabIndex = 9;
            this.labelGender.Text = "Gender";
            this.labelGender.UseCustomBackColor = true;
            // 
            // cmbDay
            // 
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.ItemHeight = 23;
            this.cmbDay.Location = new System.Drawing.Point(210, 76);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.PromptText = "Day";
            this.cmbDay.Size = new System.Drawing.Size(65, 29);
            this.cmbDay.TabIndex = 8;
            this.cmbDay.UseSelectable = true;
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.ItemHeight = 23;
            this.cmbMonth.Location = new System.Drawing.Point(111, 76);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.PromptText = "Month";
            this.cmbMonth.Size = new System.Drawing.Size(93, 29);
            this.cmbMonth.TabIndex = 7;
            this.cmbMonth.UseSelectable = true;
            this.cmbMonth.Leave += new System.EventHandler(this.AddDaysToComboBox);
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.ItemHeight = 23;
            this.cmbYear.Location = new System.Drawing.Point(17, 76);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.PromptText = "Year";
            this.cmbYear.Size = new System.Drawing.Size(88, 29);
            this.cmbYear.TabIndex = 6;
            this.cmbYear.UseSelectable = true;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.BackColor = System.Drawing.Color.LightBlue;
            this.labelBirthday.Location = new System.Drawing.Point(15, 53);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(58, 19);
            this.labelBirthday.TabIndex = 5;
            this.labelBirthday.Text = "Birthday";
            this.labelBirthday.UseCustomBackColor = true;
            // 
            // tbSurname
            // 
            // 
            // 
            // 
            this.tbSurname.CustomButton.Image = null;
            this.tbSurname.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.tbSurname.CustomButton.Name = "";
            this.tbSurname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSurname.CustomButton.TabIndex = 1;
            this.tbSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSurname.CustomButton.UseSelectable = true;
            this.tbSurname.CustomButton.Visible = false;
            this.tbSurname.Lines = new string[] {
        "Last name"};
            this.tbSurname.Location = new System.Drawing.Point(149, 27);
            this.tbSurname.MaxLength = 32767;
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.PasswordChar = '\0';
            this.tbSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSurname.SelectedText = "";
            this.tbSurname.SelectionLength = 0;
            this.tbSurname.SelectionStart = 0;
            this.tbSurname.Size = new System.Drawing.Size(126, 23);
            this.tbSurname.TabIndex = 4;
            this.tbSurname.Text = "Last name";
            this.tbSurname.UseSelectable = true;
            this.tbSurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbFirstname
            // 
            // 
            // 
            // 
            this.tbFirstname.CustomButton.Image = null;
            this.tbFirstname.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.tbFirstname.CustomButton.Name = "";
            this.tbFirstname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbFirstname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbFirstname.CustomButton.TabIndex = 1;
            this.tbFirstname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbFirstname.CustomButton.UseSelectable = true;
            this.tbFirstname.CustomButton.Visible = false;
            this.tbFirstname.Lines = new string[] {
        "First name"};
            this.tbFirstname.Location = new System.Drawing.Point(17, 27);
            this.tbFirstname.MaxLength = 32767;
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.PasswordChar = '\0';
            this.tbFirstname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbFirstname.SelectedText = "";
            this.tbFirstname.SelectionLength = 0;
            this.tbFirstname.SelectionStart = 0;
            this.tbFirstname.Size = new System.Drawing.Size(118, 23);
            this.tbFirstname.TabIndex = 3;
            this.tbFirstname.Text = "First name";
            this.tbFirstname.UseSelectable = true;
            this.tbFirstname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbFirstname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelReservationName
            // 
            this.labelReservationName.AutoSize = true;
            this.labelReservationName.BackColor = System.Drawing.Color.LightBlue;
            this.labelReservationName.Location = new System.Drawing.Point(15, 5);
            this.labelReservationName.Name = "labelReservationName";
            this.labelReservationName.Size = new System.Drawing.Size(45, 19);
            this.labelReservationName.TabIndex = 2;
            this.labelReservationName.Text = "Name";
            this.labelReservationName.UseCustomBackColor = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btnUpdate);
            this.metroTabPage2.Controls.Add(this.btnRefresh);
            this.metroTabPage2.Controls.Add(this.dgvBooks);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1033, 563);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Universal Search";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(927, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update changes";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(3, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseSelectable = true;
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(0, 35);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.Size = new System.Drawing.Size(1037, 414);
            this.dgvBooks.TabIndex = 2;
            this.dgvBooks.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvBooks_UserDeletedRow);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.pnl);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1033, 562);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Rooms";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.btnShowAllLuxury);
            this.pnl.Controls.Add(this.btnShowAllRegular);
            this.pnl.Controls.Add(this.BtnShowAllHighEnd);
            this.pnl.Controls.Add(this.btnShowAllSuites);
            this.pnl.Controls.Add(this.dgvSuites);
            this.pnl.HorizontalScrollbarBarColor = true;
            this.pnl.HorizontalScrollbarHighlightOnWheel = false;
            this.pnl.HorizontalScrollbarSize = 10;
            this.pnl.Location = new System.Drawing.Point(4, 4);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1033, 458);
            this.pnl.TabIndex = 2;
            this.pnl.VerticalScrollbarBarColor = true;
            this.pnl.VerticalScrollbarHighlightOnWheel = false;
            this.pnl.VerticalScrollbarSize = 10;
            // 
            // btnShowAllLuxury
            // 
            this.btnShowAllLuxury.Location = new System.Drawing.Point(322, 3);
            this.btnShowAllLuxury.Name = "btnShowAllLuxury";
            this.btnShowAllLuxury.Size = new System.Drawing.Size(112, 23);
            this.btnShowAllLuxury.TabIndex = 6;
            this.btnShowAllLuxury.Text = "Show All Luxury";
            this.btnShowAllLuxury.UseVisualStyleBackColor = true;
            this.btnShowAllLuxury.Click += new System.EventHandler(this.btnShowAllLuxury_Click);
            // 
            // btnShowAllRegular
            // 
            this.btnShowAllRegular.Location = new System.Drawing.Point(100, 3);
            this.btnShowAllRegular.Name = "btnShowAllRegular";
            this.btnShowAllRegular.Size = new System.Drawing.Size(98, 23);
            this.btnShowAllRegular.TabIndex = 5;
            this.btnShowAllRegular.Text = "Show All Regular";
            this.btnShowAllRegular.UseVisualStyleBackColor = true;
            this.btnShowAllRegular.Click += new System.EventHandler(this.btnShowAllRegular_Click);
            // 
            // BtnShowAllHighEnd
            // 
            this.BtnShowAllHighEnd.Location = new System.Drawing.Point(204, 3);
            this.BtnShowAllHighEnd.Name = "BtnShowAllHighEnd";
            this.BtnShowAllHighEnd.Size = new System.Drawing.Size(112, 23);
            this.BtnShowAllHighEnd.TabIndex = 4;
            this.BtnShowAllHighEnd.Text = "Show All High-End";
            this.BtnShowAllHighEnd.UseVisualStyleBackColor = true;
            this.BtnShowAllHighEnd.Click += new System.EventHandler(this.BtnShowAllHighEnd_Click);
            // 
            // btnShowAllSuites
            // 
            this.btnShowAllSuites.Location = new System.Drawing.Point(4, 3);
            this.btnShowAllSuites.Name = "btnShowAllSuites";
            this.btnShowAllSuites.Size = new System.Drawing.Size(90, 23);
            this.btnShowAllSuites.TabIndex = 3;
            this.btnShowAllSuites.Text = "Show All Suites";
            this.btnShowAllSuites.UseVisualStyleBackColor = true;
            this.btnShowAllSuites.Click += new System.EventHandler(this.btnShowAllSuites_Click);
            // 
            // dgvSuites
            // 
            this.dgvSuites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuites.Location = new System.Drawing.Point(3, 32);
            this.dgvSuites.Name = "dgvSuites";
            this.dgvSuites.Size = new System.Drawing.Size(1023, 423);
            this.dgvSuites.TabIndex = 2;
            // 
            // FrontDesk
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1088, 584);
            this.Controls.Add(this.tabControls);
            this.Name = "FrontDesk";
            this.Text = "FrontDesk";
            this.tabControls.ResumeLayout(false);
            this.tabReservation.ResumeLayout(false);
            this.pnlReservationRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuitesToBook)).EndInit();
            this.pnlReservationMiddle.ResumeLayout(false);
            this.pnlReservationMiddle.PerformLayout();
            this.panelReservationLeft.ResumeLayout(false);
            this.panelReservationLeft.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuites)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControls;
        private MetroFramework.Controls.MetroTabPage tabReservation;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroPanel panelReservationLeft;
        private MetroFramework.Controls.MetroTextBox tbSurname;
        private MetroFramework.Controls.MetroTextBox tbFirstname;
        private MetroFramework.Controls.MetroLabel labelReservationName;
        private MetroFramework.Controls.MetroComboBox cmbDay;
        private MetroFramework.Controls.MetroComboBox cmbMonth;
        private MetroFramework.Controls.MetroComboBox cmbYear;
        private MetroFramework.Controls.MetroLabel labelBirthday;
        private MetroFramework.Controls.MetroCheckBox cbMale;
        private MetroFramework.Controls.MetroLabel labelGender;
        private MetroFramework.Controls.MetroCheckBox cbOther;
        private MetroFramework.Controls.MetroCheckBox cbFemale;
        private MetroFramework.Controls.MetroTextBox tbTelephone;
        private MetroFramework.Controls.MetroLabel labelTelephone;
        private MetroFramework.Controls.MetroLabel labelAddress;
        private MetroFramework.Controls.MetroTextBox tbEmail;
        private MetroFramework.Controls.MetroLabel labelEmail;
        private MetroFramework.Controls.MetroTextBox tbZipCode;
        private MetroFramework.Controls.MetroLabel labelZipCode;
        private MetroFramework.Controls.MetroComboBox cmbStates;
        private MetroFramework.Controls.MetroLabel labelState;
        private MetroFramework.Controls.MetroTextBox tbCity;
        private MetroFramework.Controls.MetroLabel labelCity;
        private MetroFramework.Controls.MetroTextBox tbStreet;
        private MetroFramework.Controls.MetroPanel pnlReservationMiddle;
        private MetroFramework.Controls.MetroComboBox cmbSuiteType;
        private MetroFramework.Controls.MetroLabel lblSuiteType;
        private MetroFramework.Controls.MetroComboBox cmbAmountOfDays;
        private MetroFramework.Controls.MetroLabel lblCheckOut;
        private MetroFramework.Controls.MetroComboBox cmbCheckInDay;
        private MetroFramework.Controls.MetroComboBox cmbCheckInMonth;
        private MetroFramework.Controls.MetroComboBox cmbCheckInYear;
        private MetroFramework.Controls.MetroLabel lblCheckIn;
        private MetroFramework.Controls.MetroCheckBox cbBreakfast;
        private MetroFramework.Controls.MetroButton btnSearchButton;
        private MetroFramework.Controls.MetroPanel pnlReservationRight;
        private MetroFramework.Controls.MetroButton btnBook;
        private MetroFramework.Controls.MetroPanel pnl;
        private System.Windows.Forms.DataGridView dgvSuites;
        private System.Windows.Forms.Button btnShowAllSuites;
        private System.Windows.Forms.Button BtnShowAllHighEnd;
        private System.Windows.Forms.Button btnShowAllLuxury;
        private System.Windows.Forms.Button btnShowAllRegular;
        private MetroFramework.Controls.MetroComboBox cmbChildren;
        private MetroFramework.Controls.MetroComboBox cmbAdults;
        private MetroFramework.Controls.MetroLabel lblAdults;
        private MetroFramework.Controls.MetroLabel lblChildren;
        private System.Windows.Forms.DataGridView dgvSuitesToBook;
        private System.Windows.Forms.DataGridView dgvBooks;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroButton btnUpdate;
    }
}