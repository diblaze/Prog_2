namespace winMasterMind
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
            this.btnPurple = new System.Windows.Forms.Button();
            this.flpRowDock = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAqua = new System.Windows.Forms.Button();
            this.btnBrown = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPurple
            // 
            this.btnPurple.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPurple.BackColor = System.Drawing.Color.Purple;
            this.btnPurple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPurple.Location = new System.Drawing.Point(25, 625);
            this.btnPurple.Margin = new System.Windows.Forms.Padding(2);
            this.btnPurple.MaximumSize = new System.Drawing.Size(50, 35);
            this.btnPurple.MinimumSize = new System.Drawing.Size(50, 35);
            this.btnPurple.Name = "btnPurple";
            this.btnPurple.Size = new System.Drawing.Size(50, 35);
            this.btnPurple.TabIndex = 1;
            this.btnPurple.UseVisualStyleBackColor = false;
            this.btnPurple.Click += new System.EventHandler(this.PegClicked);
            // 
            // flpRowDock
            // 
            this.flpRowDock.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flpRowDock.Location = new System.Drawing.Point(25, 22);
            this.flpRowDock.Margin = new System.Windows.Forms.Padding(2);
            this.flpRowDock.Name = "flpRowDock";
            this.flpRowDock.Size = new System.Drawing.Size(469, 587);
            this.flpRowDock.TabIndex = 10;
            // 
            // btnAqua
            // 
            this.btnAqua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAqua.BackColor = System.Drawing.Color.Aqua;
            this.btnAqua.Location = new System.Drawing.Point(439, 625);
            this.btnAqua.Margin = new System.Windows.Forms.Padding(2);
            this.btnAqua.MaximumSize = new System.Drawing.Size(50, 35);
            this.btnAqua.MinimumSize = new System.Drawing.Size(50, 35);
            this.btnAqua.Name = "btnAqua";
            this.btnAqua.Size = new System.Drawing.Size(50, 35);
            this.btnAqua.TabIndex = 18;
            this.btnAqua.UseVisualStyleBackColor = false;
            this.btnAqua.Click += new System.EventHandler(this.PegClicked);
            // 
            // btnBrown
            // 
            this.btnBrown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBrown.BackColor = System.Drawing.Color.Brown;
            this.btnBrown.Location = new System.Drawing.Point(379, 625);
            this.btnBrown.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrown.MaximumSize = new System.Drawing.Size(50, 35);
            this.btnBrown.MinimumSize = new System.Drawing.Size(50, 35);
            this.btnBrown.Name = "btnBrown";
            this.btnBrown.Size = new System.Drawing.Size(50, 35);
            this.btnBrown.TabIndex = 17;
            this.btnBrown.UseVisualStyleBackColor = false;
            this.btnBrown.Click += new System.EventHandler(this.PegClicked);
            // 
            // btnOrange
            // 
            this.btnOrange.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOrange.BackColor = System.Drawing.Color.Orange;
            this.btnOrange.Location = new System.Drawing.Point(319, 625);
            this.btnOrange.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrange.MaximumSize = new System.Drawing.Size(50, 35);
            this.btnOrange.MinimumSize = new System.Drawing.Size(50, 35);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(50, 35);
            this.btnOrange.TabIndex = 16;
            this.btnOrange.UseVisualStyleBackColor = false;
            this.btnOrange.Click += new System.EventHandler(this.PegClicked);
            // 
            // btnBlue
            // 
            this.btnBlue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(259, 625);
            this.btnBlue.Margin = new System.Windows.Forms.Padding(2);
            this.btnBlue.MaximumSize = new System.Drawing.Size(50, 35);
            this.btnBlue.MinimumSize = new System.Drawing.Size(50, 35);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(50, 35);
            this.btnBlue.TabIndex = 15;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.PegClicked);
            // 
            // btnYellow
            // 
            this.btnYellow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Location = new System.Drawing.Point(199, 625);
            this.btnYellow.Margin = new System.Windows.Forms.Padding(2);
            this.btnYellow.MaximumSize = new System.Drawing.Size(50, 35);
            this.btnYellow.MinimumSize = new System.Drawing.Size(50, 35);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(50, 35);
            this.btnYellow.TabIndex = 14;
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.PegClicked);
            // 
            // btnGreen
            // 
            this.btnGreen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.Location = new System.Drawing.Point(139, 625);
            this.btnGreen.Margin = new System.Windows.Forms.Padding(2);
            this.btnGreen.MaximumSize = new System.Drawing.Size(50, 35);
            this.btnGreen.MinimumSize = new System.Drawing.Size(50, 35);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(50, 35);
            this.btnGreen.TabIndex = 13;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.PegClicked);
            // 
            // btnRed
            // 
            this.btnRed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRed.Location = new System.Drawing.Point(79, 625);
            this.btnRed.Margin = new System.Windows.Forms.Padding(2);
            this.btnRed.MaximumSize = new System.Drawing.Size(50, 35);
            this.btnRed.MinimumSize = new System.Drawing.Size(50, 35);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(50, 35);
            this.btnRed.TabIndex = 12;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.PegClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 706);
            this.Controls.Add(this.btnAqua);
            this.Controls.Add(this.btnBrown);
            this.Controls.Add(this.btnOrange);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.flpRowDock);
            this.Controls.Add(this.btnPurple);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(535, 745);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(535, 745);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MasterMind C#";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPurple;
        private System.Windows.Forms.FlowLayoutPanel flpRowDock;
        private System.Windows.Forms.Button btnAqua;
        private System.Windows.Forms.Button btnBrown;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnRed;
    }
}

