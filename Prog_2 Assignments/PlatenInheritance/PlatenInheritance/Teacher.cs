using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlatenInheritance
{
    public class Teacher : Person
    {
        private bool _manager;
        private bool _substitute;
        private bool _mentor;

        public Teacher(string firstName, string lastName, char gender, string socialSecurityNumber, string city, string adress, string zipCode, bool citizen, string telephone, string eMail, bool manager, bool substitute, bool mentor) : base(firstName, lastName, gender, socialSecurityNumber, city, adress, zipCode, citizen, telephone, eMail)
        {
            _manager = manager;
            _substitute = substitute;
            _mentor = mentor;
        }
    }
}