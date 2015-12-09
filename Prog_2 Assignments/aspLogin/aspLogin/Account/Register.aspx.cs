using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace aspLogin.Account
{
    public partial class Register : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void CreateUser_OnClick(object sender, EventArgs e)
        {
            var userStore = new UserStore<IdentityUser>();
            var manager = new UserManager<IdentityUser>(userStore);

            var user = new IdentityUser
            {
                UserName = UserName.Text
            };
            var result = manager.Create(user, Password.Text);

            if (result.Succeeded)
            {
                //StatusMessage.Text = result.Succeeded ? $"User {user.UserName} was created successfully!" : result.Errors.FirstOrDefault();
                var authManager = HttpContext.Current.GetOwinContext().Authentication;
                var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                authManager.SignIn(new AuthenticationProperties(), userIdentity);
                Response.Redirect("~/Account/Login.aspx");
            }
        }
    }
}