using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspToDo
{
    public partial class addTodo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnAdd_OnClick( object sender, EventArgs e )
        {
            string titleText = tbTitle.Text;
            string itemMessage = tbMessage.Text;
            int priority = ddlPriority.SelectedIndex;
            DateTime endDate = calEndDate.SelectedDate;

            if ( titleText == string.Empty || itemMessage == string.Empty )
            {
                return;
            }

            if ( endDate.Date < DateTime.Today )
            {
                return;
            }

            const string query = "INSERT INTO Todo (Title, Text, Priority, Enddate, Finished) VALUES(@title, @text, @priority, @enddate, @finished)";
            sdsTodo.InsertCommand = query;
            sdsTodo.InsertParameters.Add( "title", titleText );
            sdsTodo.InsertParameters.Add("text", itemMessage);
            sdsTodo.InsertParameters.Add("priority", priority.ToString());
            sdsTodo.InsertParameters.Add("enddate", DbType.DateTime2, endDate.ToString(CultureInfo.CurrentCulture));
            sdsTodo.InsertParameters.Add( "finished", DbType.Boolean, "FALSE");
            sdsTodo.Insert();




        }

        protected void btnCancel_OnClick( object sender, EventArgs e )
        {
            Response.Redirect( "~/default.aspx" );
        }
    }
}