using System.Collections.Generic;
using System.Drawing;

namespace winMasterMind
{
    public class Row
    {
        public bool Active;
        public Cell[] Cells;
        public List<Peg> CheckingPegs;

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
        }

        public int RowId { get; }

        public class Cell
        {
            public Color Colour { get; private set; }
            public bool IsEmpty { get; private set; } = true;

            /// <summary>
            ///     Colour the cell to peg colour.
            /// </summary>
            /// <param name="peg"><c>Peg</c> that is placed in cell.</param>
            public void SetPeg(Peg peg)
            {
                //set GUI cell colour
                switch (peg.Colour)
                {
                    case PegColours.Aqua:
                        Colour = Color.Aqua;
                        break;
                    case PegColours.Black:
                        Colour = Color.Black;
                        break;
                    case PegColours.None:
                        Colour = Color.Empty;
                        break;
                    case PegColours.Blue:
                        Colour = Color.Blue;
                        break;
                    case PegColours.Brown:
                        Colour = Color.Brown;
                        break;
                    case PegColours.Green:
                        Colour = Color.Green;
                        break;
                    case PegColours.Orange:
                        Colour = Color.Orange;
                        break;
                    case PegColours.Purple:
                        Colour = Color.Purple;
                        break;
                    case PegColours.Red:
                        Colour = Color.Red;
                        break;
                    case PegColours.White:
                        Colour = Color.White;
                        break;
                    case PegColours.Yellow:
                        Colour = Color.Yellow;
                        break;
                }

                IsEmpty = false;
            }

            /// <summary>
            ///     Sets cell to empty.
            /// </summary>
            public void RemovePeg()
            {
                Colour = Color.Empty;
                IsEmpty = true;
            }
        }
    }
}