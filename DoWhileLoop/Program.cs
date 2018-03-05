using System;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                input = Console.ReadLine();
                Console.WriteLine("Your input is {0}.", input);
            } while (!input.Equals(string.Empty));
        }
    }
}
