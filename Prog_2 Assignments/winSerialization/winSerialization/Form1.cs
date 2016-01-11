using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace winSerialization
{
    public partial class Form1 : Form
    {
        private const string PathToFile = @"C:\Test";
        private const string FileName = "db.dat";
        private Users users;
       // private User user;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User user = GetUserData();
            if (users == null)
            {
                users = new Users();
            }
            users.UserList.Add(user);

            WriteData();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
        }

        private void WriteData()
        {
            try
            {
                while (!Directory.Exists(PathToFile))
                {
                    Directory.CreateDirectory(PathToFile);
                }

                XmlSerializer xmlSerializer = new XmlSerializer(typeof (Users));
                TextWriter tw = new StreamWriter(Path.Combine(PathToFile, FileName), false);

                xmlSerializer.Serialize(tw, users);
                tw.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private User GetUserData()
        {
            User usr = new User();
            if (tbFirstName.Text.Length > 0 && tbSurName.Text.Length > 0 && tbPhone.Text.Length > 0)
            {
                usr.FirstName = tbFirstName.Text;
                usr.SurName = tbSurName.Text;
                usr.Phone = tbPhone.Text;
            }
            else
            {
                return null;
            }
            return usr;
        }
    }
}