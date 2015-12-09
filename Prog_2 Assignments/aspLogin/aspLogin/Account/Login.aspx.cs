using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace aspLogin.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (User.Identity.IsAuthenticated)
                {
                    StatusText.Text = $"Hello {User.Identity.GetUserName()}!";
                    LoginStatus.Visible = true;
                    LogoutButton.Visible = true;

                    Response.Redirect(Session["GoBackTo"].ToString());
                }
                else
                {
                    LoginForm.Visible = true;
                }
            }
        }

        protected void SignIn(object sender, EventArgs e)
        {
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);

            var user = userManager.Find(UserName.Text, Password.Text);

            if (user != null)
            {
                var authManager = HttpContext.Current.GetOwinContext().Authentication;
                var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                authManager.SignIn(new AuthenticationProperties {IsPersistent = false}, userIdentity);
                Response.Redirect("~/Account/Login.aspx");
            }
            else
            {
                StatusText.Text = "Invalid username or password";
                LoginStatus.Visible = true;
            }
        }

        protected void SignOut(object sender, EventArgs e)
        {
            var authManager = HttpContext.Current.GetOwinContext().Authentication;
            authManager.SignOut();
            Response.Redirect("~/Account/Login.aspx");
        }
    }
}