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


        }
        
        /// <summary>
        ///     Registers the user.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        protected void RegisterUser(object sender, EventArgs e)
        {

            if (tbPassword.Text != tbPasswordConfirm.Text)
            {
                return;
            }

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
                var returnUrl = Request.QueryString["returnUrl"];
                //if user came from different page, redirect to that one. Otherwise redirect to main page.
                Response.Redirect(returnUrl ?? "~/default.aspx");
            }
            //else show error message.
            else
            {
                lblConfirmationText.Text = result.Errors.FirstOrDefault();
            }
        }
    }
}