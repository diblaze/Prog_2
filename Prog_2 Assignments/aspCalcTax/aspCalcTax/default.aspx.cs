using System;
using System.Drawing;
using System.Web.Configuration;
using System.Web.UI;

namespace aspCalcTax
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        
        protected void btnCalc_OnClick(object sender, EventArgs e)
        {
            if (IsValidPNo(txtPNo.Text) && txtPNo.Text != string.Empty && txtSalary.Text != string.Empty)
            {
                lblPNoErr.Visible = true;
                lblPNoErr.ForeColor = Color.Green;
                Session["salary"] = txtSalary.Text;
                Session["churchRadio"] = rdChruch.SelectedValue;
                //Page.ClientScript.RegisterStartupScript(this.GetType(), "redirect", "window.open('endresult.aspx')", true);
                //btnCalc.OnClientClick = "window.open('endresult.aspx')";
                Response.Redirect("~/endresult.aspx");
            }
            else
            {
                lblPNoErr.Visible = true;
                lblPNoErr.ForeColor = Color.Red;
            }
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




            return isValid;
        }
    }
}