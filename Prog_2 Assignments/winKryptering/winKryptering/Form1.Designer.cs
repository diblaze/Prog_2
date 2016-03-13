namespace winKryptering
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
            this.lblFile = new System.Windows.Forms.Label();
            this.tbTextToEncrypt = new System.Windows.Forms.TextBox();
            this.lblEncryptText = new System.Windows.Forms.Label();
            this.lblDecryptedText = new System.Windows.Forms.Label();
            this.tbEncryptedText = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnRovar = new System.Windows.Forms.Button();
            this.btnILang = new System.Windows.Forms.Button();
            this.btnFikon = new System.Windows.Forms.Button();
            this.tbFileLocation = new System.Windows.Forms.TextBox();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnUncryptedOpenFileDialog = new System.Windows.Forms.Button();
            this.tbUncryptedFileLocation = new System.Windows.Forms.TextBox();
            this.btnOpenUncrypted = new System.Windows.Forms.Button();
            this.lblDecryptFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(186, 26);
            this.lblFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(122, 13);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "Enkrypterad fil att öppna";
            // 
            // tbTextToEncrypt
            // 
            this.tbTextToEncrypt.Location = new System.Drawing.Point(23, 151);
            this.tbTextToEncrypt.Margin = new System.Windows.Forms.Padding(2);
            this.tbTextToEncrypt.Multiline = true;
            this.tbTextToEncrypt.Name = "tbTextToEncrypt";
            this.tbTextToEncrypt.Size = new System.Drawing.Size(331, 415);
            this.tbTextToEncrypt.TabIndex = 1;
            // 
            // lblEncryptText
            // 
            this.lblEncryptText.AutoSize = true;
            this.lblEncryptText.Location = new System.Drawing.Point(20, 135);
            this.lblEncryptText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEncryptText.Name = "lblEncryptText";
            this.lblEncryptText.Size = new System.Drawing.Size(96, 13);
            this.lblEncryptText.TabIndex = 2;
            this.lblEncryptText.Text = "Text att enkryptera";
            // 
            // lblDecryptedText
            // 
            this.lblDecryptedText.AutoSize = true;
            this.lblDecryptedText.Location = new System.Drawing.Point(535, 135);
            this.lblDecryptedText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDecryptedText.Name = "lblDecryptedText";
            this.lblDecryptedText.Size = new System.Drawing.Size(84, 13);
            this.lblDecryptedText.TabIndex = 4;
            this.lblDecryptedText.Text = "Enkrypterad text";
            // 
            // tbEncryptedText
            // 
            this.tbEncryptedText.Location = new System.Drawing.Point(538, 151);
            this.tbEncryptedText.Margin = new System.Windows.Forms.Padding(2);
            this.tbEncryptedText.Multiline = true;
            this.tbEncryptedText.Name = "tbEncryptedText";
            this.tbEncryptedText.ReadOnly = true;
            this.tbEncryptedText.Size = new System.Drawing.Size(331, 415);
            this.tbEncryptedText.TabIndex = 3;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(607, 16);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(80, 32);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Öppna";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(788, 116);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 32);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Spara";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSaveFileDialog_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(788, 580);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(80, 32);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Avsluta";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnRovar
            // 
            this.btnRovar.Location = new System.Drawing.Point(409, 179);
            this.btnRovar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRovar.Name = "btnRovar";
            this.btnRovar.Size = new System.Drawing.Size(80, 56);
            this.btnRovar.TabIndex = 8;
            this.btnRovar.Text = "Rövarspråket";
            this.btnRovar.UseVisualStyleBackColor = true;
            this.btnRovar.Click += new System.EventHandler(this.btnRovar_Click);
            // 
            // btnILang
            // 
            this.btnILang.Location = new System.Drawing.Point(409, 239);
            this.btnILang.Margin = new System.Windows.Forms.Padding(2);
            this.btnILang.Name = "btnILang";
            this.btnILang.Size = new System.Drawing.Size(80, 56);
            this.btnILang.TabIndex = 9;
            this.btnILang.Text = "I-språket";
            this.btnILang.UseVisualStyleBackColor = true;
            this.btnILang.Click += new System.EventHandler(this.btnILang_Click);
            // 
            // btnFikon
            // 
            this.btnFikon.Location = new System.Drawing.Point(409, 298);
            this.btnFikon.Margin = new System.Windows.Forms.Padding(2);
            this.btnFikon.Name = "btnFikon";
            this.btnFikon.Size = new System.Drawing.Size(80, 56);
            this.btnFikon.TabIndex = 10;
            this.btnFikon.Text = "Fikonspråket";
            this.btnFikon.UseVisualStyleBackColor = true;
            this.btnFikon.Click += new System.EventHandler(this.btnFikon_Click);
            // 
            // tbFileLocation
            // 
            this.tbFileLocation.Location = new System.Drawing.Point(320, 22);
            this.tbFileLocation.Margin = new System.Windows.Forms.Padding(2);
            this.tbFileLocation.Name = "tbFileLocation";
            this.tbFileLocation.Size = new System.Drawing.Size(238, 20);
            this.tbFileLocation.TabIndex = 11;
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(570, 22);
            this.btnOpenFileDialog.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(25, 21);
            this.btnOpenFileDialog.TabIndex = 12;
            this.btnOpenFileDialog.Text = "...";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnEncryptedFileDialog_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(409, 543);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(80, 23);
            this.btnClean.TabIndex = 13;
            this.btnClean.Text = "Rensa text";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnUncryptedOpenFileDialog
            // 
            this.btnUncryptedOpenFileDialog.Location = new System.Drawing.Point(570, 75);
            this.btnUncryptedOpenFileDialog.Margin = new System.Windows.Forms.Padding(2);
            this.btnUncryptedOpenFileDialog.Name = "btnUncryptedOpenFileDialog";
            this.btnUncryptedOpenFileDialog.Size = new System.Drawing.Size(25, 21);
            this.btnUncryptedOpenFileDialog.TabIndex = 17;
            this.btnUncryptedOpenFileDialog.Text = "...";
            this.btnUncryptedOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnUncryptedOpenFileDialog.Click += new System.EventHandler(this.btnUncryptedOpenFileDialog_Click);
            // 
            // tbUncryptedFileLocation
            // 
            this.tbUncryptedFileLocation.Location = new System.Drawing.Point(320, 75);
            this.tbUncryptedFileLocation.Margin = new System.Windows.Forms.Padding(2);
            this.tbUncryptedFileLocation.Name = "tbUncryptedFileLocation";
            this.tbUncryptedFileLocation.Size = new System.Drawing.Size(238, 20);
            this.tbUncryptedFileLocation.TabIndex = 16;
            // 
            // btnOpenUncrypted
            // 
            this.btnOpenUncrypted.Location = new System.Drawing.Point(607, 69);
            this.btnOpenUncrypted.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenUncrypted.Name = "btnOpenUncrypted";
            this.btnOpenUncrypted.Size = new System.Drawing.Size(80, 32);
            this.btnOpenUncrypted.TabIndex = 15;
            this.btnOpenUncrypted.Text = "Öppna";
            this.btnOpenUncrypted.UseVisualStyleBackColor = true;
            this.btnOpenUncrypted.Click += new System.EventHandler(this.btnOpenUncrypted_Click);
            // 
            // lblDecryptFile
            // 
            this.lblDecryptFile.AutoSize = true;
            this.lblDecryptFile.Location = new System.Drawing.Point(186, 79);
            this.lblDecryptFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDecryptFile.Name = "lblDecryptFile";
            this.lblDecryptFile.Size = new System.Drawing.Size(117, 13);
            this.lblDecryptFile.TabIndex = 14;
            this.lblDecryptFile.Text = "Okrypterad fil att öppna";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 620);
            this.Controls.Add(this.btnUncryptedOpenFileDialog);
            this.Controls.Add(this.tbUncryptedFileLocation);
            this.Controls.Add(this.btnOpenUncrypted);
            this.Controls.Add(this.lblDecryptFile);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.tbFileLocation);
            this.Controls.Add(this.btnFikon);
            this.Controls.Add(this.btnILang);
            this.Controls.Add(this.btnRovar);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblDecryptedText);
            this.Controls.Add(this.tbEncryptedText);
            this.Controls.Add(this.lblEncryptText);
            this.Controls.Add(this.tbTextToEncrypt);
            this.Controls.Add(this.lblFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Kryptering";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox tbTextToEncrypt;
        private System.Windows.Forms.Label lblEncryptText;
        private System.Windows.Forms.Label lblDecryptedText;
        private System.Windows.Forms.TextBox tbEncryptedText;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnRovar;
        private System.Windows.Forms.Button btnILang;
        private System.Windows.Forms.Button btnFikon;
        private System.Windows.Forms.TextBox tbFileLocation;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnUncryptedOpenFileDialog;
        private System.Windows.Forms.TextBox tbUncryptedFileLocation;
        private System.Windows.Forms.Button btnOpenUncrypted;
        private System.Windows.Forms.Label lblDecryptFile;
    }
}

