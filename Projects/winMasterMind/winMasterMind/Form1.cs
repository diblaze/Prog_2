using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace winMasterMind
{
    public partial class Form1 : Form
    {
        private readonly Logic _logic = new Logic(10); //init game logic
        private string _currentRowId = "row1"; //current active row in GUI
        private string _previousRowId = "row0"; //current active row in GUI
        private bool _newRow; //if true - enable new row in GUI
        public Peg PegToPlace; //what peg used is putting in a box.

        public Form1()
        {
            InitializeComponent();

            //create all panels, pictureboxes.
            PopulateGui(_logic.TotalRows());
        }

        /// <summary>
        ///     Creates the panels holding the <c>Logic.Rows</c>.
        /// </summary>
        /// <param name="rowsAmount">How many panels to create.</param>
        private void PopulateGui(int rowsAmount)
        {
            //set flpRowDock to anchor top and bottom (staying in place)
            flpRowDock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            flpRowDock.BackColor = Color.Gainsboro;
            flpRowDock.Padding = new Padding(10);

            #region Panels

            //init a new panel array.
            var rowPanels = new Panel[rowsAmount + 1];

            //for each position in rowsAmount, create a new panel with pictureboxes
            for (var i = 1; i < rowsAmount + 1; i++)
            {
                #region rowPanels

                var pnl = new FlowLayoutPanel
                {
                    BackColor = Color.DarkGray,
                    Width = 443,
                    Height = 50,
                    BorderStyle = BorderStyle.FixedSingle,
                    Anchor = AnchorStyles.Bottom,
                    Name = "row" + i
                };

                //if first panel is created, set all other panels to non visible and disabled.
                if (i >= 2)
                {
                    pnl.Enabled = false;
                    pnl.Visible = false;
                }

                #endregion

                #region rowClickableBoxes

                //four pictureboxes
                for (var j = 0; j < 4; j++)
                {
                    var pegClickable = new PictureBox
                    {
                        Name = "pegClickable" + j,
                        BackColor = Color.White,
                        Width = 40,
                        Height = 40,
                        Margin = new Padding(20, 5, 10, 5),
                        BorderStyle = BorderStyle.Fixed3D
                    };
                    pegClickable.MouseClick += HandleMouseClick;

                    pnl.Controls.Add(pegClickable);
                }

                #endregion

                #region pegCheckBoxes

                var pegCheckBox = new PictureBox
                {
                    Name = "checkBox",
                    Width = 40,
                    Height = 40,
                    Margin = new Padding(60, 5, 20, 5),
                    Anchor = AnchorStyles.Right,
                    BorderStyle = BorderStyle.Fixed3D,
                    BackColor = Color.DarkGray
                };


                pnl.Controls.Add(pegCheckBox);

                #endregion

                //add current iteration panel to rowPanels array.
                rowPanels[i] = pnl;
            }

            //for each panel in rowPanels array - add it to the main panel dock.
            foreach (var c in rowPanels)
                flpRowDock.Controls.Add(c);

            #endregion
        }

        /// <summary>
        ///     Handle the picturebox clicks.
        /// </summary>
        /// <param name="sender">Control that was clicked on.</param>
        private void HandleMouseClick(object sender, MouseEventArgs e)
        {
            //retreive sender as picturebox to be able to modify.
            var pegBox = sender as PictureBox;

            //Suspend the layout while CPU does the checking.
            SuspendLayout();

            //If user has picked a peg to place
            if (PegToPlace != null)
            {
                //if the picturebox exists
                if (pegBox != null)
                {
                    //pegBox color changes to the peg color.
                    pegBox.BackColor = Color.FromName(PegToPlace?.Colour.ToString());
                    //make the game logic place a peg for us in the row, check the guesses, finish the row. 
                    //returns true if GUI needs to enable a new row.
                    _newRow = _logic.PlacePeg(Convert.ToInt32(pegBox.Name.Substring(12)), PegToPlace);
                }
            }
            //If user has run out of guesses
            if (_logic.HowManyRows == 0)
            {
                UpdateStatus(false, true);
                UpdateCheckBoxImage();
            }
            //If user still has guesses left
            else
            {
                
                UpdateStatus(_newRow, false);
            }

            //resume the drawing
            ResumeLayout();
            //refresh GUI
            Refresh();
        }

        private void UpdateCheckBoxImage()
        {
            foreach (
                var panel in
                    flpRowDock.Controls.Cast<Panel>().Where(panel => panel.Name == _previousRowId && !panel.Enabled))
            {
                foreach (var box in panel.Controls.Cast<PictureBox>().Where(box => box.Name == "checkBox"))
                {
                    var whitePegs = _logic.GetWhitePegs();
                    var blackPegs = _logic.GetBlackPegs();

                    #region Mixed Checking Pegs

                    if (whitePegs == 3 && blackPegs == 1)
                    {
                        box.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "images/mixed/black1white3.png");
                        break;
                    }
                    if (whitePegs == 2 && blackPegs == 2)
                    {
                        box.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "images/mixed/black2white2.png");
                        break;
                    }
                    if (whitePegs == 1 && blackPegs == 3)
                    {
                        box.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "images/mixed/black3white1.png");
                        break;
                    }
                    if (whitePegs == 2 && blackPegs == 1)
                    {
                        box.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "images/mixed/black1white2none1.png");
                        break;
                    }
                    if (whitePegs == 1 && blackPegs == 2)
                    {
                        box.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "images/mixed/black2white1none1.png");
                        break;
                    }
                    if (whitePegs == 1 && blackPegs == 1)
                    {
                        box.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "images/mixed/black1white1none2.png");
                        break;
                    }

                    #endregion

                    #region Only White Checking Pegs

                    if (whitePegs == 4)
                    {
                        box.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "images/onlywhite/white4.png");
                        break;
                    }
                    if (whitePegs == 3)
                    {
                        box.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "images/onlywhite/white3.png");
                        break;
                    }
                    if (whitePegs == 2)
                    {
                        box.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "images/onlywhite/white2.png");
                        break;
                    }
                    if (whitePegs == 1)
                    {
                        box.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "images/onlywhite/white1.png");
                        break;
                    }

                    #endregion

                    #region #region Only Black Checking Pegs

                    if (blackPegs == 4)
                    {
                        box.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "images/onlyblack/black4.png");
                        break;
                    }
                    if (blackPegs == 3)
                    {
                        box.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "images/onlyblack/black3.png");
                        break;
                    }
                    if (blackPegs == 2)
                    {
                        box.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "images/onlyblack/black2.png");
                        break;
                    }
                    if (blackPegs == 1)
                    {
                        box.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "images/onlyblack/black1.png");
                        break;
                    }

                    #endregion
                }
            }
        }

        /// <summary>
        ///     Checks and updates the GUI according to the game logic.
        /// </summary>
        /// <param name="activateNewRow">Is a new <c>row</c> needed?</param>
        /// <param name="noMoreRowsLeft">Has the user run out of guesses?</param>
        private void UpdateStatus(bool activateNewRow, bool noMoreRowsLeft)
        {
            if (activateNewRow)
            {
                //reset new row variable.
                _newRow = false;

                

                //find current active row and disable it.
                foreach (var pnl in flpRowDock.Controls.Cast<Panel>().Where(pnl => pnl.Name == _currentRowId))
                {
                    pnl.Enabled = false;
                    
                }

                foreach (var pnlToActivate in flpRowDock.Controls.Cast<Panel>())
                {
                    //Find the current row
                    var tempCurrentRowId = int.Parse(_currentRowId.Substring(3));
                    

                    //Find the next row
                    var idParsed = int.Parse(pnlToActivate.Name.Substring(3));

                    //if we found wrong next row, continue
                    if (idParsed != tempCurrentRowId + 1)
                        continue;

                    

                    //enable the panel and its visiblity.
                    pnlToActivate.Enabled = true;
                    pnlToActivate.Visible = true;

                    //set previous rowid to make updating checkbox easier.
                    _previousRowId = _currentRowId;
                    //update current rowid variable for next time.
                    _currentRowId = "row" + idParsed;

                    UpdateCheckBoxImage();
                    break;
                    
                }
            }
            //if user has won
            if (_logic.UserHasWon)
            {
                //disable every panel and its buttons
                foreach (var panel in flpRowDock.Controls.Cast<Panel>())
                {
                    panel.Enabled = false;
                }
                //TODO: Add better game over alert box.
                var result = MessageBox.Show(
                    @"You have won! ""\n"" Press Yes to play again. Press No to quit the game. Press Cancel to dismiss this message.",
                    @"Game Over!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                switch (result)
                {
                    case DialogResult.Yes:
                        RestartGame(_logic.TotalRows());
                        noMoreRowsLeft = false;
                        break;
                    case DialogResult.No:
                        Application.Exit();
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
            //if user has not won and has run out of rows to guess on.
            else if (!_logic.UserHasWon && noMoreRowsLeft)
            {
                //disable every panel and its buttons
                foreach (var panel in flpRowDock.Controls.Cast<Panel>())
                {
                    panel.Enabled = false;
                }
                //TODO: Add better game over alert box.
                var result = MessageBox.Show(
                    @"You have lost! ""\n"" Press Yes to play again. Press No to quit the game. Press Cancel to dismiss this message.",
                    @"Game Over!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                switch (result)
                {
                    case DialogResult.Yes:
                        RestartGame(_logic.TotalRows());
                        break;
                    case DialogResult.No:
                        Application.Exit();
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
        }

        /// <summary>
        ///     Restarts the game.
        /// </summary>
        /// <param name="totalRows">Amount of <c>Rows</c> to restart the game with.</param>
        private void RestartGame(int totalRows)
        {
            //Cast all controls in the main panel dock to an array and dispose of them.
            foreach (var control in flpRowDock.Controls.Cast<Panel>().ToArray())
            {
                control.Dispose();
            }
            //Tell the game logic to restart the game.
            _logic.RestartGame(totalRows);

            //Repopulate the GUI accordingly to the game logic.
            PopulateGui(totalRows);
        }

        /// <summary>
        ///     Get the <c>Peg</c> user wants to place.
        /// </summary>
        /// <param name="sender">Which peg button was pressed.</param>
        private void PegClicked(object sender, EventArgs e)
        {
            var color = sender as Button;

            switch (color?.Name)
            {
                case "btnBlack":
                    PegToPlace = new Peg(0);
                    break;
                case "btnRed":
                    PegToPlace = new Peg(1);
                    break;
                case "btnGreen":
                    PegToPlace = new Peg(2);
                    break;
                case "btnYellow":
                    PegToPlace = new Peg(3);
                    break;
                case "btnBlue":
                    PegToPlace = new Peg(4);
                    break;
                case "btnOrange":
                    PegToPlace = new Peg(5);
                    break;
                case "btnBrown":
                    PegToPlace = new Peg(6);
                    break;
                case "btnWhite":
                    PegToPlace = new Peg(7);
                    break;
                case "btnPurple":
                    PegToPlace = new Peg(8);
                    break;
            }
        }
    }
}