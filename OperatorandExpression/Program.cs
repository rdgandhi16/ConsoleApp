using System;

namespace OperatorandExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int a = 5 -10;
            int b = 500 * 5;

            int c = (((10 * 10) - 10) + a + b)/10;
            Console.WriteLine(c);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(a + b);
            Console.ReadLine();
        }
    }
}
