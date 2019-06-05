using System;

namespace stopwatch
{
    public class Stopwatch
    {
        public int Number = 0;
        private DateTime _time;
        public void Start (DateTime now)
        {
            if (Number == 0)
            {
                Number = 1;
                _time = now;
            }
            else
            {
                Console.WriteLine("Wpisz komende: Stop");
            }
        }
        public void Stop(DateTime compare)
        {
            if (Number == 1)
            {
                Number = 0;
                TimeSpan result = compare - _time;
                Console.WriteLine("Minelo: " + result);
            }
            else
            {
                Console.WriteLine("Najpierw wpisz komende: Start");
            }
        }
        
    }
}
