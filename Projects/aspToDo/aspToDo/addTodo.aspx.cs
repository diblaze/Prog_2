using System;
using System.Data;
using System.Globalization;
using System.Web.UI;

namespace aspToDo
    {
    public partial class AddTodo : Page
        {
        protected void Page_Load( object sender, EventArgs e )
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnAdd_OnClick( object sender, EventArgs e )
        {
            DateTime endDate;
            string titleText = tbTitle.Text;
            string itemMessage = tbMessage.Text;
            int priority = Convert.ToInt32( ddlPriority.SelectedValue );
            string query = "";

            //Date has been selected - return if date selected have already occured.
            if ( calEndDate.SelectedDate.Date != DateTime.MinValue )
            {
                endDate = calEndDate.SelectedDate;
                if ( endDate.Date < DateTime.Today )
                {
                    return;
                }
            }
            //Date has not been selected
            else
            {
                endDate = DateTime.MinValue;
            }

            if ( titleText == string.Empty )
            {
                return;
            }

            //if message is not empty and user selected a enddate
            if ( itemMessage != string.Empty && endDate != DateTime.MinValue )
            {
                query =
                    "INSERT INTO Todo (Title, Text, Priority, Enddate, Finished) VALUES(@title, @text, @priority, @enddate, @finished)";
                sdsTodo.InsertCommand = query;
                sdsTodo.InsertParameters.Add( "title", titleText );
                sdsTodo.InsertParameters.Add( "text", itemMessage );
                sdsTodo.InsertParameters.Add( "priority", priority.ToString() );
                sdsTodo.InsertParameters.Add(
                    "enddate",
                    DbType.DateTime2,
                    endDate.ToString( CultureInfo.CurrentCulture ) );
                sdsTodo.InsertParameters.Add( "finished", DbType.Boolean, "FALSE" );
                sdsTodo.Insert();
            }
            //if message is empty and user did not select a enddate
            else if ( itemMessage == string.Empty && endDate == DateTime.MinValue )
            {
                query = "INSERT INTO Todo (Title, Priority, Finished) VALUES(@title, @priority, @finished)";
                sdsTodo.InsertCommand = query;
                sdsTodo.InsertParameters.Add( "title", titleText );
                sdsTodo.InsertParameters.Add( "priority", priority.ToString() );
                sdsTodo.InsertParameters.Add( "finished", DbType.Boolean, "FALSE" );
                sdsTodo.Insert();
            }
            //if message is empty and user selected a enddate
            else if ( itemMessage == string.Empty && endDate != DateTime.MinValue )
            {
                query =
                    "INSERT INTO Todo (Title, Priority, Enddate, Finished) VALUES(@title, @priority, @enddate, @finished)";
                sdsTodo.InsertCommand = query;
                sdsTodo.InsertParameters.Add( "title", titleText );
                sdsTodo.InsertParameters.Add( "priority", priority.ToString() );
                sdsTodo.InsertParameters.Add(
                    "enddate",
                    DbType.DateTime2,
                    endDate.ToString( CultureInfo.CurrentCulture ) );
                sdsTodo.InsertParameters.Add( "finished", DbType.Boolean, "FALSE" );
                sdsTodo.Insert();
            }
            //if message is not empty and user did not select a enddate
            else if ( itemMessage != string.Empty && endDate == DateTime.MinValue )
            {
                query = "INSERT INTO Todo (Title, Text, Priority, Finished) VALUES(@title, @text, @priority, @finished)";
                sdsTodo.InsertCommand = query;
                sdsTodo.InsertParameters.Add( "title", titleText );
                sdsTodo.InsertParameters.Add( "text", itemMessage );
                sdsTodo.InsertParameters.Add( "priority", priority.ToString() );
                sdsTodo.InsertParameters.Add( "finished", DbType.Boolean, "FALSE" );
                sdsTodo.Insert();
            }

            Response.Redirect( "~/default.aspx" );
        }

        protected void btnCancel_OnClick( object sender, EventArgs e )
        {
            Response.Redirect( "~/default.aspx" );
        }
        }
    }