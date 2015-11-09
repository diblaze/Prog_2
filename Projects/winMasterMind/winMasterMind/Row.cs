using System.Collections.Generic;
using System.Drawing;

namespace winMasterMind
{
    public class Row
    {
        public Cell[] Cells;
        public List<Peg> CheckingPegs;
        public bool Active;

        public int RowId { get; private set; }

        public Row(int rowId)
        {
            RowId = rowId;
            Cells = new Cell[4];
            CheckingPegs = new List<Peg>();
            //set the first row to active
            if (RowId == 0)
            {
                Active = true;
            }
            for (var i = 0; i < 4; i++)
            {
                Cells[i] = new Cell();
            }
            //for (var i = 0; i < 4; i++)
            //{
            //    CheckingCells[i] = new CheckingCell();
            //}
        }


        public class Cell
        {
            private Color _colour; // colour of the cell
            private bool _isEmpty = true;

            /// <summary>
            /// Colour the cell to peg colour.
            /// </summary>
            /// <param name="peg"><c>Peg</c> that is placed in cell.</param>
            public void SetPeg(Peg peg)
            {
                //set GUI cell colour
                switch (peg.Colour)
                {
                    case PegColours.Black:
                        _colour = Color.Black;
                        break;
                    case PegColours.Blue:
                        _colour = Color.Blue;
                        break;
                    case PegColours.Brown:
                        _colour = Color.Brown;
                        break;
                    case PegColours.Green:
                        _colour = Color.Green;
                        break;
                    case PegColours.Orange:
                        _colour = Color.Orange;
                        break;
                    case PegColours.Purple:
                        _colour = Color.Purple;
                        break;
                    case PegColours.Red:
                        _colour = Color.Red;
                        break;
                    case PegColours.White:
                        _colour = Color.White;
                        break;
                    case PegColours.Yellow:
                        _colour = Color.Yellow;
                        break;
                }

                _isEmpty = false;
            }

            /// <summary>
            /// Sets cell to empty.
            /// </summary>
            public void RemovePeg()
            {
                _colour = Color.Empty;
                _isEmpty = true;
            }

            public bool IsEmpty => _isEmpty;
        }

        public class CheckingCell
        {
            private Color _colour;

            public void SetColour(bool isCorrect)
            {
                _colour = isCorrect ? Color.White : Color.Black;
            }
        }
    }
}