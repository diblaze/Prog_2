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
        Purple
    }

    public class Peg
    {
        public PegColours Colour { get; }
        public Peg(int colourNumber)
        {
            Colour = (PegColours) colourNumber;
        }
    }

    public class PlaceablePeg : Peg
    {
        public new PegColours Colour { get; }
        public PlaceablePeg(int colourNumber) : base(colourNumber)
        {
            Colour = (PegColours) colourNumber;
        }
    }


}