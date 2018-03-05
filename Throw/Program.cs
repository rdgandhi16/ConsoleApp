using System;

namespace Throw
{
    class Program
    {
        static void Main(string[] args)
        {
            int ourMoney = OurMoney(10,-10);
        }

        public static int OurMoney(int myMoney, int yourMoney)
        {
            if (myMoney <0 || yourMoney <0)throw new ArithmeticException("My Money or Your Money is not valid...");

            return myMoney + yourMoney;
        }
    }
}
