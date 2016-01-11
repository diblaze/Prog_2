using System;
using System.IO;
using System.Windows.Forms;

namespace winFileIO
{
    public partial class Form1 : Form
    {
        private const string PathToFile = @"C:\Test";
        private const string FileName = @"Test.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (tbData.Text.Length <= 0)
            {
                MessageBox.Show(@"No text entered", @"Error!", MessageBoxButtons.OK);
                return;
            }

            try
            {
                //create dir if it does not exists
                while (!Directory.Exists(PathToFile))
                {
                    Directory.CreateDirectory(PathToFile);
                }

                using (StreamWriter fs = new StreamWriter(Path.Combine(PathToFile, FileName), false))
                {
                    await fs.WriteAsync(tbData.Text);
                }
            }
            catch (IOException ex)
            {
                //catch error
                MessageBox.Show(ex.Message, @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            tbData.Clear();

            try
            {
                //create dir if it does not exists
                if (!Directory.Exists(PathToFile))
                {
                    throw new IOException();
                }

                using (StreamReader sr = new StreamReader(Path.Combine(PathToFile, FileName)))
                {
                    var readText = "";
                    readText = await sr.ReadToEndAsync();
                    tbData.Text = readText;
                }
            }
            catch (IOException ex)
            {
                //catch error
                MessageBox.Show(ex.Message, @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}