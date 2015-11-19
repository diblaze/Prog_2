using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspToDo
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddTodo_OnClick( object sender, EventArgs e )
        {
                Response.Redirect( "~/addTodo.aspx" );
        }

        protected void cbFinished_OnCheckedChanged( object sender, EventArgs e )
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns <c>True</c> if end date has not passed.
        /// </summary>
        /// <param name="eval"></param>
        /// <returns></returns>
        protected bool CheckEndDate( object eval )
        {
            if ( eval == null )
            {
                return false;
            }
            DateTime tempDate = DateTime.Today;
            string evalDate = eval as string;
            if ( evalDate == null )
            {
                return false;
            }
            DateTime evalDateConverted;
            DateTime.TryParse( evalDate, out evalDateConverted );
            return tempDate <= evalDateConverted;


        }
    }
}