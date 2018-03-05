using System;
using System.Collections.Generic;

namespace CheckOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            //--1
            //int[] arr = new int[2];
            //arr[1] = 10;
            //Object o = arr;
            //int[] arr1 = (int[])o;
            //arr1[1] = 100;
            //Console.WriteLine(arr[1]);
            //((int[])o)[1] = 1000;
            //Console.WriteLine(arr[1]);

            //--2
            //#if (!pi)
            //            Console.WriteLine("i");
            //#else
            //                    Console.WriteLine("PI undefined");
            //#endif
            //            Console.WriteLine("ok");

            //--3
            //byte num = 100;
            //dynamic val = num;
            //Console.WriteLine(val.GetType());
            //val += 100;
            //Console.WriteLine(val.GetType());

            //--4
            //String a = "ABC";
            //String b = "ABC";
            //int c;
            //c = a.CompareTo(b);
            //Console.WriteLine(c);


            //--5
            //char x = 'A';
            //int i = 0;
            //Console.WriteLine(true ? x : 0);
            //Console.WriteLine(false ? i : x);


            //--6
            //int a = 0x0c;
            //a ^= 0x06;
            //Console.WriteLine("0x{0:x8}", a);
            //bool b = true;
            //b ^= false;
            //Console.WriteLine(b);

            //--7
            //int num1 = 20;
            //int num2 = 30;
            //num1 ^= num2 ^= num1 ^= num2;
            //Console.WriteLine(num1 + "," + num2);

            //char[] num = { '1', '2', '3' };
            //Console.WriteLine(" char array: " + num);



            Console.ReadLine();
         }



        //Method to check o/p of array length
        //static void Main(string[] args)
        //{
        //    int[] arr = new int[10];
        //    arrayMethod(arr);
        //    Console.WriteLine(arr.Length);
        //    Console.ReadLine();
        //}
        //public static void arrayMethod(int[] a)
        //{
        //    int[] b = new int[5];
        //    a = b;

        //   // return;
        //}



        //public static void Main(string[] args)
        //{
        //    Program p = new Program();
        //    p.print(2, 3, 8);
        //    int[] arr = { 2, 11, 15, 20 };
        //    p.print(arr);
        //    Console.ReadLine();
        //}
        //public void print(params int[] b)
        //{
        //    foreach (var item in b)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
    }
}
