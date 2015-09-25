namespace winTestServer
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblTextBox = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblFoundText = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lblShelfText = new System.Windows.Forms.Label();
            this.txtShelfID = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(98, 50);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(161, 26);
            this.txtID.TabIndex = 0;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblTextBox
            // 
            this.lblTextBox.AutoSize = true;
            this.lblTextBox.Location = new System.Drawing.Point(21, 53);
            this.lblTextBox.Name = "lblTextBox";
            this.lblTextBox.Size = new System.Drawing.Size(67, 20);
            this.lblTextBox.TabIndex = 1;
            this.lblTextBox.Text = "Book ID";
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(279, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Sök";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblFoundText
            // 
            this.lblFoundText.AutoSize = true;
            this.lblFoundText.Location = new System.Drawing.Point(160, 139);
            this.lblFoundText.Name = "lblFoundText";
            this.lblFoundText.Size = new System.Drawing.Size(0, 20);
            this.lblFoundText.TabIndex = 3;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Enabled = false;
            this.btnAddBook.Location = new System.Drawing.Point(279, 78);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(91, 34);
            this.btnAddBook.TabIndex = 4;
            this.btnAddBook.Text = "Lägg till";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // lblShelfText
            // 
            this.lblShelfText.AutoSize = true;
            this.lblShelfText.Location = new System.Drawing.Point(21, 85);
            this.lblShelfText.Name = "lblShelfText";
            this.lblShelfText.Size = new System.Drawing.Size(46, 20);
            this.lblShelfText.TabIndex = 6;
            this.lblShelfText.Text = "Shelf";
            // 
            // txtShelfID
            // 
            this.txtShelfID.Location = new System.Drawing.Point(98, 82);
            this.txtShelfID.Name = "txtShelfID";
            this.txtShelfID.Size = new System.Drawing.Size(161, 26);
            this.txtShelfID.TabIndex = 5;
            this.txtShelfID.TextChanged += new System.EventHandler(this.txtShelfID_TextChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(279, 164);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(91, 34);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Anslut";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 220);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblShelfText);
            this.Controls.Add(this.txtShelfID);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.lblFoundText);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblTextBox);
            this.Controls.Add(this.txtID);
            this.Name = "Form1";
            this.Text = "RFID Search Testing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblTextBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblFoundText;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label lblShelfText;
        private System.Windows.Forms.TextBox txtShelfID;
        private System.Windows.Forms.Button btnConnect;
    }
}

