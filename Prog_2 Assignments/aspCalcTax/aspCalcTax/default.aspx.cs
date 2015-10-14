using System;
using System.Data;
using System.Drawing;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspCalcTax
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnCalc_OnClick(object sender, EventArgs e)
        {
            if (txtPNo.Text == string.Empty || !IsValidPNo(txtPNo.Text))
            {
                return;
            }

            if (txtSalary.Text == string.Empty)
            {
                return;
            }

            if (ddlProvince.SelectedValue == "0" || ddlProvince.SelectedValue == "1")
            {
                return;
            }

            DataView dv = dsTaxes.Select(DataSourceSelectArguments.Empty) as DataView;


            lblPNoErr.Visible = false;
            if (dv == null)
                return;

            Salary sal = new Salary
                         {
                             BruttoSalary = int.Parse(txtSalary.Text),
                             ChurchMember = rdChruch.SelectedValue == "Yes",
                             /* Ful lösning
                             ChurchTax = double.Parse(((Label)fvTaxData.FindControl("lblChurchTax")).Text.Replace("%", "").Trim()),
                             LocalTax = double.Parse(((Label)fvTaxData.FindControl("lblLocalTax")).Text.Replace("%", "").Trim()),
                             FuneralTax = double.Parse(((Label)fvTaxData.FindControl("lblFuneralTax")).Text.Replace("%", "").Trim())
                             */
                             LocalTax = double.Parse(dv[0]["LocalTax"].ToString()) / 100,
                             ChurchTax = double.Parse(dv[0]["ChurchTax"].ToString()) / 100,
                             FuneralTax = double.Parse(dv[0]["FuneralTax"].ToString()) / 100

                             
                         };
            Session["salary"] = sal;
            Response.Redirect("~/endresult.aspx");
        }

        private static bool IsValidPNo(string pno)
        {
            bool isValid = false;
            //Validation of Social Security
            if (pno.Length != 11)
            {
                return false;
            }

            int[] amountOfDaysInMonth =
            {
                31,
                29,
                31,
                30,
                31,
                30,
                31,
                31,
                30,
                31,
                30,
                31
            };

            int z = 0;
            int controlNumber = 0;
            for (int i = 0; i < pno.Length - 1; i++)
            {
                int number;
                //if "-" skip
                if (pno[i] == '-')
                {
                    continue;
                }
                //multiple with 2
                switch (z)
                {
                    case 0:
                        number = Convert.ToInt32(pno[i].ToString()) * 2;

                        if (number >= 10)
                        {
                            string numberString = number.ToString();
                            int number1 = Convert.ToInt32(numberString[0].ToString());
                            int number2 = Convert.ToInt32(numberString[1].ToString());
                            controlNumber += number1;
                            controlNumber += number2;
                        }
                        else
                        {
                            controlNumber += number;
                        }
                        z++;
                        continue;
                    //just add
                    case 1:
                        number = Convert.ToInt32(pno[i].ToString());
                        controlNumber += number;
                        z--;
                        break;
                }


            }

            string controlNumberString = controlNumber.ToString(); //easy way

            int result = 10 - Convert.ToInt32(controlNumberString[1].ToString());
            if (result == 10)
            {
                result = 0;
            }


            if (pno[10].ToString() == result.ToString())
            {
                isValid = true;
            }
/*
            string monthString = pno.Substring(2, 2);
            if (Convert.ToInt32(monthString) > 0 && Convert.ToInt32(monthString) < 13)
            {
                string dayString = pno.Substring(4, 5);
                int tempMonth = 0;
                tempMonth = monthString[0] == '0' ? Convert.ToInt32(monthString[1]) : Convert.ToInt32(monthString);

                if (Convert.ToInt32(dayString) > 0 && Convert.ToInt32(dayString) <= amountOfDaysInMonth[tempMonth - 1])
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }

            }
            else
            {
                isValid = false;
            }


    */

            return isValid;
        }
    }
}