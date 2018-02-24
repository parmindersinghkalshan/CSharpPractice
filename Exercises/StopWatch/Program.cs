using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            for (int i = 1; i <= 2; i++)
            {
                stopwatch.Start();
                Thread.Sleep(4000);
                stopwatch.Stop();
                stopwatch.Duration();
            }

            Console.ReadLine();
        }
    }
}
