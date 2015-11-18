using System;
using System.Data;
using System.Globalization;
using System.Web.UI;

namespace aspWebLog
    {
    public partial class AddLog : Page
        {
        private DateTime dt;

        protected void Page_Load( object sender, EventArgs e )
        {
            dt = DateTime.Now;
            currentDate.Text = "Entry Date: " + dt;
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnBack_OnClick( object sender, EventArgs e )
        {
            Response.Redirect( "~/default.aspx" );
        }

        protected void btnSave_OnClick( object sender, EventArgs e )
        {
            const string sqlQuery = "INSERT INTO Logs (Logged, Time) VALUES(@message,@date)";
                //felet var att jag använde mig utan ' ' ...

            sqlLog.InsertCommand = sqlQuery;
            sqlLog.InsertParameters.Add( "message", txtMessage.Text );
            sqlLog.InsertParameters.Add( "date", DbType.DateTime2, dt.ToString( CultureInfo.CurrentCulture ) );
            sqlLog.Insert();
            Response.Redirect( "~/default.aspx" );
        }
        }
    }