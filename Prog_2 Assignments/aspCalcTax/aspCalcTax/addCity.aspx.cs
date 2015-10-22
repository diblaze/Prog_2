using System;
using System.Configuration;
using System.Data.SqlClient;
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
            Response.Redirect("~/default.aspx");
        }

        protected void btnAdd_OnClick(
            object sender,
            EventArgs e)
        {
            const string cmd = "INSERT INTO Taxes VALUES(@City,@LocalTax,@ChurchTax,@FuneralTax)";
            double doubleLocalTax = double.Parse(
                                                 txtLocalTax.Text.TrimEnd(
                                                                          '%',
                                                                          ' '));
            double doubleChurchTax = double.Parse(
                                                  txtChurchTax.Text.TrimEnd(
                                                                            '%',
                                                                            ' '));
            double doubleFuneralTax = double.Parse(
                                                   txtFuneralTax.Text.TrimEnd(
                                                                              '%',
                                                                              ' '));
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
                                                    txtKommun.Text);
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
                }
            }
        }
    }
}