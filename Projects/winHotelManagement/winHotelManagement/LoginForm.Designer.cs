using MetroFramework;

namespace winHotelManagement
{
    partial class LoginForm
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
            this.labelUsername = new MetroFramework.Controls.MetroLabel();
            this.inputPassword = new MetroFramework.Controls.MetroTextBox();
            this.inputUsername = new MetroFramework.Controls.MetroTextBox();
            this.labelPassword = new MetroFramework.Controls.MetroLabel();
            this.buttonSignIn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelUsername.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelUsername.Location = new System.Drawing.Point(103, 96);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(91, 25);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "Username";
            // 
            // inputPassword
            // 
            // 
            // 
            // 
            this.inputPassword.CustomButton.Image = null;
            this.inputPassword.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.inputPassword.CustomButton.Name = "";
            this.inputPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.inputPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inputPassword.CustomButton.TabIndex = 1;
            this.inputPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inputPassword.CustomButton.UseSelectable = true;
            this.inputPassword.CustomButton.Visible = false;
            this.inputPassword.Lines = new string[0];
            this.inputPassword.Location = new System.Drawing.Point(229, 146);
            this.inputPassword.MaxLength = 32767;
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.PasswordChar = '\0';
            this.inputPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inputPassword.SelectedText = "";
            this.inputPassword.SelectionLength = 0;
            this.inputPassword.SelectionStart = 0;
            this.inputPassword.Size = new System.Drawing.Size(128, 23);
            this.inputPassword.Style = MetroFramework.MetroColorStyle.Orange;
            this.inputPassword.TabIndex = 1;
            this.inputPassword.UseSelectable = true;
            this.inputPassword.UseStyleColors = true;
            this.inputPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inputPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // inputUsername
            // 
            // 
            // 
            // 
            this.inputUsername.CustomButton.Image = null;
            this.inputUsername.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.inputUsername.CustomButton.Name = "";
            this.inputUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.inputUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inputUsername.CustomButton.TabIndex = 1;
            this.inputUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inputUsername.CustomButton.UseSelectable = true;
            this.inputUsername.CustomButton.Visible = false;
            this.inputUsername.Lines = new string[0];
            this.inputUsername.Location = new System.Drawing.Point(229, 99);
            this.inputUsername.MaxLength = 32767;
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.PasswordChar = '\0';
            this.inputUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inputUsername.SelectedText = "";
            this.inputUsername.SelectionLength = 0;
            this.inputUsername.SelectionStart = 0;
            this.inputUsername.Size = new System.Drawing.Size(128, 23);
            this.inputUsername.Style = MetroFramework.MetroColorStyle.Orange;
            this.inputUsername.TabIndex = 0;
            this.inputUsername.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inputUsername.UseSelectable = true;
            this.inputUsername.UseStyleColors = true;
            this.inputUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inputUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelPassword.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelPassword.Location = new System.Drawing.Point(103, 141);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(87, 25);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            this.labelPassword.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.buttonSignIn.Location = new System.Drawing.Point(156, 206);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(130, 47);
            this.buttonSignIn.Style = MetroFramework.MetroColorStyle.Orange;
            this.buttonSignIn.TabIndex = 2;
            this.buttonSignIn.Text = "Sign in";
            this.buttonSignIn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.buttonSignIn.UseSelectable = true;
            this.buttonSignIn.UseStyleColors = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(448, 302);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.inputUsername);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.labelUsername);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Resizable = false;
            this.Text = "Hotel Management - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labelUsername;
        private MetroFramework.Controls.MetroTextBox inputPassword;
        private MetroFramework.Controls.MetroTextBox inputUsername;
        private MetroFramework.Controls.MetroLabel labelPassword;
        private MetroFramework.Controls.MetroButton buttonSignIn;
    }
}

