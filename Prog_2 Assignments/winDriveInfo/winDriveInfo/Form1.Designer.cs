namespace winDriveInfo
{
    partial class Form1
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
            this.btnDriveInfo = new System.Windows.Forms.Button();
            this.lbDriveInfo = new System.Windows.Forms.ListBox();
            this.lblAmountText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDriveInfo
            // 
            this.btnDriveInfo.Location = new System.Drawing.Point(12, 110);
            this.btnDriveInfo.Name = "btnDriveInfo";
            this.btnDriveInfo.Size = new System.Drawing.Size(162, 60);
            this.btnDriveInfo.TabIndex = 0;
            this.btnDriveInfo.Text = "DriveInfo";
            this.btnDriveInfo.UseVisualStyleBackColor = true;
            this.btnDriveInfo.Click += new System.EventHandler(this.btnDriveInfo_Click);
            // 
            // lbDriveInfo
            // 
            this.lbDriveInfo.FormattingEnabled = true;
            this.lbDriveInfo.ItemHeight = 24;
            this.lbDriveInfo.Location = new System.Drawing.Point(357, 110);
            this.lbDriveInfo.Name = "lbDriveInfo";
            this.lbDriveInfo.Size = new System.Drawing.Size(552, 772);
            this.lbDriveInfo.TabIndex = 1;
            // 
            // lblAmountText
            // 
            this.lblAmountText.AutoSize = true;
            this.lblAmountText.Location = new System.Drawing.Point(12, 187);
            this.lblAmountText.Name = "lblAmountText";
            this.lblAmountText.Size = new System.Drawing.Size(172, 25);
            this.lblAmountText.TabIndex = 2;
            this.lblAmountText.Text = "Amount of Drives: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 902);
            this.Controls.Add(this.lblAmountText);
            this.Controls.Add(this.lbDriveInfo);
            this.Controls.Add(this.btnDriveInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDriveInfo;
        private System.Windows.Forms.ListBox lbDriveInfo;
        private System.Windows.Forms.Label lblAmountText;
    }
}

