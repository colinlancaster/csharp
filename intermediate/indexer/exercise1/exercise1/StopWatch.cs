using System;

namespace exercise1
{
    public class StopWatch
    {

        public DateTime Start
        {
            get
            {
                var start = DateTime.Now;

                return start;
            }
        }

        public TimeSpan Stop
        {
            get
            {
                var stop = Start - DateTime.Now;
                return stop;
            }
            
        }
    }
}