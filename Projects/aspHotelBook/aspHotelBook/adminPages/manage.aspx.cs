using System;
using System.Linq;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace aspHotelBook.adminPages
{
    public partial class manage : Page
    {
        //TODO: Need to add a way to add specific users to specific roles.
        //TODO: Need to add a way to see all the bookings - delete, view, create new.
        //TODO: Need to add a way to add more rooms to the hotel.

        protected void Page_Load(object sender, EventArgs e)
        {
        }

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
    }
}