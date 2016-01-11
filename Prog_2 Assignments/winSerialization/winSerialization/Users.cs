using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace winSerialization
{
    public class Users
    {
        [XmlElement("User")]
        public List<User> UserList = new List<User>();
    }

    [Serializable]
    public class User
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Phone { get; set; }
    }
}