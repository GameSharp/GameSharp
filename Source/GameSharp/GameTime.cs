using System;
using System.Diagnostics;

namespace GameSharp
{
    public class GameTime
    {
        private Stopwatch stopwatch = Stopwatch.StartNew();

        public TimeSpan Elapsed { get { return stopwatch.Elapsed; } }
    }
}
