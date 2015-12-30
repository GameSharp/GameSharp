using System;
using System.Diagnostics;

namespace GameSharp
{
    public class GameTime
    {
        private Stopwatch stopwatch = Stopwatch.StartNew();
        private TimeSpan previous = TimeSpan.Zero;

        public TimeSpan Elapsed { get { return stopwatch.Elapsed; } }
        public TimeSpan Step { get; private set; }

        public void Update()
        {
            Step = Elapsed - previous;
            previous = Elapsed;
        }
    }
}
