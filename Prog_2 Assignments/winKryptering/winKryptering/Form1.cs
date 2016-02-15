using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winKryptering
{
    public partial class Form1 : Form
    {
        public string FileName { get; private set; }

        public Form1()
        {
            InitializeComponent();

            //Form settings
            FormBorderStyle = FormBorderStyle.Fixed3D;
            btnOpenFileDialog.Text = @"...";
            btnOpenFileDialog.Size = new Size(40, 22);
            

            //Label texts
            lblFile.Text = @"File:";
            lblEncryptText.Text = @"Text att kryptera";
            lblDecryptedText.Text = @"Krypterad text";

            //button texts
            btnOpen.Text = @"Öppna";
            btnSave.Text = @"Spara";
            btnQuit.Text = @"Avsluta";
            btnRovar.Text = @"Rövarspråket";
            btnILang.Text = @"I-språket";
            btnFikon.Text = @"Fikonspråket";

        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            FileName = dlg.FileName;
            tbFileLocation.Text = FileName;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (FileName == null)
                return;

            StreamReader streamReader = new StreamReader(FileName);
            tbEncrypt.Text = streamReader.ReadToEnd();

        }

        private void btnRovar_Click(object sender, EventArgs e)
        {

            if (tbEncrypt.Text == string.Empty)
                return;

            string textToEncrypt = tbEncrypt.Text;
            var convertedText = "";

            char[] charsToCheckFor =
            {
                'a',
                'A',
                'o',
                'O',
                'u',
                'U',
                'å',
                'Å',
                'e',
                'E',
                'i',
                'I',
                'y',
                'Y',
                'ä',
                'Ä',
                'ö',
                'Ö'
            };

            foreach (char t in textToEncrypt)
            {
                if (char.IsWhiteSpace(t))
                {
                    continue;
                    
                }
                if (charsToCheckFor.Contains(t))
                {
                    convertedText += t;
                }
                else
                {
                    convertedText += t;
                    convertedText += 'o';
                    convertedText += t;
                }
            }

            tbDecrypt.Text = convertedText;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
