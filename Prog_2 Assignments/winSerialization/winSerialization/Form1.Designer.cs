namespace winSerialization
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbSurName = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbList = new System.Windows.Forms.ListBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(50, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(96, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Förnamn:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(39, 109);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(107, 25);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Efternamn:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(62, 161);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(84, 25);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Telefon:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(173, 57);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(203, 29);
            this.tbFirstName.TabIndex = 3;
            // 
            // tbSurName
            // 
            this.tbSurName.Location = new System.Drawing.Point(173, 107);
            this.tbSurName.Name = "tbSurName";
            this.tbSurName.Size = new System.Drawing.Size(203, 29);
            this.tbSurName.TabIndex = 4;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(173, 159);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(203, 29);
            this.tbPhone.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(231, 215);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 34);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbList
            // 
            this.lbList.FormattingEnabled = true;
            this.lbList.ItemHeight = 24;
            this.lbList.Location = new System.Drawing.Point(44, 293);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(482, 388);
            this.lbList.TabIndex = 7;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(44, 687);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(87, 34);
            this.btnRead.TabIndex = 8;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 748);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.lbList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbSurName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbSurName;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbList;
        private System.Windows.Forms.Button btnRead;
    }
}

