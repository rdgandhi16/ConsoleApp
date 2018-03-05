using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            player p = new player();

            //p.Weapon = Console.ReadLine();

            if (p.Weapon==Enum.Weapons.Launchers)
            {
                Console.WriteLine("Launch it......");
            }
            else if (p.Weapon==Enum.Weapons.Revolvers)
            {
                Console.WriteLine("Resolver...");
            }
            else if (p.Weapon == Enum.Weapons.Rifles)
            {
                Console.WriteLine("Shoot it...");
            }
            else if (p.Weapon == Enum.Weapons.SniperRifel)
            {
                Console.WriteLine("Hide...");
            }
            else
            {
                Console.WriteLine("No Weapons Found...");
            }
            Console.ReadLine();
        }
    }
}
