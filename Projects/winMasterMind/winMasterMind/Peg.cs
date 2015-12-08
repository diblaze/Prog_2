namespace winMasterMind
{
    public enum PegColours
    {
        Black,
        Red,
        Green,
        Yellow,
        Blue,
        Orange,
        Brown,
        White,
        Purple,
        Aqua,
        None
    }

    public class Peg
    {
        public Peg(int colourNumber)
        {
            Colour = (PegColours) colourNumber;
        }

        public PegColours Colour { get; }
    }

    public class PlaceablePeg : Peg
    {
        public PlaceablePeg(int colourNumber) : base(colourNumber)
        {
            Colour = (PegColours) colourNumber;
        }

        public new PegColours Colour { get; }
    }
}