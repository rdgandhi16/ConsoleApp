using System;
using System.Collections.Generic;
using System.Text;

namespace ClassandObject
{
    public class Person
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void GetfullName()
        {
            Console.WriteLine("My Fullname is {0} {1}.", FirstName, LastName);
        }

        public void Walk()
        {
            Console.WriteLine("I am walking..");
        }
        public void Talk()
        {
            Console.WriteLine("I am Talking..");
        }
        public void Eat()
        {
            Console.WriteLine("I am Eating...");
        }
        public void Sleep()
        {
            Console.WriteLine("I am sleeping..");
        }

    }
}
