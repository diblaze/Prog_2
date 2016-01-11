using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace winDriveInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDriveInfo_Click(object sender, EventArgs e)
        {
            //get drives
            DriveInfo[] drives = DriveInfo.GetDrives();
            lblAmountText.Text = "Amount of Drives: "+ drives.Length;
            foreach (DriveInfo drive in drives.Where(drive => drive.IsReady))
            {
                lbDriveInfo.Items.Add("Label: " + drive.VolumeLabel);
                lbDriveInfo.Items.Add("Name: " + drive.Name);
                lbDriveInfo.Items.Add("Root: " + drive.RootDirectory);
                lbDriveInfo.Items.Add("Free Space: " + (drive.AvailableFreeSpace / 1073741824) + " GiB");
                lbDriveInfo.Items.Add("Total Space: " + (drive.TotalSize / 1073741824) + " GiB");
                lbDriveInfo.Items.Add("Drive Format: " + drive.DriveFormat);
                lbDriveInfo.Items.Add("Drive Type: " + drive.DriveType);
                lbDriveInfo.Items.Add("Drive Ready: " + drive.IsReady);
                lbDriveInfo.Items.Add("--------");
            }
        }
    }
}
