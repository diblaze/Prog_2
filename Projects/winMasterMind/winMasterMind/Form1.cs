using System;
using System.Linq;
using System.Windows.Forms;

namespace winMasterMind
{
    public partial class Form1 : Form
    {
        private readonly GameBoard gameBoard = new GameBoard();
        public Peg pegToPlace;

        public Form1()
        {
            InitializeComponent();
            //GameBoard gameBoard = new GameBoard();

            foreach (Peg peg in gameBoard.CorrectPegs)
            {
                lvCorrectPegs.Items.Add(peg.Colour.ToString());
            }
            label1.Text = "1";
            label2.Text = "2";
            label3.Text = "3";
            label4.Text = "4";
        }

        private void PegClicked(object sender, EventArgs e)
        {
            Button color = sender as Button;

            switch (color?.Name)
            {
                case "button1":
                    pegToPlace = new Peg(0);
                    break;
                case "button2":
                    pegToPlace = new Peg(4);
                    break;
                case "button3":
                    pegToPlace = new Peg(1);
                    break;
                case "button4":
                    pegToPlace = new Peg(3);
                    break;
                case "button5":
                    pegToPlace = new Peg(2);
                    break;
                case "button6":
                    pegToPlace = new Peg(7);
                    break;
                case "button7":
                    pegToPlace = new Peg(5);
                    break;
                case "button8":
                    pegToPlace = new Peg(8);
                    break;
            }
        }

        private void SetPeg(object sender, EventArgs e)
        {
            Label position = sender as Label;
            var pos = 0;

            switch (position.Name)
            {
                case "label1":
                    pos = 0;
                    break;
                case "label2":
                    pos = 1;
                    break;
                case "label3":
                    pos = 2;
                    break;
                case "label4":
                    pos = 3;
                    break;
            }

            gameBoard.PlacePeg(pos, pegToPlace);

            listView1.Clear();

            foreach (Peg peg in gameBoard.GuessedPegs.Where(peg => peg != null))
            {
                listView1.Items.Add(peg.Colour.ToString());
            }

            int i = gameBoard.GuessedPegs.Count(peg => peg != null);
            var correct = 0;
            if (i == 4)
            {
                correct = gameBoard.CheckGuess(gameBoard.GuessedPegs);
            }

            if (correct == 4 && i == 4)
            {
                MessageBox.Show("YOU WON!");
            }
            else
            {
                MessageBox.Show(correct + " rätt av 4.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listView1.Clear();

            foreach (Peg peg in gameBoard.GuessedPegs.Where(peg => peg != null))
            {
                listView1.Items.Add(peg.Colour.ToString());
            }
        }
    }
}