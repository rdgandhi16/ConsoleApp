using System;
using System.Collections.Generic;
using System.Text;

namespace StaticvsNonStatic
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public Person(string _firstname, string _lastname)
        {
            Firstname=_firstname;
            Lastname = _lastname;
        }

        public static string FormatFullname(string _firstname, string _lastname)
        {
            return $"Fullname is {_firstname} {_lastname}";
        }
    }
}
