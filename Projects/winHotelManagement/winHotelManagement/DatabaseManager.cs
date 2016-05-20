using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winHotelManagement
{
    static class DatabaseManager
    {

        /// <summary>
        /// Gets all suites.
        /// </summary>
        /// <returns><c>IEnumerable</c> list of all suites.</returns>
        public static IEnumerable<Suite> GetAllSuites()
        {
            //LINQ to SQL
            HotelDataDataContext db = new HotelDataDataContext();

            //Get ALL suites.
            IEnumerable<Suite> allSuites = from all in db.Suites
                                               orderby all.SuiteNumber
                                               select all;

            return allSuites;
        }


        /// <summary>
        /// Gets all regular suites.
        /// </summary>
        /// <returns><c>IEnumerable</c> list of high-end suites</returns>
        public static IEnumerable<Suite> GetAllRegularSuites()
        {
            //LINQ to SQL
            HotelDataDataContext db = new HotelDataDataContext();

            //Get High-End suites
            IEnumerable<Suite> regularSuites = from hs in db.Suites
                                               where hs.SuiteType == "Regular"
                                               orderby hs.SuiteNumber
                                               select hs;

            return regularSuites.Any() ? regularSuites : null;
        }


        /// <summary>
        /// Gets all high-end suites.
        /// </summary>
        /// <returns><c>IEnumerable</c> list of high-end suites</returns>
        public static IEnumerable<Suite> GetAllHighEndSuites()
        {
            //LINQ to SQL
            HotelDataDataContext db = new HotelDataDataContext();

            //Get High-End suites
            IEnumerable<Suite> highendSuites = from hs in db.Suites
                                               where hs.SuiteType == "High-End"
                                               orderby hs.SuiteNumber
                                               select hs;
            
            return highendSuites.Any() ? highendSuites : null;
        }

        /// <summary>
        /// Gets all luxury suites.
        /// </summary>
        /// <returns><c>IEnumerable</c> list of luxuary suites</returns>
        public static IEnumerable<Suite> GetAllLuxurySuites()
        {
            //LINQ to SQL
            HotelDataDataContext db = new HotelDataDataContext();

            //Get LUXURY suites
            IEnumerable<Suite> luxurySuites = from ls in db.Suites
                                              where ls.SuiteType == "Luxury"
                                              orderby ls.SuiteNumber
                                              select ls;

            return luxurySuites.Any() ? luxurySuites : null;
        }

        public static void GetAllAvailableSuites(string suitetype, string year, string month, string day, string adults, string children)
        {
            string query = "";

            query = "SELECT * FROM Suites WHERE SuiteType = " + suitetype + " AND NumberOfAdultsAllowed >= " + adults + " AND NumberOfChildrenAllowed >= " + children + " AND ";
            query += "Suites.SuiteNumber NOT IN (SELECT SuiteNumber FROM Bookings WHERE ";
            query += "(StartDate BETWEEN @_start AND @_end) OR ";
            query += "(EndDate BETWEEN @_start AND @_end) OR ";
            query += "(@_start BETWEEN StartDate and EndDate) OR ";
            query += "(@_end BETWEEN StartDate and EndDate) OR ";
            query += "(@_start <= StartDate and @_end >= EndDate) OR ";
            query += "(@_start >= @_end))";

            HotelDataDataContext db = new HotelDataDataContext();

            var querySearch = from q in db.Suites
                              where q.SuiteType == suitetype
                              select q;
            var notBooked = from b in querySearch
                            from n in db.Bookings
                            where b.SuiteNumber == n.SuiteNumber
                            where 


            
                            


        }
    }
}
