using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;

            while (index<=10)
            {
                Console.WriteLine("The number is {0}", index);
                index = index+1;
            }
            Console.ReadLine();
        }
    }
}
