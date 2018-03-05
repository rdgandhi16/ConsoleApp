using System;
using System.Collections.Generic;
using System.Text;

namespace OveloadingandOverriding
{
    class person
    {

        private string _firstname;
        private string _lastname;
        private string _gender;

        public person(string firstname, string gender)
        {
            _firstname = firstname;
            _lastname = "Gandhi";
            _gender = gender;
        }
        public person(string firstname, string lastname, string gender)
        {
            _firstname = firstname;
            _lastname = lastname;
            _gender = gender;
        }
        public string GetFullnamewithAge()
        {
            return $"Person fullname and gender is {_firstname} {_lastname} {_gender}";
        }


        public string GetFullname()
        {
            return $"Person is {_firstname} {_lastname} {_gender}";
        }
    }
}
