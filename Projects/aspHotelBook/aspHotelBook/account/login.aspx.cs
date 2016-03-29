using System;
using System.Security.Claims;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace aspHotelBook.account
{
    public partial class login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            FixNavbarLoginView();

            if (!IsPostBack)
            {
                //if already logged in, redirect to default.
                if (User.Identity.IsAuthenticated)
                {
                    Response.Redirect("~/default.aspx");
                }
            }
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

        protected void SignIn(object sender, EventArgs e)
        {
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);
            IdentityUser user = userManager.Find(tbUsername.Text, tbPassword.Text);

            //if user info is found
            if (user != null)
            {
                //create cookie
                IAuthenticationManager authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                ClaimsIdentity userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                //sign in
                authenticationManager.SignIn(new AuthenticationProperties {IsPersistent = false}, userIdentity);
                
                //redirect to default
                Response.Redirect("~/default.aspx");
            }
            //if not, show error message.
            else
            {
                lblConfirmationText.Text = "Invalid username or password.";
            }
        }
    }
}