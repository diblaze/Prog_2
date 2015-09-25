using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace winTestServer
{
    public partial class Form1 : Form
    {
        private SqlConnection _conn = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\localDatabase.mdf;Integrated Security=True");

        private bool _connected;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = txtID.Text != "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;

            _conn.Open();
            var cmd = new SqlCommand("select ID, shelfID from [Books] where ID=" + id, _conn);
            var da = new SqlDataAdapter(cmd);

            var dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            _conn.Close();

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Book found with ID: " + dt.Rows[0].ItemArray[0] + ", should be placed in SHELF: " +
                                dt.Rows[0].ItemArray[1]);
            }
            else
            {
                MessageBox.Show("No books found with ID: " + id);
            }
            //MessageBox.Show(dt.ToString());
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            using (var command = new SqlCommand())
            {
                command.Connection = _conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT into [Books] (ID, shelfID) VALUES (@bookId, @shelf)";
                command.Parameters.AddWithValue("@bookId", txtID.Text);
                command.Parameters.AddWithValue("@shelf", txtShelfID.Text);

                try
                {
                    _conn.Open();
                    int recordsAffected = command.ExecuteNonQuery();
                }
                catch (SqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                }
                finally
                {
                    _conn.Close();
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!_connected)
            {
                try
                {
                    _conn =
                        new SqlConnection(
                            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\localDatabase.mdf;Integrated Security=True");
                    _conn.Open();
                    btnConnect.Text = @"Koppla bort";
                    _connected = true;
                    MessageBox.Show(@"Connected!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                _conn.Close();
                MessageBox.Show("Disconnected!");
                btnConnect.Text = @"Anslut";
                _connected = false;
            }
        }

        private void txtShelfID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtShelfID.Text != "")
            {
                btnAddBook.Enabled = true;
            }
            else
            {
                btnAddBook.Enabled = false;
            }
        }
    }
}