using System;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread th = new Thread(() =>
            {
                Console.WriteLine("Thread Concept....");
            });

            th.Start();

            Task t = Task.Factory.StartNew(() =>
              {
                  Console.WriteLine("Task Concept..");
              });
        }
    }
}
