using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspCalcTax
{
    public partial class editCity : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnExit_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("~/default.aspx");
        }
    }
}