using System;

namespace IfelseStatement
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;
            Console.WriteLine("Enter the value of A");
            a = int.Parse(Console.ReadLine());

            int b;
            Console.WriteLine("Enter the value of B");
            b = int.Parse(Console.ReadLine());

            int c;
            Console.WriteLine("Enter the value of C");
            c = int.Parse(Console.ReadLine());

            if (a>b)
            {
                Console.WriteLine("a is greater then b");
            }
            else if (b>c)
            {
                Console.WriteLine("b is gretar then c");
            }
            else
            {
                Console.WriteLine("c is greatat then a and b");
            }
            //Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
