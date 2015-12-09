using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace aspLogin.Account
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateUser_OnClick(object sender, EventArgs e)
        {
            var userStore = new UserStore<IdentityUser>();
            var manager = new UserManager<IdentityUser>(userStore);

            IdentityUser user = new IdentityUser()
                       {
                           UserName = UserName.Text
                       };
            IdentityResult result = manager.Create(user, Password.Text);

            StatusMessage.Text = result.Succeeded ? $"User {user.UserName} was created successfully!" : result.Errors.FirstOrDefault();
        }
    }
}