using System;
using System.IO;
using System.Threading;

namespace CountContent
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            CountCharacter();
            Console.ReadLine();
        }

        public static void CountCharacter()
        {
            int count = 0;
            
            using (StreamReader reader = new StreamReader("R:\\DotNet-2018\\data.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;

                //Thread.Sleep(1000);

            }
            Console.WriteLine(count);
        }
    }
}
