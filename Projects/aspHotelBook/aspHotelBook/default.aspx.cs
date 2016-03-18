using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspHotelBook
{
    public partial class _default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            checkInDate.SelectedDate = DateTime.Now.Date;
            checkOutDate.SelectedDate = DateTime.Now.AddDays(2);

        }

        protected void btnSearchForHotels_OnClick(object sender, EventArgs e)
        {
            if (checkInDate.SelectedDate > checkOutDate.SelectedDate)
            {
                return;
            }

            Response.Redirect("searchHotel.aspx?checkIn=" + checkInDate.SelectedDate.ToShortDateString() + "&checkOut=" + checkOutDate.SelectedDate.ToShortDateString() + "&adults=" + ddlGrownUps.SelectedValue + "&children=" + ddlChildren.SelectedValue);
        }

        protected void checkOutDate_OnSelectionChanged(object sender, EventArgs e)
        { 
        }
    }
}