using System;
using System.Data;
using System.Globalization;
using System.Web.UI;

namespace aspWebLog
{
    public partial class AddLog : Page
    {
        private string dt;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            dt = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            currentDate.Text = "Entry Date: " + dt;
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnBack_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("~/default.aspx");
        }

        protected void btnSave_OnClick(object sender, EventArgs e)
        {
            const string sqlQuery = "INSERT INTO Logs (Logged, Time) VALUES('@message','@date')";

            sqlLog.InsertCommand = sqlQuery;
            sqlLog.InsertParameters.Add("message", txtMessage.Text);
            string s = string.Format("{dd/MM/yyyy HH:mm}",dt);
            
            sqlLog.InsertParameters.Add("date", DbType.DateTime2, dt.ToString(new CultureInfo("en-GB")));
            sqlLog.Insert();
            Response.Redirect("~/default.aspx");
        }
    }
}