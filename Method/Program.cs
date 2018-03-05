using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

           p.GetFullname(fname:"Rinkal", lname:"Gandhi");
           p.GetFullname(firstname: "Roma", lastname: "Modi", gender:"Female");

           // Console.WriteLine(fullname);
            //Console.WriteLine(fullnamewithgender);
            Console.ReadLine();
        }
    }
}
