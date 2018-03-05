using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 10, 100, 1000, 10000 };

            List<int> list=new List<int>();
            list.Add(1);
            list.Add(1000);

            //list.RemoveAt(5);
            //Console.WriteLine(list);
            Console.ReadLine();
        }
    }
}
