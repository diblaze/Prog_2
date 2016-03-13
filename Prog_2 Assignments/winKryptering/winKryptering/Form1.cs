using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace winKryptering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <value>
        ///     The name of the file.
        /// </value>
        public string EncryptedFileName
        {
            get;
            private set;
        }
        public string UncryptedFileName
        {
            get;
            private set;
        }

        /// <summary>
        ///     Handles the Click event of the btnOpenFileDialog control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnEncryptedFileDialog_Click(object sender, EventArgs e)
        {
            //open a OpenFileDialog and ask the user to pick a file.
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = @"Data files | *.dat";
                openFileDialog.DefaultExt = "dat";

                //if user pressed any other button except "OK" then assume user probably canceled the dialog.
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    //do not do anything
                    return;
                }

                //if user pressed "OK", then assume this is the file the user wants to use.
                //set the public EncryptedFileName to current filename so we can access it from every method.
                EncryptedFileName = openFileDialog.FileName;
                //set the FileLocation text to current filename - provides visual hint to the user.
                tbFileLocation.Text = EncryptedFileName;
            }
        }

        /// <summary>
        ///     Handles the Click event of the btnSaveFileDialog control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnSaveFileDialog_Click(object sender, EventArgs e)
        {
            //open a SaveFileDialog and ask the user for a location/file to write to.
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = @"Data files | *.dat";
                saveFileDialog.DefaultExt = "dat";

                //if user pressed something else than "OK" then assume user canceled.
                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                //save the encrypted text to the user picked file.
                using (var streamWriter = new StreamWriter(saveFileDialog.FileName, false, Encoding.Default))
                {
                    streamWriter.WriteLine(tbEncryptedText.Text);
                }
            }
        }

        /// <summary>
        ///     Opens and reads a file, then putting it in the encrypt textbox.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            //if user has not picked a file to open, show error message.
            if (EncryptedFileName == null)
            {
                MessageBox.Show(@"Välj först en fil att öppna!", @"Varning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if user picked a file to open, open the file and input the text to the encrypt textbox.            
            using (var reader = new StreamReader(EncryptedFileName, Encoding.Default))
            {
                tbEncryptedText.Text = reader.ReadToEnd();
            }
        }

        /// <summary>
        ///     Encrypt text to Rövarspråk.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnRovar_Click(object sender, EventArgs e)
        {
            //if text is empty, show error message.
            if (tbTextToEncrypt.Text == string.Empty)
            {
                MessageBox.Show(@"Var vänlig och lägg till en text att enkryptera!",
                    @"Varning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            //Encrypt and set the encrypted textbox text.
            tbEncryptedText.Text = Encrypt.EncryptToRovar(tbTextToEncrypt.Text);
        }

        /// <summary>
        ///     Exit the program on user click.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///     Encrypt the text to I-språk.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnILang_Click(object sender, EventArgs e)
        {
            //if text is empty, show error message.
            if (tbTextToEncrypt.Text == string.Empty)
            {
                MessageBox.Show(@"Var vänlig och lägg till en text att enkryptera!",
                    @"Varning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            //Encrypt and set the encrypted textbox text.
            tbEncryptedText.Text = Encrypt.EncryptToILang(tbTextToEncrypt.Text);
        }

        /// <summary>
        ///     Removes all text from the encrypt and encrypted boxes.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnClean_Click(object sender, EventArgs e)
        {
            tbEncryptedText.Text = "";
            tbTextToEncrypt.Text = "";
        }

        /// <summary>
        /// Encrypt the text to Fikonspråk.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnFikon_Click(object sender, EventArgs e)
        {
            //if text is empty, show error message.
            if (tbTextToEncrypt.Text == string.Empty)
            {
                MessageBox.Show(@"Var vänlig och lägg till en text att enkryptera!",
                    @"Varning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            //Encrypt and set the encrypted textbox text.
            tbEncryptedText.Text = Encrypt.EncryptToFikon(tbTextToEncrypt.Text);

        }

        /// <summary>
        /// Handles the Click event of the btnUncryptedOpenFileDialog control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnUncryptedOpenFileDialog_Click(object sender, EventArgs e)
        {
            //open a OpenFileDialog and ask the user to pick a file.
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = @"Text Files | *.txt";
                openFileDialog.DefaultExt = "txt";

                //if user pressed any other button except "OK" then assume user probably canceled the dialog.
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    //do not do anything
                    return;
                }

                //if user pressed "OK", then assume this is the file the user wants to use.
                //set the public EncryptedFileName to current filename so we can access it from every method.
                UncryptedFileName = openFileDialog.FileName;
                //set the FileLocation text to current filename - provides visual hint to the user.
                tbUncryptedFileLocation.Text = UncryptedFileName;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnOpenDecrypt control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnOpenUncrypted_Click(object sender, EventArgs e)
        {
            //if user has not picked a file to open, show error message.
            if (UncryptedFileName == null)
            {
                MessageBox.Show(@"Välj först en fil att öppna!", @"Varning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if user picked a file to open, open the file and input the text to the encrypt textbox.            
            using (var reader = new StreamReader(UncryptedFileName, Encoding.Default))
            {
                tbTextToEncrypt.Text = reader.ReadToEnd();
            }
        }
    }
}