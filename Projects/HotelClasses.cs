namespace winHotelBookingSystem
{
    internal abstract class BaseHotelObjects
    {
        public bool Tv { get; set; }
        public bool Ac { get; set; }
        public double Size { get; set; }
        public int RoomNumber { get; set; }
    }

    internal abstract class BaseRoom
    {
        public bool Shower { get; set; }
        public bool Tub { get; set; }
        public int Beds { get; set; }
        public int ExtraBeds { get; set; }
    }

    internal abstract class BasePlace
    {
        public int MaxPersons { get; set; }
    }

    internal class StandardRoom : BaseRoom
    {
    }

    internal class FamilyRoom : BaseRoom
    {
        public bool BabyAdapted { get; set; }
    }

    internal class Suite : BaseRoom
    {
        public bool HotTub { get; set; }
    }

    internal class ConferenceRoom : BasePlace
    {
        public int AmountOfChairs { get; set; }
        public int AmountOfTables { get; set; }
    }

    internal class Spa : BasePlace
    {
        public int AmountOfShowers { get; set; }
        public int AmountOfTubs { get; set; }
        public bool Sauna { get; set; }
        public bool HotTub { get; set; }
        public bool SwimmingPool { get; set; }
        public bool Massage { get; set; }
        public bool Drinks { get; set; }
    }
}