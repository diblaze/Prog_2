﻿using System;
using System.Security.Claims;
using System.Web;
using System.Web.UI;
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

            if (!IsPostBack)
            {
                //if already logged in, redirect to default.
                if (User.Identity.IsAuthenticated)
                {
                    Response.Redirect("~/default.aspx");
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