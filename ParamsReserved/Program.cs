using System;

namespace ParamsReserved
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Getsum(5,23,1));
            Console.WriteLine(GEtSumImproved(1, 4, 8, 5, 7, 8, 9, 5));
            Console.WriteLine(GEtSumImproved(1, 2));
            Console.WriteLine(GEtSumImproved(5, 5, 7));
            Console.ReadLine();
        }

        static int Getsum(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }
        static int GEtSumImproved(params int[] numbersToSum)
        {
            int sum = 0;
            foreach (var number in numbersToSum)
            {
                sum = sum + number;
            }
            return sum;
        }
    }
}
