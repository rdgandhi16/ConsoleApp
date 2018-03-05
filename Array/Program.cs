using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 10;
            array[2] = 100;
            array[3] = 1000;
            array[4] = 10000;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }


            //Two Dimensional Array
            //int[,] array = new int[5,2];

            //array[0,0] = 1;
            //array[0,1] = 2;
            //array[1,0] = 3;
            //array[1,1] = 4;
            //array[2,0] = 5;
            //array[2,1] = 6;
            //array[3,0] = 7;
            //array[3,1] = 8;
            //array[4,0] = 9;
            //array[4,1] = 1;


            //Console.Write(array[0, 0]);
            //Console.Write(array[0, 1]);
            //Console.WriteLine();

            //Console.Write(array[1, 0]);
            //Console.Write(array[1, 1]);
            //Console.WriteLine();

            //Console.Write(array[2, 0]);
            //Console.Write(array[2, 1]);
            //Console.WriteLine();

            //Console.Write(array[3, 0]);
            //Console.Write(array[3, 1]);
            //Console.WriteLine();

            //Console.Write(array[4, 0]);
            //Console.Write(array[4, 1]);
            //Console.WriteLine();


            //Single array
            //int[] array = new int[5];
            //array[0] = 100;
            //array[1] = 200;
            //array[2] = 300;
            //array[3] = 400;
            //array[4] = 500;

            //Console.WriteLine(array.Rank);
            //Console.WriteLine(array.Length);

            //Console.WriteLine(array[0]*array[1]);
            //Console.WriteLine(array[1]+array[1]);
            //Console.WriteLine(array[2]);
            //Console.WriteLine(array[3]);
            //Console.WriteLine(array[4]);

            Console.ReadLine();
        }
    }
}
