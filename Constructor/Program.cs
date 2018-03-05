using System;

namespace Constructor
{
    public class Program
    {
        static void Main(string[] args)
        {
            person p = new person("Rinkal","Gandhi");

            Console.WriteLine(p.GetFullname());
            Console.ReadLine();
        }
    }
}
