﻿using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace winMasterMind
{
    internal class GameBoard
    {
        private int _guesses;
        private int _score;
        public Peg[] CorrectPegs;
        public Peg[] GuessedPegs;
        public PlaceablePeg[] PlaceablePegs;
        public Row[] RowArray;

        public GameBoard()
        {
            _guesses = 0;
            _score = 0;
            CorrectPegs = new Peg[4];
            GuessedPegs = new Peg[4];
            PlaceablePegs = new PlaceablePeg[10];
            //TODO: Add diffuculty setting
            RowArray = new Row[10];

            CreateRows(10);
            GetRandomPegs();

        }

        /// <summary>
        /// Reinits the <c>GameBoard</c> - restarting.
        /// </summary>
        public void RestartGame()
        {
            _guesses = 4;
            _score = 0;
            CorrectPegs = new Peg[4];
            GuessedPegs = new Peg[4];
            RowArray = new Row[11];

            CreateRows(10);
        //    GetRandomPegs();
        }

        public void CreatePlaceablePegs()
        {
            PlaceablePegs[0] = new PlaceablePeg(0);
            PlaceablePegs[1] = new PlaceablePeg(1);
            PlaceablePegs[2] = new PlaceablePeg(2);
            PlaceablePegs[3] = new PlaceablePeg(3);
            PlaceablePegs[4] = new PlaceablePeg(4);
            PlaceablePegs[5] = new PlaceablePeg(5);
            PlaceablePegs[6] = new PlaceablePeg(6);
            PlaceablePegs[7] = new PlaceablePeg(7);
            PlaceablePegs[8] = new PlaceablePeg(8);
        }

        /// <summary>
        ///     Populates the game list with pegs.
        /// </summary>
        public void GetRandomPegs()
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
        public int CheckGuess(Peg[] guess)
        {
            int count = 0;
            int correctCell = 0;
            int cell = -1;
            //if user has guessed more or less pegs than asked for
            //return guess.Length != CorrectPegs.Length ? 0 : guess.Where((t, i) => t == CorrectPegs[i]).Count();
            foreach (Peg peg1 in GuessedPegs)
            {
                cell++;
                if(peg1 == null)
                    continue;
                foreach (Peg peg2 in CorrectPegs)
                {
                    if (peg1.Colour == peg2.Colour)
                    {
                        count++;
                    }
                    if (CorrectPegs[cell].Colour == GuessedPegs[cell].Colour)
                    {
                        correctCell++;
                    }
                }
            }
            foreach (Row rw in RowArray)
            {
                if (rw.Active)
                {
                    for (int i = 0; i < correctCell; i++)
                    {
                        rw.CheckingCells[i].SetColour(true);
                    }

                    if (count > correctCell)
                    {
                        rw.CheckingCells[3].SetColour(false);
                    }
                }
            }
            return count;
        }

        /// <summary>
        ///     Creates <c>rows</c>.
        /// </summary>
        /// <param name="rowAmount">How many <c>rows</c>?</param>
        public void CreateRows(int rowAmount)
        {
            for (var i = 0; i < rowAmount; i++)
            {
                RowArray[i] = new Row(i);
            }
        }

        /// <summary>
        ///     Place user <c>peg</c>.
        /// </summary>
        /// <param name="position">Which <c>cell</c>? Spanning from 0 to 3, left to right.</param>
        /// <param name="peg"><c>Peg</c> which is placed by <c>user</c>.</param>
        public void PlacePeg(int position, Peg peg)
        {
            foreach (Row rw in RowArray.Where(rw => rw.Active && rw.Cells[position].IsEmpty))
            {
                rw.Cells[position].SetPeg(peg);
                GuessedPegs[position] = peg;
            }
        }

        /// <summary>
        ///     Removes user <c>peg</c>.
        /// </summary>
        /// <param name="position"></param>
        public void RemovePeg(int position)
        {
            foreach (Row rw in RowArray.Where(rw => rw.Active && !rw.Cells[position].IsEmpty))
            {
                rw.Cells[position].RemovePeg();
                GuessedPegs[position] = null;
            }
        }

        /// <summary>
        /// Disables the current <c>row</c> and activates a new <c>row</c>.
        /// </summary>
        public void FinishRow()
        {
            var rowId = 0; //next row id to activate.

            //finds the current active row.
            foreach (Row rw in RowArray.Where(rw => rw.Active))
            {
                rowId = rw.RowId; 
                rw.Active = false; //disable
            }
            //find the next row to activate.
            Row rowToActivate = RowArray.FirstOrDefault(row => row.RowId == rowId + 1);
            if (rowToActivate != null)
            {
                rowToActivate.Active = true; //activate row.
            }
        }
    }
}