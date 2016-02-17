using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentCars
{
    public partial class Bookings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBook_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;

            string query = "INSERT INTO Bookings (RegNo, StartBooking, EndBooking, BookingDate ) ";
            query += "VALUES (@regNo, @start, @end, @bookingDate)";

            string currentDateTime = DateTime.Now.ToShortTimeString();

            //create parameters
            dsBookings.InsertCommand = query;
            dsBookings.InsertParameters.Add("regNo", DbType.String, btn.CommandArgument);
            dsBookings.InsertParameters.Add("start", DbType.Date, startDate.Text);
            dsBookings.InsertParameters.Add("end", DbType.Date, endDate.Text);
            dsBookings.InsertParameters.Add("bookingDate", DbType.DateTime,currentDateTime);

            //run command
            dsBookings.Insert();

        }
    }
}