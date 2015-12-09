using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;

namespace aspLogin
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["GoBackTo"] = Request.RawUrl;
            if (!IsPostBack)
            {
                if (User.Identity.IsAuthenticated)
                {
                    StatusText.Text = $"Hello {User.Identity.GetUserName()}";
                    LoginStatus.Visible = true;
                    LogoutButton.Visible = true;
                }
                else
                {
                    Response.Redirect("~/Account/Login.aspx");
                }
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