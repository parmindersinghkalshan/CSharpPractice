using System;

namespace StopWatch
{
    public class Stopwatch
    {
        private bool watchAvailable = true;
        private DateTime startTime;
        private DateTime stopTime;
        private TimeSpan duration;

        public void Start()
        {
            if (!watchAvailable)
            {
                throw new InvalidOperationException("Can not start watch twice");
            }

            startTime = DateTime.Now;
            watchAvailable = false;
            Console.WriteLine($"Start Time = {startTime}");
        }

        public void Stop()
        {
            stopTime = DateTime.Now;
            watchAvailable = true;
            Console.WriteLine($"Stop Time = {stopTime}");
        }

        public void Duration()
        {
            duration = startTime - stopTime;
            Console.WriteLine($"Duration = {(stopTime - startTime)}");
        }
    }
}
