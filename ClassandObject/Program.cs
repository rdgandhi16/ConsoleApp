using System;

namespace ClassandObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.FirstName = "Rinkal";
            p.LastName = "Gandhi";



            p.GetfullName();
            p.Walk();
            p.Eat();
            p.Sleep();
            Console.ReadLine();


            SuperPerson sp = new SuperPerson();
            sp.FirstName = "Roma";
            sp.LastName = "Modi";
            sp.GetfullName();
            sp.fly();
            sp.Walk();
            sp.Eat();
            sp.Talk();

            Console.ReadLine();
        }
    }
}
