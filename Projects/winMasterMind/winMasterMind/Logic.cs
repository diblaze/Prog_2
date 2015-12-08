﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace winMasterMind
{
    internal class Logic
    {
        private readonly PlaceablePeg[] _placeablePegs;

        private Row[] _rowArray;
        public Peg[] CorrectPegs;
        public Peg[] GuessedPegs;

        public Logic(int howManyRows)
        {
            HowManyRows = howManyRows;
            //_guesses = 0;
            //_score = 0;
            CorrectPegs = new Peg[4];
            GuessedPegs = new Peg[4];
            _placeablePegs = new PlaceablePeg[10];
            //TODO: Add diffuculty setting
            _rowArray = new Row[howManyRows];

            CreateRows(10);
            GetRandomPegs();
        }

        //TODO: Add score system.
        //private int _score;


        public int HowManyRows { get; private set; } //how many rows the user can guess until game over
        public bool UserHasWon { get; private set; }

        public int TotalRows()
        {
            return _rowArray.Count();
        }

        /// <summary>
        ///     Reinits the <c>GameBoard</c> - restarting.
        /// </summary>
        public void RestartGame(int howManyRows)
        {
            HowManyRows = howManyRows;
            //_score = 0;
            CorrectPegs = new Peg[4];
            GuessedPegs = new Peg[4];
            _rowArray = new Row[howManyRows];

            CreateRows(10);
            GetRandomPegs();
        }

        /// <summary>
        ///     Populates the game list with pegs.
        /// </summary>
        private void GetRandomPegs()
        {
            var rnd = new Random();
            for (var i = 0; i < 4; i++)
            {
                var peg = new Peg(rnd.Next(0, 9));
                CorrectPegs[i] = peg;
            }
        }

        /// <summary>
        ///     Checks and returns how many pegs were correctly guessed.
        ///     Finishes active row.
        /// </summary>
        /// <returns>How many pegs were correctly guessed.</returns>
        public void CheckGuess()
        {
            var rw = GetActiveRow(); //Get active row to add checking pegs
            //int count = 0; //how many correct pegs we got

            //the logic
            //pegsTop and pegsBot all have -1
            //but when there is a black or white peg, it will switch the corrosponding array item to 1 
            //this will make sure that we skip pegs that are already accounted for => if they are correct then skip.
            int[] pegsTop = {-1, -1, -1, -1};
            int[] pegsBot = {-1, -1, -1, -1};

            var blackPegs = 0; //how many black pegs?
            var whitePegs = 0; //how many white pegs?

            //loop through the user guessed row to check for black pegs
            for (var i = 0; i < 4; i++)
            {
                if (GuessedPegs[i].Colour != CorrectPegs[i].Colour)
                {
                    continue; //if the guess is not right, continue
                }

                //TODO: Add black peg display.
                var peg = new Peg(0); //create a new peg to be added to the checking box to the current row
                rw.CheckingPegs.Add(peg); //add to checking box of current row
                //count++; //debug - how many black pegs
                blackPegs++; //how many black pegs?
                pegsTop[i] = 1; //set the arrays to 1 => skip next loop
                pegsBot[i] = 1;
            }

            //loop through the user guessed row to check for white pegs
            for (var i = 0; i < 4; i++)
            {
                //white pegs = correct colour but wrong position.
                //therefore we need to check one user guessed peg to ALL of the correct pegs. 
                for (var j = 0; j < 4; j++)
                {
                    //if i == j, we missed it in the black peg checking...
                    //if pegsTop == 1 or pegsBot == 1 then we have already checked them in the black checking
                    if ((i == j) || (pegsTop[i] == 1) || (pegsBot[j] == 1))
                    {
                        continue;
                    }

                    //if user guessed peg colour is not equal to correct peg colour, then continue to next 
                    if (GuessedPegs[i].Colour != CorrectPegs[j].Colour)
                    {
                        continue;
                    }

                    //TODO: Add white peg display
                    var peg = new Peg(7); // new peg with white colour
                    rw.CheckingPegs.Add(peg); // add to checking box of current row
                    pegsTop[i] = 1; //set to 1 so we don't check it again
                    pegsBot[j] = 1; //set to 1 so we don't check it again
                    whitePegs++; //add to whitePegs
                    break;
                }
            }

            UserHasWon = FinishRow();

            //PopulateCheckingBox(rw, blackPegs, whitePegs);

            MessageBox.Show(whitePegs + @" white pegs");
            MessageBox.Show(blackPegs + @" black pegs");
        }

        /// <summary>
        ///     Creates <c>rows</c>.
        /// </summary>
        /// <param name="rowAmount">How many <c>rows</c>?</param>
        private void CreateRows(int rowAmount)
        {
            for (var i = 0; i < rowAmount; i++)
            {
                _rowArray[i] = new Row(i);
            }
        }

        /// <summary>
        ///     Place user <c>peg</c>.
        /// </summary>
        /// <param name="position">Which <c>cell</c>? Spanning from 0 to 3, left to right.</param>
        /// <param name="peg"><c>Peg</c> which is placed by <c>user</c>.</param>
        public bool PlacePeg(int position, Peg peg)
        {
            foreach (var rw in _rowArray.Where(rw => rw.Active && rw.Cells[position].IsEmpty))
            {
                rw.Cells[position].SetPeg(peg);
                GuessedPegs[position] = peg;
            }
            foreach (var rw in _rowArray.Where(rw => rw.Active))

            {
                var check = false;
                for (var i = 0; i < 4; i++)
                {
                    if (rw.Cells[i].IsEmpty)
                    {
                        check = false;
                        break;
                    }
                    check = true;
                }
                if (check)
                {
                    HowManyRows--;
                    CheckGuess();
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        ///     Removes user <c>peg</c>.
        /// </summary>
        /// <param name="position"></param>
        public void RemovePeg(int position)
        {
            foreach (var rw in _rowArray.Where(rw => rw.Active && !rw.Cells[position].IsEmpty))
            {
                rw.Cells[position].RemovePeg();
                GuessedPegs[position] = null;
            }
        }

        /// <summary>
        ///     Disables the current <c>row</c> and activates a new <c>row</c>.
        /// </summary>
        /// <returns><c>True</c> if user has won. <c>False</c> if user has not yet won.</returns>
        public bool FinishRow()
        {
            int rowId; //next row id to activate.
            var tempBlackCount = 0;

            //finds the current active row.
            foreach (var rw in _rowArray.Where(rw => rw.Active))
            {
                rowId = rw.RowId;
                rw.Active = false; //disable row

                //check if user has filled the checking row
                if (rw.CheckingPegs.Count == 4)
                {
                    for (var i = 0; i < 4; i++)
                    {
                        //if user has guessed a peg right, add to temp int.
                        if (rw.CheckingPegs[i].Colour == PegColours.Black)
                        {
                            tempBlackCount++;
                        }
                    }
                }

                if (tempBlackCount == 4)
                {
                    MessageBox.Show(@"You won!");
                    return true;
                }

                if (tempBlackCount != 4)
                {
                    //find the next row to activate.
                    var rowToActivate = _rowArray.FirstOrDefault(row => row.RowId == rowId + 1);
                    if (rowToActivate != null)
                    {
                        rowToActivate.Active = true; //activate row.
                        return false;
                    }
                }
            }
            return false;
        }

        public Row GetActiveRow()
        {
            return _rowArray.FirstOrDefault(rw => rw.Active);
        }
    }
}