using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace aspHotelBook.account
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterUser(object sender, EventArgs e)
        {
            //Default UserStore constructor uses default connection.
            var userStore = new UserStore<IdentityUser>();
            var manager = new UserManager<IdentityUser>(userStore);

            

            var user = new IdentityUser() { UserName = tbUsername.Text, Email = tbEmail.Text};
            IdentityResult result = manager.Create(user, tbPassword.Text);

            if (result.Succeeded)
            {
                lblConfirmationText.Text = $"User {user.UserName} was created sucessfully!";
            }
            else
            {
                lblConfirmationText.Text = result.Errors.FirstOrDefault();
            }


        }
    }
}