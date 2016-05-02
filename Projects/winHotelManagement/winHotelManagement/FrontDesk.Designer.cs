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
            this.panelReservationLeft = new MetroFramework.Controls.MetroPanel();
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
            this.textboxSurname = new MetroFramework.Controls.MetroTextBox();
            this.textboxFirstname = new MetroFramework.Controls.MetroTextBox();
            this.labelReservationName = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.tbStreet = new MetroFramework.Controls.MetroTextBox();
            this.tbCity = new MetroFramework.Controls.MetroTextBox();
            this.labelCity = new MetroFramework.Controls.MetroLabel();
            this.labelState = new MetroFramework.Controls.MetroLabel();
            this.cmbStates = new MetroFramework.Controls.MetroComboBox();
            this.labelZipCode = new MetroFramework.Controls.MetroLabel();
            this.tbZipCode = new MetroFramework.Controls.MetroTextBox();
            this.tabControls.SuspendLayout();
            this.tabReservation.SuspendLayout();
            this.panelReservationLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControls
            // 
            this.tabControls.Controls.Add(this.tabReservation);
            this.tabControls.Controls.Add(this.metroTabPage2);
            this.tabControls.Controls.Add(this.metroTabPage3);
            this.tabControls.Location = new System.Drawing.Point(24, 74);
            this.tabControls.Name = "tabControls";
            this.tabControls.SelectedIndex = 0;
            this.tabControls.Size = new System.Drawing.Size(1041, 605);
            this.tabControls.TabIndex = 0;
            this.tabControls.UseSelectable = true;
            // 
            // tabReservation
            // 
            this.tabReservation.Controls.Add(this.panelReservationLeft);
            this.tabReservation.HorizontalScrollbarBarColor = true;
            this.tabReservation.HorizontalScrollbarHighlightOnWheel = false;
            this.tabReservation.HorizontalScrollbarSize = 10;
            this.tabReservation.Location = new System.Drawing.Point(4, 38);
            this.tabReservation.Name = "tabReservation";
            this.tabReservation.Size = new System.Drawing.Size(1033, 563);
            this.tabReservation.TabIndex = 0;
            this.tabReservation.Text = "Reservation";
            this.tabReservation.VerticalScrollbarBarColor = true;
            this.tabReservation.VerticalScrollbarHighlightOnWheel = false;
            this.tabReservation.VerticalScrollbarSize = 10;
            // 
            // panelReservationLeft
            // 
            this.panelReservationLeft.BackColor = System.Drawing.SystemColors.Control;
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
            this.panelReservationLeft.Controls.Add(this.textboxSurname);
            this.panelReservationLeft.Controls.Add(this.textboxFirstname);
            this.panelReservationLeft.Controls.Add(this.labelReservationName);
            this.panelReservationLeft.HorizontalScrollbarBarColor = true;
            this.panelReservationLeft.HorizontalScrollbarHighlightOnWheel = false;
            this.panelReservationLeft.HorizontalScrollbarSize = 10;
            this.panelReservationLeft.Location = new System.Drawing.Point(3, 19);
            this.panelReservationLeft.Name = "panelReservationLeft";
            this.panelReservationLeft.Size = new System.Drawing.Size(293, 541);
            this.panelReservationLeft.TabIndex = 2;
            this.panelReservationLeft.VerticalScrollbarBarColor = true;
            this.panelReservationLeft.VerticalScrollbarHighlightOnWheel = false;
            this.panelReservationLeft.VerticalScrollbarSize = 10;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(15, 248);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(56, 19);
            this.labelAddress.TabIndex = 17;
            this.labelAddress.Text = "Address";
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
            this.labelEmail.Location = new System.Drawing.Point(15, 198);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 19);
            this.labelEmail.TabIndex = 15;
            this.labelEmail.Text = "Email";
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
            this.labelTelephone.Location = new System.Drawing.Point(15, 148);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(68, 19);
            this.labelTelephone.TabIndex = 13;
            this.labelTelephone.Text = "Telephone";
            // 
            // cbOther
            // 
            this.cbOther.AutoSize = true;
            this.cbOther.Location = new System.Drawing.Point(210, 130);
            this.cbOther.Name = "cbOther";
            this.cbOther.Size = new System.Drawing.Size(53, 15);
            this.cbOther.TabIndex = 12;
            this.cbOther.Text = "Other";
            this.cbOther.UseSelectable = true;
            // 
            // cbFemale
            // 
            this.cbFemale.AutoSize = true;
            this.cbFemale.Location = new System.Drawing.Point(111, 130);
            this.cbFemale.Name = "cbFemale";
            this.cbFemale.Size = new System.Drawing.Size(61, 15);
            this.cbFemale.TabIndex = 11;
            this.cbFemale.Text = "Female";
            this.cbFemale.UseSelectable = true;
            // 
            // cbMale
            // 
            this.cbMale.AutoSize = true;
            this.cbMale.Location = new System.Drawing.Point(24, 130);
            this.cbMale.Name = "cbMale";
            this.cbMale.Size = new System.Drawing.Size(49, 15);
            this.cbMale.TabIndex = 10;
            this.cbMale.Text = "Male";
            this.cbMale.UseSelectable = true;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(15, 108);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(52, 19);
            this.labelGender.TabIndex = 9;
            this.labelGender.Text = "Gender";
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
            this.labelBirthday.Location = new System.Drawing.Point(15, 53);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(58, 19);
            this.labelBirthday.TabIndex = 5;
            this.labelBirthday.Text = "Birthday";
            // 
            // textboxSurname
            // 
            // 
            // 
            // 
            this.textboxSurname.CustomButton.Image = null;
            this.textboxSurname.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.textboxSurname.CustomButton.Name = "";
            this.textboxSurname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxSurname.CustomButton.TabIndex = 1;
            this.textboxSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxSurname.CustomButton.UseSelectable = true;
            this.textboxSurname.CustomButton.Visible = false;
            this.textboxSurname.Lines = new string[] {
        "Last name"};
            this.textboxSurname.Location = new System.Drawing.Point(149, 27);
            this.textboxSurname.MaxLength = 32767;
            this.textboxSurname.Name = "textboxSurname";
            this.textboxSurname.PasswordChar = '\0';
            this.textboxSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxSurname.SelectedText = "";
            this.textboxSurname.SelectionLength = 0;
            this.textboxSurname.SelectionStart = 0;
            this.textboxSurname.Size = new System.Drawing.Size(126, 23);
            this.textboxSurname.TabIndex = 4;
            this.textboxSurname.Text = "Last name";
            this.textboxSurname.UseSelectable = true;
            this.textboxSurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxSurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textboxFirstname
            // 
            // 
            // 
            // 
            this.textboxFirstname.CustomButton.Image = null;
            this.textboxFirstname.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.textboxFirstname.CustomButton.Name = "";
            this.textboxFirstname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxFirstname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxFirstname.CustomButton.TabIndex = 1;
            this.textboxFirstname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxFirstname.CustomButton.UseSelectable = true;
            this.textboxFirstname.CustomButton.Visible = false;
            this.textboxFirstname.Lines = new string[] {
        "First name"};
            this.textboxFirstname.Location = new System.Drawing.Point(17, 27);
            this.textboxFirstname.MaxLength = 32767;
            this.textboxFirstname.Name = "textboxFirstname";
            this.textboxFirstname.PasswordChar = '\0';
            this.textboxFirstname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxFirstname.SelectedText = "";
            this.textboxFirstname.SelectionLength = 0;
            this.textboxFirstname.SelectionStart = 0;
            this.textboxFirstname.Size = new System.Drawing.Size(118, 23);
            this.textboxFirstname.TabIndex = 3;
            this.textboxFirstname.Text = "First name";
            this.textboxFirstname.UseSelectable = true;
            this.textboxFirstname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxFirstname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelReservationName
            // 
            this.labelReservationName.AutoSize = true;
            this.labelReservationName.Location = new System.Drawing.Point(15, 5);
            this.labelReservationName.Name = "labelReservationName";
            this.labelReservationName.Size = new System.Drawing.Size(45, 19);
            this.labelReservationName.TabIndex = 2;
            this.labelReservationName.Text = "Name";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1033, 562);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Universal Search";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1033, 562);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Room Availability";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
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
            this.labelCity.Location = new System.Drawing.Point(15, 301);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(31, 19);
            this.labelCity.TabIndex = 19;
            this.labelCity.Text = "City";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(15, 352);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(38, 19);
            this.labelState.TabIndex = 21;
            this.labelState.Text = "State";
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
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Location = new System.Drawing.Point(143, 352);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(64, 19);
            this.labelZipCode.TabIndex = 23;
            this.labelZipCode.Text = "Zip Code";
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
            // FrontDesk
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1088, 702);
            this.Controls.Add(this.tabControls);
            this.Name = "FrontDesk";
            this.Text = "FrontDesk";
            this.tabControls.ResumeLayout(false);
            this.tabReservation.ResumeLayout(false);
            this.panelReservationLeft.ResumeLayout(false);
            this.panelReservationLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControls;
        private MetroFramework.Controls.MetroTabPage tabReservation;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroPanel panelReservationLeft;
        private MetroFramework.Controls.MetroTextBox textboxSurname;
        private MetroFramework.Controls.MetroTextBox textboxFirstname;
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
    }
}