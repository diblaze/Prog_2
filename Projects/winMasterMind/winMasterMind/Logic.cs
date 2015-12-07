using System;
using System.Linq;
using System.Windows.Forms;

namespace winMasterMind
{
    internal class Logic
    {
        private readonly PlaceablePeg[] _placeablePegs;
        private int _guesses;
        private Row[] _rowArray;
        private int _score;
        public Peg[] CorrectPegs;
        public Peg[] GuessedPegs;

        public Logic()
        {
            _guesses = 0;
            _score = 0;
            CorrectPegs = new Peg[4];
            GuessedPegs = new Peg[4];
            _placeablePegs = new PlaceablePeg[10];
            //TODO: Add diffuculty setting
            _rowArray = new Row[10];

            CreateRows(10);
            GetRandomPegs();
        }

        public int TotalRows()
        {
            return _rowArray.Count();
        }

        /// <summary>
        ///     Reinits the <c>GameBoard</c> - restarting.
        /// </summary>
        public void RestartGame()
        {
            _guesses = 4;
            _score = 0;
            CorrectPegs = new Peg[4];
            GuessedPegs = new Peg[4];
            _rowArray = new Row[10];

            CreateRows(10);
            GetRandomPegs();
        }

        public void CreatePlaceablePegs()
        {
            _placeablePegs[0] = new PlaceablePeg(0);
            _placeablePegs[1] = new PlaceablePeg(1);
            _placeablePegs[2] = new PlaceablePeg(2);
            _placeablePegs[3] = new PlaceablePeg(3);
            _placeablePegs[4] = new PlaceablePeg(4);
            _placeablePegs[5] = new PlaceablePeg(5);
            _placeablePegs[6] = new PlaceablePeg(6);
            _placeablePegs[7] = new PlaceablePeg(7);
            _placeablePegs[8] = new PlaceablePeg(8);
        }

        /// <summary>
        ///     Populates the game list with pegs.
        /// </summary>
        private void GetRandomPegs()
        {
            Random rnd = new Random();
            for (var i = 0; i < 4; i++)
            {
                Peg peg = new Peg(rnd.Next(0, 9));
                CorrectPegs[i] = peg;
            }
        }

        /// <summary>
        ///     Checks and returns how many pegs were correctly guessed.
        /// </summary>
        /// <param name="guess">User guess array</param>
        /// <returns>How many pegs were correctly guessed.</returns>
        public void CheckGuess()
        {
            Row rw = GetActiveRow(); //Get active row to add checking pegs
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
                Peg peg = new Peg(0); //create a new peg to be added to the checking box to the current row
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
                    Peg peg = new Peg(7); // new peg with white colour
                    rw.CheckingPegs.Add(peg); // add to checking box of current row
                    pegsTop[i] = 1; //set to 1 so we don't check it again
                    pegsBot[j] = 1; //set to 1 so we don't check it again
                    whitePegs++; //add to whitePegs
                    break;
                }
            }

            FinishRow();

            PopulateCheckingBox(rw, blackPegs, whitePegs);

            MessageBox.Show(whitePegs + @" white pegs");
            MessageBox.Show(blackPegs + @" black pegs");
        }

        private void PopulateCheckingBox(Row rw, int blackPegs, int whitePegs)
        {
            //TODO: Add checking box image
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
            foreach (Row rw in _rowArray.Where(rw => rw.Active && rw.Cells[position].IsEmpty))
            {
                rw.Cells[position].SetPeg(peg);
                GuessedPegs[position] = peg;
            }
            foreach (Row rw in _rowArray.Where(rw => rw.Active))

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
            foreach (Row rw in _rowArray.Where(rw => rw.Active && !rw.Cells[position].IsEmpty))
            {
                rw.Cells[position].RemovePeg();
                GuessedPegs[position] = null;
            }
        }

        /// <summary>
        ///     Disables the current <c>row</c> and activates a new <c>row</c>.
        /// </summary>
        public void FinishRow()
        {
            var rowId = 0; //next row id to activate.
            var blacks = 0;

            //finds the current active row.
            foreach (Row rw in _rowArray.Where(rw => rw.Active))
            {
                rowId = rw.RowId;
                rw.Active = false; //disable
                for (var i = 0; i < 4; i++)
                {
                    if (rw.CheckingPegs.Count == 0)
                    {
                        break;
                    }
                    if (rw.CheckingPegs[i].Colour == PegColours.Black)
                    {
                        blacks++;
                    }
                }
                if (blacks == 4)
                {
                    MessageBox.Show("You won!");
                }
                else if (blacks != 4)
                {
                    //find the next row to activate.
                    Row rowToActivate = _rowArray.FirstOrDefault(row => row.RowId == rowId + 1);
                    if (rowToActivate != null)
                    {
                        rowToActivate.Active = true; //activate row.
                    }
                }

                break;
            }
        }

        public Row GetActiveRow()
        {
            return _rowArray.FirstOrDefault(rw => rw.Active);
        }
    }
}