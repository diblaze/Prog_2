using System;
using System.Web;
using System.Web.UI;
using Microsoft.Owin.Security;

namespace aspHotelBook.account
{
    public partial class logout : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if user is logged in. Log out and redirect
            if (User.Identity.IsAuthenticated)
            {
                IAuthenticationManager authManager = HttpContext.Current.GetOwinContext().Authentication;
                authManager.SignOut();
                Response.Redirect("~/default.aspx");
            }
            //otherwise just redirect.
            else
            {
                Response.Redirect("~/default.aspx");
            }
        }
    }
}