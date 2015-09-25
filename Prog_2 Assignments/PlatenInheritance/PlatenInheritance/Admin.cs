using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlatenInheritance
{
    public class Admin : Person
    {
        private string _position;
        private bool _manager;

        public Admin(string firstName, string lastName, char gender, string socialSecurityNumber, string city, string adress, string zipCode, bool citizen, string telephone, string eMail, string position, bool manager) : base(firstName, lastName, gender, socialSecurityNumber, city, adress, zipCode, citizen, telephone, eMail)
        {
            _position = position;
            _manager = manager;
        }
    }
}