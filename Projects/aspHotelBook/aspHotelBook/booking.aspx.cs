﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace aspHotelBook
{

    //TODO: Add way for employees and admins to book for a customer!

        //TODO: Update NavBar fix
    public partial class booking : System.Web.UI.Page
    {
        //Response.Redirect("booking.aspx?checkIn=" + _checkInDate + "&checkOut=" + _checkOutDate + "&room=" + buttonPressed.CommandArgument);

        private string _checkInDate;
        private string _checkOutDate;
        private string _roomId;

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            FixNavbarLoginView();


            if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole("Admin") || User.IsInRole("Employee"))
                {

                    lvManage.Visible = true;
                }
                else
                {
                    lvCustomer.Visible = true;
                }
            }


            _checkInDate = Request.QueryString["checkIn"];
            _checkOutDate = Request.QueryString["checkOut"];
            _roomId = Request.QueryString["room"];

            if (_checkInDate == null || _checkOutDate == null || _roomId == null)
            {
                Response.Redirect("default.aspx");
            }
        }

        /// <summary>
        /// Fixes the navbar login view.
        /// </summary>
        private void FixNavbarLoginView()
        {
            //find controls from master page
            var adminView = (LoginView)Master.FindControl("lvAdminContent");
            var employeeView = (LoginView)Master.FindControl("lvEmployeeContent");
            var userStatus = (LoginView)Master.FindControl("lvUserStatus");

            //find user from list
            //IdentityUser user = userManager.FindByName(listBoxAllUsers.SelectedValue);
            if (User.Identity.IsAuthenticated)
            {

                if (User.IsInRole("Admin"))
                {
                    adminView.Visible = true;
                    employeeView.Visible = false;
                    userStatus.Visible = false;
                }
                else if (User.IsInRole("Employee"))
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

        protected void BookRoomForUser(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void BookRoom(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}