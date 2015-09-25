using System;
using System.Web.UI;

namespace aspCalcTax
{
    public partial class Endresult : Page
    {
        private string _churchMember;
        private string _salaryText;

        protected void Page_Load(object sender, EventArgs e)
        {
            _salaryText = (string) (Session["salary"]);
            _churchMember = (string) (Session["churchRadio"]);

            //get user input
            double salary = double.Parse(_salaryText);
            //calc tax and net
            double tax = salary * (0.3190 + ChurchFee());
            double net = salary - tax;

            //set values to output
            lblSalary.Text = "Lön före skatt: " + salary + " kr";
            lblTax.Text = "Skatt: " + tax + " kr";
            lblNet.Text = "Lön efter skatt: " + net + " kr";

            ShowResult();
        }

        private void ShowResult()
        {
            pnlResult.Visible = true;
        }

        private double ChurchFee()
        {
            if (_churchMember == "Yes")
            {
                return (0.0034 + 0.0116);
            }

            return (0.0034);
        }
    }
}