using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winHotelManagement
{
    static class DatabaseManager
    {

        private static string ConnectionString => Properties.Settings.Default.ConnectionString;

        public static void GetAllRooms()
        {
            DataContext db = new DataContext(new SqlConnection(ConnectionString));

            Table<Suite> suites = db.GetTable<Suite>();

            IQueryable<Suite> suiteQuery = from c in suites select c;

            foreach (Suite c in suiteQuery)
            {
                MessageBox.Show(c.RoomNumber + " : " + c.Minibar);
            }
        }
    }
}
