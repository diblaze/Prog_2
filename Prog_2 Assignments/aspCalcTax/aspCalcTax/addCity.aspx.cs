using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace aspCalcTax
    {
    public partial class addCity : Page
        {
        protected void Page_Load( object sender, EventArgs e )
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnBack_OnClick( object sender, EventArgs e )
        {
            throw new NotImplementedException();
        }

        protected void btnAdd_OnClick( object sender, EventArgs e )
        {
            const string cmd = "INSERT INTO Taxes VALUES(@City,@LocalTax,@ChurchTax,@FuneralTax)";

            using (
                SqlConnection connection =
                    new SqlConnection( ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString ) )
            {
                using ( SqlCommand command = new SqlCommand( cmd, connection ) )
                {
                    command.Parameters.AddWithValue( "@City", txtKommun.Text );
                    command.Parameters.AddWithValue( "@LocalTax", Convert.ToDouble(txtLocalTax.Text) );
                    command.Parameters.AddWithValue( "@ChurchTax", Convert.ToDouble(txtChurchTax.Text));
                    command.Parameters.AddWithValue( "@FuneralTax", Convert.ToDouble(txtFuneralTax.Text) );
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        }
    }