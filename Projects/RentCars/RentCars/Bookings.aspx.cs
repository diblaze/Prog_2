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
        Parameter start;
        Parameter end;
        protected void Page_Load(object sender, EventArgs e)
        {
            start = new Parameter("start", DbType.Date);
            end = new Parameter("end", DbType.Date);

            if (!IsPostBack)
            {
                dsVehicles.SelectParameters.Add(start);
                dsVehicles.SelectParameters.Add(end);

                startDate.SelectedDate = DateTime.Today;
                endDate.SelectedDate = DateTime.Today.AddDays(1);
            }



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
            dsBookings.InsertParameters.Add("start", DbType.Date, startDate.SelectedDate.ToLongDateString());
            dsBookings.InsertParameters.Add("end", DbType.Date, endDate.SelectedDate.ToLongDateString());
            dsBookings.InsertParameters.Add("bookingDate", DbType.DateTime,currentDateTime);

            //run command
            dsBookings.Insert();

        }

        protected void btnSearch_OnClick(object sender, EventArgs e)
        {
            Button btnPressed = sender as Button;
            string query = "SELECT * FROM Vehicles WHERE ";
            query += "Vehicles.RegNo NOT IN (";
            query += "SELECT RegNo FROM Bookings WHERE";
            query += "(StartBooking BETWEEN @start AND @end) OR";
            query += "(EndBooking BETWEEN @start AND @end) OR";
            query += "(@start BETWEEN StartBooking AND EndBooking) OR";
            query += "(@end BETWEEN StartBooking AND EndBooking) OR";
            query += "(@start < StartBooking AND @end > EndBooking) OR";
            query += "(@start < @end))";
            query += "AND Model=@model AND MAnufacture=@manufacture AND [Type]=@type";

            dsVehicles.SelectCommand = query;
            dsVehicles.SelectParameters["start"].DefaultValue = startDate.SelectedDate.ToShortDateString();
            dsVehicles.SelectParameters["end"].DefaultValue = endDate.SelectedDate.ToShortDateString();
            dsVehicles.SelectParameters["model"].DefaultValue = btnPressed.CommandArgument;

            dsVehicles.Select(DataSourceSelectArguments.Empty);
            dsVehicles.DataBind();
        }
    }
}