using System;
using System.Linq;
using System.Windows.Forms;

namespace winMasterMind
{
    public partial class Form1 : Form
    {
        private readonly GameBoard gameBoard = new GameBoard();
        public Peg PegToPlace;

        public Form1()
        {
            InitializeComponent();
            //GameBoard gameBoard = new GameBoard();

            gameBoard.

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