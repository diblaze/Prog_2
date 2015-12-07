using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace winMasterMind
{
    public partial class Form1 : Form
    {
        private readonly Logic _logic = new Logic();
        public Peg PegToPlace;
        private Peg[] pegGuess = new Peg[4];
        private string _currentRowId = "row1";
        private bool _newRow;
        public Form1()
        {
            InitializeComponent();
            //GameBoard gameBoard = new GameBoard();

            PopulatePanel(_logic.TotalRows());
            

        }

        private void PopulatePanel(int rowsAmount)
        {
            var rowPanels = new Panel[rowsAmount+1];
            for (var i = 1; i < rowsAmount+1; i++)
            {
                FlowLayoutPanel pnl = new FlowLayoutPanel
                            {
                                BackColor = Color.Blue,
                                Width = 850,
                                Height = 50,
                                Name = "row" + i
                            };
                if (i >= 2)
                {
                    pnl.Enabled = false;
                    pnl.Visible = false;
                }
             
                for (int j = 0; j < 4; j++)
                {
                    PictureBox pegEmpty = new PictureBox
                                          {
                                              Name = "pegEmpty" + j,
                                              BackColor = Color.Gray,
                                              Width = 40,
                                              Height = 40,
                                              Margin = new Padding(20, 5,10,5)};
                    pegEmpty.MouseClick += HandleMouseClick;

                    pnl.Controls.Add(pegEmpty);
     

                }
                PictureBox pegCheckBox = new PictureBox
                                         {
                                             Name = "checkBox",
                                             Width = 40,
                                             Height = 40,
                                             Margin = new Padding(60, 5, 20, 5),
                                             BackColor = Color.Green
                                         };
                
                pnl.Controls.Add(pegCheckBox);
                rowPanels[i] = pnl;

            }
            foreach(Panel c in rowPanels)
            flpRowDock.Controls.Add(c);
        }

        private void HandleMouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pegBox = sender as PictureBox;
            SuspendLayout();
            if (PegToPlace != null)
            {
                if (pegBox != null)
                {
                    pegBox.BackColor = Color.FromName(PegToPlace?.Colour.ToString());
                    //pegGuess[Convert.ToInt32(pegBox.Name.Substring(8))] = new Peg((int) PegToPlace.Colour);
                    _newRow = _logic.PlacePeg(Convert.ToInt32(pegBox.Name.Substring(8)), PegToPlace);
                }

            }
            UpdateStatus(_newRow);
            ResumeLayout();
            Refresh();
        }

        private void UpdateStatus(bool activateNewRow)
        {
            if (activateNewRow)
            {
                _newRow = false;
                string tempRowId = _currentRowId.Substring(3);
                int tempCurrentRowId = int.Parse(tempRowId);

                foreach (Panel pnl in flpRowDock.Controls.Cast<Panel>().Where(pnl => pnl.Name == _currentRowId))
                {
                    pnl.Enabled = false;
                }

                foreach (Panel pnlToActivate in flpRowDock.Controls)
                {
                    string substringId = pnlToActivate.Name.Substring(3);
                    int idParsed = int.Parse(substringId);

                    if (idParsed != tempCurrentRowId + 1)
                        continue;

                    pnlToActivate.Enabled = true;
                    pnlToActivate.Visible = true;

                    _currentRowId = "row" + idParsed;
                    break;
                }

            }

        }

        private void PegClicked(object sender, EventArgs e)
        {
            Button color = sender as Button;

            switch (color?.Name)
            {
                case "button1":
                    PegToPlace = new Peg(0);
                    break;
                case "button2":
                    PegToPlace = new Peg(4);
                    break;
                case "button3":
                    PegToPlace = new Peg(1);
                    break;
                case "button4":
                    PegToPlace = new Peg(3);
                    break;
                case "button5":
                    PegToPlace = new Peg(2);
                    break;
                case "button6":
                    PegToPlace = new Peg(7);
                    break;
                case "button7":
                    PegToPlace = new Peg(5);
                    break;
                case "button8":
                    PegToPlace = new Peg(8);
                    break;
            }
        }

    }
}