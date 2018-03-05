using System;

namespace SampleString
{
    class Program
    {
        static void Main(string[] args)
        {
            string samplestring1 = "sample1";
            string samplestring2 = "sample123";


            if (samplestring1!=samplestring2)
            {
                Console.WriteLine("They are not Equal");
            }
            else
            {
                Console.WriteLine("They are  equal");
            }

            Console.WriteLine(samplestring1.Length);
            Console.WriteLine(samplestring2.Length);

            Console.WriteLine(samplestring1[3]);

            for (int i = 0; i < samplestring1.Length; i++)
            {
                Console.WriteLine(samplestring1[i]);
            }

            string substringofsample = samplestring1.Substring(2, 5);

            Console.WriteLine(substringofsample);
            Console.WriteLine(samplestring1.ToUpper());
            Console.WriteLine(samplestring1.ToLower());


            string splitstring = "split1, split2, split3, split4";

            string[] words =splitstring.Split(',');
            string jointstring = string.Join("", words);
            Console.WriteLine(words);
            Console.ReadLine();
        }
    }
}
