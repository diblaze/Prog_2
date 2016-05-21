using System;
using System.Collections.Generic;
using System.Linq;

namespace winHotelManagement
{
    internal static class DatabaseManager
    {
        /// <summary>
        ///     Gets all suites.
        /// </summary>
        /// <returns><c>IEnumerable</c> list of all suites.</returns>
        public static IEnumerable<Suite> GetAllSuites()
        {
            //LINQ to SQL
            var db = new HotelDataDataContext();

            //Get ALL suites.
            IEnumerable<Suite> allSuites = from all in db.Suites
                                           orderby all.SuiteNumber
                                           select all;

            return allSuites;
        }

        /// <summary>
        ///     Gets all regular suites.
        /// </summary>
        /// <returns><c>IEnumerable</c> list of high-end suites</returns>
        public static IEnumerable<Suite> GetAllRegularSuites()
        {
            //LINQ to SQL
            var db = new HotelDataDataContext();

            //Get High-End suites
            IEnumerable<Suite> regularSuites = from hs in db.Suites
                                               where hs.SuiteType == "Regular"
                                               orderby hs.SuiteNumber
                                               select hs;

            return regularSuites.Any() ? regularSuites : null;
        }

        /// <summary>
        ///     Gets all high-end suites.
        /// </summary>
        /// <returns><c>IEnumerable</c> list of high-end suites</returns>
        public static IEnumerable<Suite> GetAllHighEndSuites()
        {
            //LINQ to SQL
            var db = new HotelDataDataContext();

            //Get High-End suites
            IEnumerable<Suite> highendSuites = from hs in db.Suites
                                               where hs.SuiteType == "High-End"
                                               orderby hs.SuiteNumber
                                               select hs;

            return highendSuites.Any() ? highendSuites : null;
        }

        /// <summary>
        ///     Gets all luxury suites.
        /// </summary>
        /// <returns><c>IEnumerable</c> list of luxuary suites</returns>
        public static IEnumerable<Suite> GetAllLuxurySuites()
        {
            //LINQ to SQL
            var db = new HotelDataDataContext();

            //Get LUXURY suites
            IEnumerable<Suite> luxurySuites = from ls in db.Suites
                                              where ls.SuiteType == "Luxury"
                                              orderby ls.SuiteNumber
                                              select ls;

            return luxurySuites.Any() ? luxurySuites : null;
        }

        public static IEnumerable<Suite> GetAllAvailableSuites(string suitetype, string checkInDate, string adults,
                                                 string children, string days)
        {
            var db = new HotelDataDataContext();

            int daysToStay = Convert.ToInt32(days);
            int adultsStaying = Convert.ToInt32(adults);
            int childrenStaying = Convert.ToInt32(children);

            DateTime bookDate;
            DateTime.TryParse(checkInDate, out bookDate);

            DateTime checkOutDate = bookDate.AddDays(daysToStay);

            IQueryable<int> bookings = (from b in db.Bookings
                           where (b.StartDate >= bookDate && b.StartDate <= checkOutDate)
                                 || (b.EndDate >= bookDate && b.EndDate <= checkOutDate)
                           select b.SuiteNumber);

            IEnumerable<Suite> querySearch = from q in db.Suites
                              where q.SuiteType == suitetype
                                    && q.NumberOfAdultsAllowed >= adultsStaying
                                    && q.NumberOfChildrenAllowed >= childrenStaying
                                    && !bookings.Contains(q.SuiteNumber)
                              select q;

            return querySearch;
        }

        public static void BookSuite(Suite temp, string checkInDate, string daysToStay, string fullname)
        {
            HotelDataDataContext db = new HotelDataDataContext();

            DateTime checkIn;
            DateTime.TryParse(checkInDate, out checkIn);

            DateTime checkOut = checkIn.AddDays(Convert.ToInt32(daysToStay));

            Booking booking = new Booking
                              {
                                  SuiteNumber = temp.SuiteNumber,
                                  CreditCard = "xxx",
                                  StartDate = checkIn,
                                  EndDate = checkOut,
                                  Name = fullname
                              };

            db.Bookings.InsertOnSubmit(booking);
            db.SubmitChanges();
        }

        /// <summary>
        /// Gets all booked suites.
        /// </summary>
        /// <returns><c>IEnumerable</c> list of all booked suites.</returns>
        public static IEnumerable<Booking> GetAllBooked()
        {
            //LINQ to SQL
            var db = new HotelDataDataContext();

            //get all booked
            IEnumerable<Booking> bookings = from b in db.Bookings
                                            orderby b.StartDate
                                            select b;

            return bookings.Any() ? bookings : null;
        }

        public static void DeleteSuites(string suitenumber, DateTime startdate, DateTime enddate)
        {
            throw new NotImplementedException();
        }
    }
}