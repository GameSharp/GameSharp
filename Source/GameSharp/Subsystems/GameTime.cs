using System;
using System.Diagnostics;

namespace GameSharp
{
    public static class GameTime
    {
        private static Stopwatch stopwatch = Stopwatch.StartNew();
        private static TimeSpan previous = TimeSpan.Zero;

        public static TimeSpan Elapsed { get { return stopwatch.Elapsed; } }
        public static TimeSpan Step { get; private set; }

        public static void Update()
        {
            Step = Elapsed - previous;
            previous = Elapsed;
        }
    }
}
