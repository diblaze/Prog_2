using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace aspHotelBook
{
    public partial class _default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                checkInDate.SelectedDate = DateTime.Now.Date;
                checkOutDate.SelectedDate = DateTime.Now.AddDays(2);
            }


            FixNavbarLoginView();



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

        protected void btnSearchForHotels_OnClick(object sender, EventArgs e)
        {
            if (checkInDate.SelectedDate > checkOutDate.SelectedDate)
            {
                return;
            }

            Response.Redirect("searchHotel.aspx?checkIn=" + checkInDate.SelectedDate.ToShortDateString() + "&checkOut=" +
                              checkOutDate.SelectedDate.ToShortDateString() + "&adults=" + ddlGrownUps.SelectedValue +
                              "&children=" + ddlChildren.SelectedValue);
        }

        protected void checkOutDate_OnSelectionChanged(object sender, EventArgs e)
        {
        }
    }
}