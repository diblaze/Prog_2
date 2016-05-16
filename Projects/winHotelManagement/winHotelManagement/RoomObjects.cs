using System.Data.Linq.Mapping;

namespace winHotelManagement
{
    [Table(Name = "Suites")]
    public class Suite
    {
        //Constructor used when creating a new suite.
        public Suite(int roomNumber,
                     int roomSize,
                     int beds,
                     bool ac,
                     bool tv,
                     bool balcony,
                     bool minibar,
                     int numberOfAdultsAllowed,
                     int numberOfChildrenAllowed,
                     bool breakfast)
        {
            RoomNumber = roomNumber;
            RoomSize = roomSize;
            Beds = beds;
            AC = ac;
            TV = tv;
            Balcony = balcony;
            Minibar = minibar;
            NumberOfAdultsAllowed = numberOfAdultsAllowed;
            NumberOfChildrenAllowed = numberOfChildrenAllowed;
            Breakfast = breakfast;
        }

        //Used when retreiving a suite from database.
        public Suite()
        {
        }

        private int _RoomNumber;
        [Column(IsPrimaryKey = true, Storage = "_RoomNumber")]
        public int RoomNumber
        {
            get { return _RoomNumber; }
            set { _RoomNumber = value; }
        }

        private int _RoomSize;
        [Column(Storage = "_RoomSize")]
        public int RoomSize
        {
            get { return _RoomSize; }
            set { _RoomSize = value; }
        }

        private int _Beds;
        [Column(Storage = "_Beds")]
        public int Beds
        {
            get { return _Beds; }
            set { _Beds = value; }
        }

        private bool _AC;
        [Column(Storage = "_AC")]
        public bool AC
        {
            get { return _AC; }
            set { _AC = value; }
        }

        private bool _TV;
        [Column(Storage = "_TV")]
        public bool TV
        {
            get { return _TV; }
            set { _TV = value; }
        }

        private bool _Balcony;
        [Column(Storage = "_Balcony")]
        public bool Balcony
        {
            get { return _Balcony; }
            set { _Balcony = value; }
        }

        private bool _Minibar;
        [Column(Storage = "_Minibar")]
        public bool Minibar
        {
            get { return _Minibar; }
            set { _Minibar = value; }
        }

        private int _NumberOfAdultsAllowed;
        [Column(Storage = "_NumberOfAdultsAllowed")]
        public int NumberOfAdultsAllowed
        {
            get { return _NumberOfAdultsAllowed; }
            set { _NumberOfAdultsAllowed = value; }
        }

        private int _NumberOfChildrenAllowed;
        [Column(Storage = "_NumberOfChildrenAllowed")]
        public int NumberOfChildrenAllowed
        {
            get { return _NumberOfChildrenAllowed; }
            set { _NumberOfChildrenAllowed = value; }
        }

        private bool _Breakfast;
        [Column(Storage = "_Breakfast")]
        public bool Breakfast
        {
            get { return _Breakfast; }
            set { _Breakfast = value; }
        }
    }

    public class HighEndSuite : Suite
    {
        public double BabysitterRate { get; set; }
        public bool Babysitter { get; set; }
        public bool Pool { get; set; }
        public bool Gym { get; set; }
        public bool Spa { get; set; }
        public bool Laundry { get; set; }
    }

    public class LuxuarySuite : Suite
    {
        public bool Sauna { get; set; }
        public bool Bathtub { get; set; }
        public bool Jacuzzi { get; set; }
        public bool RoomService { get; set; }
        public bool Babysitter { get; set; }
        public double BabysitterRate { get; set; }
        public bool Gym { get; set; }
        public bool Spa { get; set; }
        public bool Laundry { get; set; }
        public bool Tennis { get; set; }
    }
}