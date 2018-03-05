using System;

namespace StaticvsNonStatic
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Person.FormatFullname("Rinkal", "Gandhi"));

            Console.ReadLine();
        }
    }
}
