using System;

namespace OveloadingandOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            person p = new person("Roma", "Female");

            person p1 = new person("Rinkal", "Gandhi", "Male");

            Console.WriteLine(p.GetFullnamewithAge());

            Console.WriteLine(p1.GetFullnamewithAge());
            
            Console.ReadLine();
        }
    }
}
