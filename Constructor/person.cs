using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    public class person
    {
        private string _firstname;
        private string _lastname;
        public person(string firstname, string lastname)
        {
            _firstname = firstname;
            _lastname = lastname;
        }

        public string GetFullname()
        {
            return $"{_firstname} {_lastname}";
        }
    }
}
