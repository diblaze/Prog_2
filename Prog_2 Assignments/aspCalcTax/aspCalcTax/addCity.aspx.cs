using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Web.UI;

namespace aspCalcTax
{
    public partial class addCity : Page
    {
        protected void Page_Load(
            object sender,
            EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnBack_OnClick(
            object sender,
            EventArgs e)
        {
            Response.Redirect(
                              "~/default.aspx");
        }

        protected void btnAdd_OnClick(
            object sender,
            EventArgs e)
        {
            const string cmd = "INSERT INTO Taxes VALUES(@City,@LocalTax,@ChurchTax,@FuneralTax)";
            double doubleLocalTax = double.Parse(
                                                 txtLocalTax.Text.TrimEnd(
                                                                          '%',
                                                                          ' '), NumberStyles.AllowDecimalPoint) / 100;
            double doubleChurchTax = double.Parse(
                                                  txtChurchTax.Text.TrimEnd(
                                                                            '%',
                                                                            ' '), NumberStyles.AllowDecimalPoint) / 100;
            double doubleFuneralTax = double.Parse(
                                                   txtFuneralTax.Text.TrimEnd(
                                                                              '%',
                                                                              ' '), NumberStyles.AllowDecimalPoint) / 100;
            try
            {
                lblCityError.Text = "";
                using (
                    SqlConnection connection =
                        new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(
                        cmd,
                        connection))
                    {
                        command.Parameters.AddWithValue(
                                                        "@City",
                                                        txtCity.Text);
                        command.Parameters.AddWithValue(
                                                        "@LocalTax",
                                                        doubleLocalTax);
                        command.Parameters.AddWithValue(
                                                        "@ChurchTax",
                                                        doubleChurchTax);
                        command.Parameters.AddWithValue(
                                                        "@FuneralTax",
                                                        doubleFuneralTax);

                        connection.Open();
                        command.ExecuteNonQuery();
                        Response.Redirect(
                                          "~/default.aspx");
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    txtCity.ForeColor = Color.Red;
                    lblCityError.Text = "Kommunen finns redan!";
                }
            }
        }
    }
}