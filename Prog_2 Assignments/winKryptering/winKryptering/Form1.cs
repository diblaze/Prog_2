using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace winKryptering
{
    public partial class Form1 : Form
    {
        private readonly char[] _vowelsToCheckFor =
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

        public string FileName
        {
            get;
            private set;
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            FileName = openFileDialog.FileName;
            tbFileLocation.Text = FileName;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (FileName == null)
            {
                return;
            }

            var streamReader = new StreamReader(FileName);
            tbTextToEncrypt.Text = streamReader.ReadToEnd();
        }

        private void btnRovar_Click(object sender, EventArgs e)
        {
            if (tbTextToEncrypt.Text == string.Empty)
            {
                return;
            }

            string textToEncrypt = tbTextToEncrypt.Text;
            string convertedText = "";

            foreach (char t in textToEncrypt)
            {
                if (char.IsWhiteSpace(t))
                {
                    convertedText += t;
                }
                else if (_vowelsToCheckFor.Contains(t))
                {
                    convertedText += t;
                }
                else
                {
                    convertedText += t;
                    convertedText += 'o';
                    convertedText += t.ToString().ToLower();
                }
            }

            tbEncryptedText.Text = convertedText;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            using (var sw = new StreamWriter(saveFileDialog.FileName))
            {
                sw.WriteLine(tbEncryptedText.Text);
            }
        }

        private void btnILang_Click(object sender, EventArgs e)
        {
            if (tbTextToEncrypt.Text == string.Empty)
            {
                return;
            }

            string textToEncrypt = tbTextToEncrypt.Text;
            string convertedText = "";

            foreach (char t in textToEncrypt)
            {
                if (char.IsWhiteSpace(t))
                {
                    convertedText += t;
                }
                else if (_vowelsToCheckFor.Contains(t))
                {
                    convertedText += 'i';
                }
                else
                {
                    convertedText += t;
                }
            }

            tbEncryptedText.Text = convertedText;
        }
    }
}