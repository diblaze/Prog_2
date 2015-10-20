using System;

namespace winHotelBookingSystem
{
    internal abstract class BaseHotelObjects
    {
        public bool Tv { get; set; }
        public bool Ac { get; set; }
        public double Size { get; set; }
        public int RoomNumber { get; set; }
        public DateTime BookingStart { get; set; } //Start of booking
        public DateTime BookingEnd { get; set; } //End of booking
        public DateTime CheckInTime { get; set; } //Start of check in time
        public DateTime CheckOutTime { get; set; } //End of check in time
        public bool Booked { get; set; } //Is booked?

        public virtual void CheckIn()
        {
            throw new NotImplementedException();
        }

        public virtual void CheckOut()
        {
            throw new NotImplementedException();
        }

        public virtual void Book()
        {
        }

        public virtual void CancelBook()
        {
        }
    }

    internal abstract class BaseRoom : BaseHotelObjects
    {
        public bool Shower { get; set; }
        public bool Tub { get; set; }
        public int Beds { get; set; }
        public int ExtraBeds { get; set; }
    }

    internal abstract class BasePlace : BaseHotelObjects
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

    internal class Gym : BasePlace
    {
        public bool DressingRoom { get; set; }
        public bool GroupSessions { get; set; }
        public bool PersonalTrainer { get; set; }
    }
}