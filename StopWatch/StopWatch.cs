using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public class StopWatch
    {
        private DateTime startTime;
        private DateTime endTime;
        private bool running;

        public StopWatch()
        {
            startTime = DateTime.MinValue;
            endTime = DateTime.MinValue;
            running = false;
        }

        public DateTime StartTime
        {
            get { return startTime; }
        }

        public DateTime EndTime
        {
            get { return endTime; }
        }

        public void Start()
        {
            startTime = DateTime.Now;
            running = true;
        }

        public void Stop()
        {
            endTime = DateTime.Now;
            running = false;
        }

        public TimeSpan GetElapsedTime()
        {
            if (running)
            {
                // Stopwatch is still running
                return DateTime.Now - startTime;
            }
            else
            {
                // Stopwatch has stopped
                return endTime - startTime;
            }
        }
    }
}
