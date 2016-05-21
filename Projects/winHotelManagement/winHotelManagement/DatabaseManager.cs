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

        /// <summary>
        ///     Gets all available suites.
        /// </summary>
        /// <param name="suitetype">The suitetype.</param>
        /// <param name="checkInDate">The check in date.</param>
        /// <param name="adults">The adults.</param>
        /// <param name="children">The children.</param>
        /// <param name="days">The days.</param>
        /// <returns></returns>
        public static IEnumerable<Suite> GetAllAvailableSuites(string suitetype, string checkInDate, string adults,
                                                               string children, string days)
        {
            //LINQ to SQL
            var db = new HotelDataDataContext();

            //needed variables
            int daysToStay = Convert.ToInt32(days);
            int adultsStaying = Convert.ToInt32(adults);
            int childrenStaying = Convert.ToInt32(children);

            //the check in date
            DateTime bookDate;
            DateTime.TryParse(checkInDate, out bookDate);

            //check out date
            DateTime checkOutDate = bookDate.AddDays(daysToStay);

            //query to get all suites which are booked between the check in and check out date.
            var bookings = from b in db.Bookings
                           where (b.StartDate >= bookDate && b.StartDate <= checkOutDate)
                                 || (b.EndDate >= bookDate && b.EndDate <= checkOutDate)
                           select b.SuiteNumber;

            //query to get all suites which are not booked by using the "bookings" query.
            IEnumerable<Suite> querySearch = from q in db.Suites
                                             where q.SuiteType == suitetype
                                                   && q.NumberOfAdultsAllowed >= adultsStaying
                                                   && q.NumberOfChildrenAllowed >= childrenStaying
                                                   && !bookings.Contains(q.SuiteNumber)
                                             select q;

            return querySearch;
        }

        /// <summary>
        ///     Gets all booked suites.
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

        /// <summary>
        ///     Deletes a suite.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public static void DeleteSuite(int id)
        {
            //LINQ to SQL
            var db = new HotelDataDataContext();

            //find the booked suite
            var delete = from d in db.Bookings
                         where d.Id == id
                         select d;

            db.Bookings.DeleteAllOnSubmit(delete);
            db.SubmitChanges();
        }

        /// <summary>
        ///     Books the suite.
        /// </summary>
        /// <param name="tempSuite">The temporary suite.</param>
        /// <param name="checkInDate">The check in date.</param>
        /// <param name="daysToStay">The days to stay.</param>
        /// <param name="fullName">The full name.</param>
        /// <param name="gender">The gender.</param>
        /// <param name="telephone">The telephone.</param>
        /// <param name="email">The email.</param>
        /// <param name="adress">The adress.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zipcode">The zipcode.</param>
        /// <param name="breakfast">if set to <c>true</c> [breakfast].</param>
        /// <returns><c>True</c> if sucess.</returns>
        public static bool BookSuite(Suite tempSuite, string checkInDate, string daysToStay, string fullName, string gender,
                                     string telephone, string email, string adress, string city, string state, string zipcode,
                                     bool breakfast)
        {
            var db = new HotelDataDataContext();

            DateTime checkIn;
            DateTime.TryParse(checkInDate, out checkIn);

            DateTime checkOut = checkIn.AddDays(Convert.ToInt32(daysToStay));

            try
            {
                var booking = new Booking
                              {
                                  SuiteNumber = tempSuite.SuiteNumber,
                                  StartDate = checkIn,
                                  EndDate = checkOut,
                                  Name = fullName,
                                  Telephone = telephone,
                                  Email = email,
                                  Adress = adress,
                                  City = city,
                                  State = state,
                                  ZipCode = zipcode,
                                  Breakfast = breakfast
                              };

                db.Bookings.InsertOnSubmit(booking);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}