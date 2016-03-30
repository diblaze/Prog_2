using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace aspHotelBook.adminPages
{
    public partial class manage : Page
    {
        //TODO: Add a way to show all rooms in the hotel

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            FixNavbarLoginView();
        }

        /// <summary>
        ///     Adds new role OnClick.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
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

        /// <summary>
        ///     Adds a new room to the hotel OnClick.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        protected void btnAddRoom_OnClick(object sender, EventArgs e)
        {
            //TODO: Fix images to be added according to suite type.
            try
            {
                sqlRooms.InsertParameters["HotelName"].DefaultValue = "Sandy Beach";
                sqlRooms.InsertParameters["RoomNr"].DefaultValue = tbRoomNumber.Text;
                sqlRooms.InsertParameters["Adults"].DefaultValue = tbAdults.Text;
                sqlRooms.InsertParameters["Children"].DefaultValue = tbChildren.Text;
                sqlRooms.InsertParameters["TV"].DefaultValue = cbTv.Checked.ToString();
                sqlRooms.InsertParameters["AC"].DefaultValue = cbAc.Checked.ToString();
                sqlRooms.InsertParameters["RoomService"].DefaultValue = cbRoomService.Checked.ToString();
                sqlRooms.InsertParameters["SuiteType"].DefaultValue = ddlSuiteType.SelectedValue;
                sqlRooms.InsertParameters["PricePerDay"].DefaultValue = tbRate.Text;
                sqlRooms.InsertParameters["Image"].DefaultValue = "";

                sqlRooms.Insert();

                lblAddRoomConfirmationText.ForeColor = Color.Green;

                lblAddRoomConfirmationText.Text = $"The room {tbRoomNumber.Text} has been added to the database!";
            }
            catch (SqlException ex)
            {
                lblAddRoomConfirmationText.ForeColor = Color.Red;

                if (ex.Message.StartsWith("Violation of PRIMARY KEY"))
                {
                    lblAddRoomConfirmationText.Text = $"The room number {tbRoomNumber.Text} already exists in the database!";
                }
                else
                {
                    lblAddRoomConfirmationText.Text = ex.Message;
                }
            }
        }

        /// <summary>
        ///     Adds user to role OnClick.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
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
            if (listBoxAllUsers.SelectedValue == null)
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

            //If user is already in a role, remove from role. Because if user is demoted from Admin to Employee or vice versa,
            //no more needed actions are requried.
            //Only ONE role per user.

            if (userManager.IsInRole(user.Id, "Customer"))
            {
                userManager.RemoveFromRole(user.Id, "Customer");
            }
            if (userManager.IsInRole(user.Id, "Employee"))
            {
                userManager.RemoveFromRole(user.Id, "Employee");
            }
            if (userManager.IsInRole(user.Id, "Admin"))
            {
                userManager.RemoveFromRole(user.Id, "Admin");
            }

            //Add the user to the spcific role

            IdentityResult userResult = userManager.AddToRole(user.Id, listBoxAllRoles2.SelectedValue);
            lblConfirmationText.Text = !userResult.Succeeded
                                           ? $"Could not add user to role - {userResult.Errors.FirstOrDefault()}"
                                           : $"{user.UserName} was added to role {listBoxAllRoles2.SelectedValue}!";
        }

        /// <summary>
        ///     Fixes the navbar login view.
        /// </summary>
        private void FixNavbarLoginView()
        {
            //Usermanager
            var userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>());

            //find controls from master page
            var adminView = (LoginView) Master.FindControl("lvAdminContent");
            var employeeView = (LoginView) Master.FindControl("lvEmployeeContent");
            var userStatus = (LoginView) Master.FindControl("lvUserStatus");

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