using System;

namespace Constant
{
    class Program
    {

        public const double PI = 3.14;

        static void Main(string[] args)
        {

            const string SomeConstant = "Constant Value";

            Console.WriteLine(SomeConstant);
            Console.WriteLine(PI);
            Console.ReadLine();
        }
    }
}
