using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace aspHotelBook
{
    //TODO: Add JavaScript to calculate total cost for stay.
    public partial class searchHotel : System.Web.UI.Page
    {
        private string _checkInDate;
        private string _checkOutDate;

        private string _adults;
        private string _children;        
        private string _roomType;


        private Parameter _start;
        private Parameter _end;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                _start = new Parameter("_start", DbType.Date);
                _end = new Parameter("_end", DbType.Date);

                sqlHotels.SelectParameters.Add(_start);
                sqlHotels.SelectParameters.Add(_end);
            }

            FixNavbarLoginView();


            _checkInDate = Request.QueryString["checkIn"];
            _checkOutDate = Request.QueryString["checkOut"];

            _adults = Request.QueryString["adults"];
            _children = Request.QueryString["children"];
            _roomType = Request.QueryString["roomType"];

            ManualDatabind();
        }

        /// <summary>
        /// Fixes the navbar login view.
        /// </summary>
        private void FixNavbarLoginView()
        {
            //Rolemanager
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>());
            var userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>());

            //find controls from master page
            var adminView = (LoginView)Master.FindControl("lvAdminContent");
            var employeeView = (LoginView)Master.FindControl("lvEmployeeContent");
            var userStatus = (LoginView)Master.FindControl("lvUserStatus");

            //find user from list
            //IdentityUser user = userManager.FindByName(listBoxAllUsers.SelectedValue);
            if (User.Identity.IsAuthenticated)
            {
                IdentityUser user = userManager.FindByName(User.Identity.Name);

                if (userManager.IsInRole(user.Id, "Admin"))
                {
                    adminView.Visible = true;
                    employeeView.Visible = false;
                    userStatus.Visible = false;
                }
                else if (userManager.IsInRole(user.Id, "Employee"))
                {
                    adminView.Visible = false;
                    employeeView.Visible = true;
                    userStatus.Visible = false;
                }
                else
                {
                    adminView.Visible = false;
                    employeeView.Visible = false;
                    userStatus.Visible = true;
                }
            }
        }


        private void ManualDatabind()
        {
            string query = "";

            if (_roomType == null)
            {
                query = "SELECT * FROM Rooms WHERE Adults >= " + _adults + " AND Children >= " + _children + " AND ";
                query += "Rooms.RoomNr NOT IN (SELECT RoomNr FROM Bookings WHERE ";
                query += "(CheckedIn BETWEEN @_start AND @_end) OR ";
                query += "(CheckingOut BETWEEN @_start AND @_end) OR ";
                query += "(@_start BETWEEN CheckedIn AND CheckingOut) OR ";
                query += "(@_end BETWEEN CheckedIn AND CheckingOut) OR ";
                query += "(@_start <= CheckedIn AND @_end >= CheckingOut) OR ";
                query += "(@_start >= @_end))";

                sqlHotels.SelectCommand = query;
                sqlHotels.SelectParameters["_start"].DefaultValue = _checkInDate;
                sqlHotels.SelectParameters["_end"].DefaultValue = _checkOutDate;

                sqlHotels.Select(DataSourceSelectArguments.Empty);
                sqlHotels.DataBind();
            }
            else
            {
                query = "SELECT * FROM Rooms WHERE SuiteType = " + _roomType + " AND Adults >= " + _adults + " AND Children >= " + _children + " AND ";
                query += "Rooms.RoomNr NOT IN (SELECT RoomNr FROM Bookings WHERE ";
                query += "(CheckedIn BETWEEN @_start AND @_end) OR ";
                query += "(CheckingOut BETWEEN @_start AND @_end) OR ";
                query += "(@_start BETWEEN CheckedIn and CheckingOut) OR ";
                query += "(@_end BETWEEN CheckedIn and CheckingOut) OR ";
                query += "(@_start <= CheckedIn and @_end >= CheckingOut) OR ";
                query += "(@_start >= @_end))";

                sqlHotels.SelectCommand = query;
                sqlHotels.SelectParameters["_start"].DefaultValue = _checkInDate;
                sqlHotels.SelectParameters["_end"].DefaultValue = _checkOutDate;

                sqlHotels.Select(DataSourceSelectArguments.Empty);
                sqlHotels.DataBind();
            }
                
        }


        protected void BookRoom_Click(object sender, EventArgs e)
        {
            var buttonPressed = sender as Button;
            if (buttonPressed != null)
            {
                Response.Redirect("booking.aspx?checkIn=" + _checkInDate + "&checkOut=" + _checkOutDate + "&room=" + buttonPressed.CommandArgument);
            }
        }

        protected string WhatRoomType(object eval)
        {
            var type = (int) eval;

            switch (type)
            {
                case 0:
                    
                    return "Standard";
                case 1:
                    return "High-End";
                case 2:
                    return "Luxuary";
                default:
                    return "";

            }
        }

        protected void ChangeRoomType(object sender, EventArgs e)
        {
            var roomType = sender as Button;

            switch (roomType?.ID)
            {
                case "btnAllRoomTypes":
                    Response.Redirect("searchHotel.aspx?checkIn=" + _checkInDate + "&checkOut=" + _checkOutDate + "&adults=" +
                                      _adults + "&children=" + _children);
                    break;
                case "btnStandardRoomType":
                    Response.Redirect("searchHotel.aspx?checkIn=" + _checkInDate + "&checkOut=" + _checkOutDate + "&adults=" +
                                      _adults + "&children=" + _children + "&roomType=" + 0);
                    break;
                case "btnHighEndRoomType":
                    Response.Redirect("searchHotel.aspx?checkIn=" + _checkInDate + "&checkOut=" + _checkOutDate + "&adults=" +
                                      _adults + "&children=" + _children + "&roomType=" + 1);
                    break;
                case "btnLuxuaryRoomType":
                    Response.Redirect("searchHotel.aspx?checkIn=" + _checkInDate + "&checkOut=" + _checkOutDate + "&adults=" +
                                      _adults + "&children=" + _children + "&roomType=" + 2);
                    break;

            }
        }
    }
}