using System;

namespace ReadandWriteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = System.IO.File.ReadAllText(@"R:\DotNet-2018\ConsoleApp\ReadandWriteFile\bac.txt");

            //string[] lines=System.IO.File.ReadAllLines(@"R:\DotNet-2018\ConsoleApp\ReadandWriteFile\bac.txt");


            //foreach (var line in lines)
            //{
            //    Console.WriteLine(line);
            //}
            //Console.WriteLine(text);


            string[] lines = { "This is line1", "This is line2", "This is Line3", "This is line4" };

            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(@"R:\DotNet-2018\ConsoleApp\ReadandWriteFile\bac.txt"))
            {
                foreach (var line in lines)
                {
                    writer.WriteLine(line);
                }
            }
            Console.ReadLine();
        }
    }
}
