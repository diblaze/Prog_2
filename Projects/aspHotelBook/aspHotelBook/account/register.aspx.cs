using System;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace aspHotelBook.account
{
    public partial class register : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            //if user is already logged in, redirect to default page.
            if (User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/default.aspx");
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

        /// <summary>
        ///     Registers the user.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        protected void RegisterUser(object sender, EventArgs e)
        {
            //Default UserStore constructor uses default connection.
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);

            //create a new user with the given username and password.
            var user = new IdentityUser {UserName = tbUsername.Text, Email = tbEmail.Text};
            IdentityResult result = userManager.Create(user, tbPassword.Text);

            //if user was created - show sucessful message 
            if (result.Succeeded)
            {
                lblConfirmationText.Text = $"User {user.UserName} was created successfully!";

                //create cookie
                IAuthenticationManager authManager = HttpContext.Current.GetOwinContext().Authentication;
                ClaimsIdentity userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                //login user
                authManager.SignIn(new AuthenticationProperties {IsPersistent = false}, userIdentity);
                userManager.AddToRole(user.Id, "Customer");


                //send back to default page
                Response.Redirect("~/default.aspx");
            }
            //else show error message.
            else
            {
                lblConfirmationText.Text = result.Errors.FirstOrDefault();
            }
        }
    }
}