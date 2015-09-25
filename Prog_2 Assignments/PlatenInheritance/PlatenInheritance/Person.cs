using System;
using System.Globalization;

namespace PlatenInheritance
{
    public class Person
    {
        //main information
        private string _firstName;
        private string _lastName;
        private char _gender;
        private string _socialSecurityNumber;
        private bool _citizen;
        private int _age;
        private bool _ofAge;

        //whereabouts
        private string _city;
        private string _adress;
        private string _zipCode;

        //contact information
        private string _telephone;
        private string _eMail;


        public Person(string firstName, string lastName, char gender, string socialSecurityNumber, string city,
                      string adress, string zipCode, bool citizen, string telephone, string eMail)
        {
            _firstName = firstName;
            _lastName = lastName;
            _gender = gender;
            _socialSecurityNumber = socialSecurityNumber;
            _city = city;
            _adress = adress;
            _zipCode = zipCode;
            _citizen = citizen;
            _telephone = telephone;
            _eMail = eMail;

            _age = CalculateAge(_socialSecurityNumber);
            _ofAge = _age >= 18;
        }

        private static int CalculateAge(string socialSecurityNumber)
        {
            int age;
            if (socialSecurityNumber == null)
            {
                return 0;
            }
            bool isShortNumber = socialSecurityNumber?.Length == 12;

            if (isShortNumber)
            {
                //retrive birthdate
                int yearOfBirth = Convert.ToInt32(socialSecurityNumber.Substring(0, 1)); //retrives y.o.b
                int monthOfBirth = Convert.ToInt32(socialSecurityNumber.Substring(2, 3)); //retrives m.o.b
                int dayOfBirth = Convert.ToInt32(socialSecurityNumber.Substring(4, 5)); //retrives d.o.b
                Calendar testCalendar = new GregorianCalendar();
                yearOfBirth = testCalendar.ToFourDigitYear(yearOfBirth);
                testCalendar = null; //dispose of calendar

                DateTime birthDate = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth); //when the person was born
                DateTime todayTime = DateTime.Now.Date; //todays date
                DateTime birthDay = new DateTime(todayTime.Year, monthOfBirth, dayOfBirth);
                    //the persons birthday this year

                int birthDateAdjustment = todayTime < birthDay ? -1 : 0;
                    //check if the persons birthday has already occured

                age = todayTime.Year - birthDate.Year + birthDateAdjustment;
            }
            else
            {
                //retrive birthdate
                int yearOfBirth = Convert.ToInt32(socialSecurityNumber.Substring(0, 3)); //retrives y.o.b
                int monthOfBirth = Convert.ToInt32(socialSecurityNumber.Substring(4, 5)); //retrives m.o.b
                int dayOfBirth = Convert.ToInt32(socialSecurityNumber.Substring(6, 7)); //retrives d.o.b

                DateTime birthDate = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth); //when the person was born
                DateTime todayTime = DateTime.Now.Date; //todays date
                DateTime birthDay = new DateTime(todayTime.Year, monthOfBirth, dayOfBirth);
                //the persons birthday this year

                int birthDateAdjustment = todayTime < birthDay ? -1 : 0;
                //check if the persons birthday has already occured

                age = todayTime.Year - birthDate.Year + birthDateAdjustment;
            }
            return age;
        }
    }
}