using System;
using System.Web.UI;

namespace aspCalcTax
{
    public partial class Endresult : Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {
            Salary sal = (Salary) (Session["salary"]);
            


            //set values to output
            //lblProvince.Text = "Kommun: " + sal.GetProvince();
            lblSalary.Text = "Lön före skatt: " + sal.BruttoSalary + " kr";
            lblTax.Text = "Skatt: " + sal.Tax + " kr";
            lblNet.Text = "Lön efter skatt: " + sal.Net + " kr";

            ShowResult();
        }

        private void ShowResult()
        {
            pnlResult.Visible = true;
        }
    }
}