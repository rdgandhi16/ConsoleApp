using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int i = 1; i <=5;)
            {
                if (i == 5) break;
                {
                    Console.WriteLine("Rinkal Gandhi {0}", i);
                    i++;
                }
                
            }
            Console.ReadLine();
        }
    }
}
