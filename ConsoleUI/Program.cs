using HelperLibrary;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> person = new List<Person>();
            person.Add(new Person { FirstName = "Rinkal", LastName = "Gandhi" });
            person.Add(new Person { FirstName = "Roma", LastName = "Modi" });
            person.Add(new Person { FirstName = "Pinkal", LastName = "Pastagia" });


            foreach (var people in person)
            {
                Console.WriteLine($"Hello {people.FirstName} {people.LastName}");
            }
            Console.ReadLine();
        }
    }
}
