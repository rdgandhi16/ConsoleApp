using System;
using System.Collections.Generic;
using System.Text;

namespace Method
{
    public class Person
    {

        public string fname { get; set; }
        public string lname { get; set; }
        public string gender { get; set; }

        public string firstname { get; set; }
        public string lastname { get; set; }

        private int _lives = 100;
        public int Lives {
            get {
                return _lives;
            }
            set
            {
                if (value <=0 || value>=1000)
                {
                    Console.WriteLine("Does not make any sense..");
                    return;
                }
                _lives = value;
            }
        }
        public void GetFullname(string fname, string lname)
        {

            Console.WriteLine($"The fullname of the person is {fname} {lname}");
        }

        public void GetFullname(string firstname, string lastname, string gender)
        {

            Console.WriteLine($"The fullname of the person is {firstname} {lastname} and gender is {gender}"); 
        }
    }
}
