using System;

namespace switchStatement
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your choice...");
            string choice = Console.ReadLine();
            Console.WriteLine("Please enter another choice...");
            string choice1 = Console.ReadLine();
            switch (choice)
            {
                case "Rinkal":

                    break;
                    

                case "Gandhi":
                    break;

                default:
                    Console.WriteLine("Rinkal Gandhi");
                    break;
            }
            if (choice=="Rinkal" && choice1=="Gandhi")
            {
                Console.WriteLine("Choice is Rinkal Gnadhi");
            }
            else if (choice=="Gandhi")
            {
                Console.WriteLine("Choice is Gandhi");
            }
            else
            {
                Console.WriteLine("Wrong Choice...");
            }
            Console.ReadLine();
        }
    }
}
