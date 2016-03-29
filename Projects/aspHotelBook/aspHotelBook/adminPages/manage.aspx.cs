using System;
using System.Data;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace aspHotelBook.adminPages
{
    public partial class manage : Page
    {
        //TODO: Need to add a way to add more rooms to the hotel.

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            FixNavbarLoginView();
        }

        /// <summary>
        /// Adds new role OnClick.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnAddNewRole_OnClick(object sender, EventArgs e)
        {
            //Rolemanager
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>());

            //If the role already exists
            if (roleManager.RoleExists(tbNewRole.Text))
            {
                lblRoleManager.Text = "The role you are trying to add, already exists!";
            }
            else
            {
                //Try creating the role
                IdentityResult roleResult = roleManager.Create(new IdentityRole(tbNewRole.Text));

                lblRoleManager.Text = roleResult.Succeeded
                                          ? $"The role {tbNewRole.Text} has been added!"
                                          : $"Could not add {tbNewRole.Text}! Error message {roleResult.Errors.FirstOrDefault()}";
                //Refresh the listbox
                listBoxAllRoles.DataBind();
            }
        }

        protected void btnAddRoom_OnClick(object sender, EventArgs e)
        {
            sqlBookings.InsertParameters.Add("HotelName", "Sandy Beach");
            sqlBookings.InsertParameters.Add("RoomNr", DbType.Int32, tbRoomNumber.Text);
            sqlBookings.InsertParameters.Add("Adults",DbType.Int32, tbAdults.Text);
            sqlBookings.InsertParameters.Add("Children", DbType.Int32, tbChildren.Text);
            sqlBookings.InsertParameters.Add("TV", DbType.Boolean, cbTv.Checked.ToString());
            sqlBookings.InsertParameters.Add("AC", DbType.Boolean, cbAc.Checked.ToString());
            sqlBookings.InsertParameters.Add("RoomService", DbType.Boolean, cbRoomService.Checked.ToString());
            sqlBookings.InsertParameters.Add("SuiteType", DbType.Int32, ddlSuiteType.SelectedValue);
            sqlBookings.InsertParameters.Add("PricePerDay", DbType.Int32, tbRate.Text);
            sqlBookings.InsertParameters.Add("Image", "");
        }

        /// <summary>
        /// Adds user to role OnClick.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnAddUserToRole_OnClick(object sender, EventArgs e)
        {
            //Usermanager
            var userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>());

            //error check
            if (listBoxAllUsers.SelectedValue == null && listBoxAllRoles2.SelectedValue == null)
            {
                lblConfirmationText.Text = "Please select an user and a role!";
                return;
            }
            if(listBoxAllUsers.SelectedValue == null)
            {
                lblConfirmationText.Text = "Please select an user!";
                return;
            }
            if (listBoxAllRoles2.SelectedValue == null)
            {
                lblConfirmationText.Text = "Please select a role!";
                return;
            }

            //find user from list
            IdentityUser user = userManager.FindByName(listBoxAllUsers.SelectedValue);
            if (user == null)
            {
                return;
            }
            //If user is not in the specific role, add
            if (!userManager.IsInRole(user.Id, listBoxAllRoles2.SelectedValue))
            {
                IdentityResult userResult = userManager.AddToRole(user.Id, listBoxAllRoles2.SelectedValue);
                lblConfirmationText.Text = !userResult.Succeeded
                                               ? $"Could not add user to role - {userResult.Errors.FirstOrDefault()}"
                                               : $"{user.UserName} was added to role {listBoxAllRoles2.SelectedValue}!";
            }
            //If user already is in the specific role, show error message.
            else
            {
                lblConfirmationText.Text = $"{user.UserName} is already in role {listBoxAllRoles2.SelectedValue}!";
            }
        }

        /// <summary>
        /// Fixes the navbar login view.
        /// </summary>
        private void FixNavbarLoginView()
        {
            //Usermanager
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
    }
}