using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspToDo
    {
    public partial class _default : Page
        {
        protected void Page_Load( object sender, EventArgs e )
        {
            if(Request.Url.AbsoluteUri.Contains( "default.aspx/admin" ))
            {
                sdsTodo.DeleteCommand = "DELETE FROM Todo";
                sdsTodo.Delete();
            }
        }

        protected void btnAddTodo_OnClick( object sender, EventArgs e )
        {
            Response.Redirect( "~/addTodo.aspx" );
        }

        protected void cbFinished_OnCheckedChanged( object sender, EventArgs e )
        {
            /* Vanligt


            foreach ( RepeaterItem ri in rContent.Items ) //find the checkbox that changed
            {
                CheckBox checkFlag = ri.FindControl( "cbFinished" ) as CheckBox;

                if ( checkFlag == null || !checkFlag.Checked )
                {
                    continue;
                }

                string idToUpdate = ( ri.FindControl( "lId" ) as Literal )?.Text;

                const string updateSqlQuery = "UPDATE Todo SET Finished=@Finished WHERE Id=@Id";
                sdsTodo.UpdateCommand = updateSqlQuery;
                sdsTodo.UpdateParameters.Add( "Finished", "True" );
                sdsTodo.UpdateParameters.Add( "Id", idToUpdate );
                sdsTodo.Update();   
            }
            */

            foreach ( string idToUpdate in from RepeaterItem ri in rContent.Items
                                           let checkFlag = ri.FindControl( "cbFinished" ) as CheckBox
                                           where checkFlag != null && checkFlag.Checked
                                           select ( ri.FindControl( "lId" ) as Literal )?.Text )
            {
                const string updateSqlQuery = "UPDATE Todo SET Finished=@Finished WHERE Id=@IdOrg";
                sdsTodo.UpdateCommand = updateSqlQuery;
                sdsTodo.UpdateParameters.Add( "Finished", "True" );
                sdsTodo.UpdateParameters.Add("IdOrg", idToUpdate);
                sdsTodo.Update();
            }
        }
        }
    }